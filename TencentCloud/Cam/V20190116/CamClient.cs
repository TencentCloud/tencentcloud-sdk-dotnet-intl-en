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

namespace TencentCloud.Cam.V20190116
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cam.V20190116.Models;

   public class CamClient : AbstractClient{

       private const string endpoint = "cam.tencentcloudapi.com";
       private const string version = "2019-01-16";
       private const string sdkVersion = "SDK_NET_3.0.953";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a sub-user.
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public Task<AddUserResponse> AddUser(AddUserRequest req)
        {
            return InternalRequestAsync<AddUserResponse>(req, "AddUser");
        }

        /// <summary>
        /// This API is used to create a sub-user.
        /// </summary>
        /// <param name="req"><see cref="AddUserRequest"/></param>
        /// <returns><see cref="AddUserResponse"/></returns>
        public AddUserResponse AddUserSync(AddUserRequest req)
        {
            return InternalRequestAsync<AddUserResponse>(req, "AddUser")
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
        /// This API (AttachGroupPolicy) is used to associate a policy with a user group.
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public Task<AttachGroupPolicyResponse> AttachGroupPolicy(AttachGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachGroupPolicyResponse>(req, "AttachGroupPolicy");
        }

        /// <summary>
        /// This API (AttachGroupPolicy) is used to associate a policy with a user group.
        /// </summary>
        /// <param name="req"><see cref="AttachGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachGroupPolicyResponse"/></returns>
        public AttachGroupPolicyResponse AttachGroupPolicySync(AttachGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachGroupPolicyResponse>(req, "AttachGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (AttachRolePolicy) is used to associate a policy with a role.
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public Task<AttachRolePolicyResponse> AttachRolePolicy(AttachRolePolicyRequest req)
        {
            return InternalRequestAsync<AttachRolePolicyResponse>(req, "AttachRolePolicy");
        }

        /// <summary>
        /// This API (AttachRolePolicy) is used to associate a policy with a role.
        /// </summary>
        /// <param name="req"><see cref="AttachRolePolicyRequest"/></param>
        /// <returns><see cref="AttachRolePolicyResponse"/></returns>
        public AttachRolePolicyResponse AttachRolePolicySync(AttachRolePolicyRequest req)
        {
            return InternalRequestAsync<AttachRolePolicyResponse>(req, "AttachRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (AttachUserPolicy) is used to associates a policy with a user.
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy");
        }

        /// <summary>
        /// This API (AttachUserPolicy) is used to associates a policy with a user.
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a custom multi-factor Token.
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public Task<ConsumeCustomMFATokenResponse> ConsumeCustomMFAToken(ConsumeCustomMFATokenRequest req)
        {
            return InternalRequestAsync<ConsumeCustomMFATokenResponse>(req, "ConsumeCustomMFAToken");
        }

        /// <summary>
        /// This API is used to verify a custom multi-factor Token.
        /// </summary>
        /// <param name="req"><see cref="ConsumeCustomMFATokenRequest"/></param>
        /// <returns><see cref="ConsumeCustomMFATokenResponse"/></returns>
        public ConsumeCustomMFATokenResponse ConsumeCustomMFATokenSync(ConsumeCustomMFATokenRequest req)
        {
            return InternalRequestAsync<ConsumeCustomMFATokenResponse>(req, "ConsumeCustomMFAToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an access key for a CAM user.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyRequest"/></param>
        /// <returns><see cref="CreateAccessKeyResponse"/></returns>
        public Task<CreateAccessKeyResponse> CreateAccessKey(CreateAccessKeyRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyResponse>(req, "CreateAccessKey");
        }

        /// <summary>
        /// This API is used to create an access key for a CAM user.
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyRequest"/></param>
        /// <returns><see cref="CreateAccessKeyResponse"/></returns>
        public CreateAccessKeyResponse CreateAccessKeySync(CreateAccessKeyRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyResponse>(req, "CreateAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateOIDCConfigResponse"/></returns>
        public Task<CreateOIDCConfigResponse> CreateOIDCConfig(CreateOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateOIDCConfigResponse>(req, "CreateOIDCConfig");
        }

        /// <summary>
        /// This API is used to create role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateOIDCConfigResponse"/></returns>
        public CreateOIDCConfigResponse CreateOIDCConfigSync(CreateOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateOIDCConfigResponse>(req, "CreateOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreatePolicy) is used to create a policy.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public Task<CreatePolicyResponse> CreatePolicy(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy");
        }

        /// <summary>
        /// This API (CreatePolicy) is used to create a policy.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public CreatePolicyResponse CreatePolicySync(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a policy version. After creating a policy version, you can easily change the policy by changing the policy version.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public Task<CreatePolicyVersionResponse> CreatePolicyVersion(CreatePolicyVersionRequest req)
        {
            return InternalRequestAsync<CreatePolicyVersionResponse>(req, "CreatePolicyVersion");
        }

        /// <summary>
        /// This API is used to add a policy version. After creating a policy version, you can easily change the policy by changing the policy version.
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyVersionRequest"/></param>
        /// <returns><see cref="CreatePolicyVersionResponse"/></returns>
        public CreatePolicyVersionResponse CreatePolicyVersionSync(CreatePolicyVersionRequest req)
        {
            return InternalRequestAsync<CreatePolicyVersionResponse>(req, "CreatePolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateRole) is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public Task<CreateRoleResponse> CreateRole(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole");
        }

        /// <summary>
        /// This API (CreateRole) is used to create a role.
        /// </summary>
        /// <param name="req"><see cref="CreateRoleRequest"/></param>
        /// <returns><see cref="CreateRoleResponse"/></returns>
        public CreateRoleResponse CreateRoleSync(CreateRoleRequest req)
        {
            return InternalRequestAsync<CreateRoleResponse>(req, "CreateRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a SAML identity provider.
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public Task<CreateSAMLProviderResponse> CreateSAMLProvider(CreateSAMLProviderRequest req)
        {
            return InternalRequestAsync<CreateSAMLProviderResponse>(req, "CreateSAMLProvider");
        }

        /// <summary>
        /// This API is used to create a SAML identity provider.
        /// </summary>
        /// <param name="req"><see cref="CreateSAMLProviderRequest"/></param>
        /// <returns><see cref="CreateSAMLProviderResponse"/></returns>
        public CreateSAMLProviderResponse CreateSAMLProviderSync(CreateSAMLProviderRequest req)
        {
            return InternalRequestAsync<CreateSAMLProviderResponse>(req, "CreateSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a service-linked role.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRole(CreateServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<CreateServiceLinkedRoleResponse>(req, "CreateServiceLinkedRole");
        }

        /// <summary>
        /// This API is used to create a service-linked role.
        /// </summary>
        /// <param name="req"><see cref="CreateServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="CreateServiceLinkedRoleResponse"/></returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleSync(CreateServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<CreateServiceLinkedRoleResponse>(req, "CreateServiceLinkedRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user OIDC configuration. Only one user OIDC IdP can be created, and the user SAML SSO IdP will be automatically disabled after it is created.
        /// </summary>
        /// <param name="req"><see cref="CreateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateUserOIDCConfigResponse"/></returns>
        public Task<CreateUserOIDCConfigResponse> CreateUserOIDCConfig(CreateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateUserOIDCConfigResponse>(req, "CreateUserOIDCConfig");
        }

        /// <summary>
        /// This API is used to create a user OIDC configuration. Only one user OIDC IdP can be created, and the user SAML SSO IdP will be automatically disabled after it is created.
        /// </summary>
        /// <param name="req"><see cref="CreateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="CreateUserOIDCConfigResponse"/></returns>
        public CreateUserOIDCConfigResponse CreateUserOIDCConfigSync(CreateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<CreateUserOIDCConfigResponse>(req, "CreateUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public Task<CreateUserSAMLConfigResponse> CreateUserSAMLConfig(CreateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<CreateUserSAMLConfigResponse>(req, "CreateUserSAMLConfig");
        }

        /// <summary>
        /// This API is used to create user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="CreateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="CreateUserSAMLConfigResponse"/></returns>
        public CreateUserSAMLConfigResponse CreateUserSAMLConfigSync(CreateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<CreateUserSAMLConfigResponse>(req, "CreateUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an access key for a CAM user.
        /// Calling this API is a high-risk operation because the key cannot be recovered once deleted and Tencent Cloud will deny all requests that use this key. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessKeyRequest"/></param>
        /// <returns><see cref="DeleteAccessKeyResponse"/></returns>
        public Task<DeleteAccessKeyResponse> DeleteAccessKey(DeleteAccessKeyRequest req)
        {
            return InternalRequestAsync<DeleteAccessKeyResponse>(req, "DeleteAccessKey");
        }

        /// <summary>
        /// This API is used to delete an access key for a CAM user.
        /// Calling this API is a high-risk operation because the key cannot be recovered once deleted and Tencent Cloud will deny all requests that use this key. Proceed with caution.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessKeyRequest"/></param>
        /// <returns><see cref="DeleteAccessKeyResponse"/></returns>
        public DeleteAccessKeyResponse DeleteAccessKeySync(DeleteAccessKeyRequest req)
        {
            return InternalRequestAsync<DeleteAccessKeyResponse>(req, "DeleteAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete OIDC IdPs.
        /// </summary>
        /// <param name="req"><see cref="DeleteOIDCConfigRequest"/></param>
        /// <returns><see cref="DeleteOIDCConfigResponse"/></returns>
        public Task<DeleteOIDCConfigResponse> DeleteOIDCConfig(DeleteOIDCConfigRequest req)
        {
            return InternalRequestAsync<DeleteOIDCConfigResponse>(req, "DeleteOIDCConfig");
        }

        /// <summary>
        /// This API is used to delete OIDC IdPs.
        /// </summary>
        /// <param name="req"><see cref="DeleteOIDCConfigRequest"/></param>
        /// <returns><see cref="DeleteOIDCConfigResponse"/></returns>
        public DeleteOIDCConfigResponse DeleteOIDCConfigSync(DeleteOIDCConfigRequest req)
        {
            return InternalRequestAsync<DeleteOIDCConfigResponse>(req, "DeleteOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeletePolicy) is used to delete a policy.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public Task<DeletePolicyResponse> DeletePolicy(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy");
        }

        /// <summary>
        /// This API (DeletePolicy) is used to delete a policy.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyRequest"/></param>
        /// <returns><see cref="DeletePolicyResponse"/></returns>
        public DeletePolicyResponse DeletePolicySync(DeletePolicyRequest req)
        {
            return InternalRequestAsync<DeletePolicyResponse>(req, "DeletePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a policy version of a policy.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public Task<DeletePolicyVersionResponse> DeletePolicyVersion(DeletePolicyVersionRequest req)
        {
            return InternalRequestAsync<DeletePolicyVersionResponse>(req, "DeletePolicyVersion");
        }

        /// <summary>
        /// This API is used to delete a policy version of a policy.
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyVersionRequest"/></param>
        /// <returns><see cref="DeletePolicyVersionResponse"/></returns>
        public DeletePolicyVersionResponse DeletePolicyVersionSync(DeletePolicyVersionRequest req)
        {
            return InternalRequestAsync<DeletePolicyVersionResponse>(req, "DeletePolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteRole) is used to delete a specified role.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public Task<DeleteRoleResponse> DeleteRole(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole");
        }

        /// <summary>
        /// This API (DeleteRole) is used to delete a specified role.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoleRequest"/></param>
        /// <returns><see cref="DeleteRoleResponse"/></returns>
        public DeleteRoleResponse DeleteRoleSync(DeleteRoleRequest req)
        {
            return InternalRequestAsync<DeleteRoleResponse>(req, "DeleteRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a role permission boundary.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public Task<DeleteRolePermissionsBoundaryResponse> DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteRolePermissionsBoundaryResponse>(req, "DeleteRolePermissionsBoundary");
        }

        /// <summary>
        /// This API is used to delete a role permission boundary.
        /// </summary>
        /// <param name="req"><see cref="DeleteRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteRolePermissionsBoundaryResponse"/></returns>
        public DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundarySync(DeleteRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteRolePermissionsBoundaryResponse>(req, "DeleteRolePermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a SAML identity provider.
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public Task<DeleteSAMLProviderResponse> DeleteSAMLProvider(DeleteSAMLProviderRequest req)
        {
            return InternalRequestAsync<DeleteSAMLProviderResponse>(req, "DeleteSAMLProvider");
        }

        /// <summary>
        /// This API is used to delete a SAML identity provider.
        /// </summary>
        /// <param name="req"><see cref="DeleteSAMLProviderRequest"/></param>
        /// <returns><see cref="DeleteSAMLProviderResponse"/></returns>
        public DeleteSAMLProviderResponse DeleteSAMLProviderSync(DeleteSAMLProviderRequest req)
        {
            return InternalRequestAsync<DeleteSAMLProviderResponse>(req, "DeleteSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a service-linked role.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<DeleteServiceLinkedRoleResponse>(req, "DeleteServiceLinkedRole");
        }

        /// <summary>
        /// This API is used to delete a service-linked role.
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceLinkedRoleRequest"/></param>
        /// <returns><see cref="DeleteServiceLinkedRoleResponse"/></returns>
        public DeleteServiceLinkedRoleResponse DeleteServiceLinkedRoleSync(DeleteServiceLinkedRoleRequest req)
        {
            return InternalRequestAsync<DeleteServiceLinkedRoleResponse>(req, "DeleteServiceLinkedRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a sub-user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete a sub-user.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user permission boundary.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public Task<DeleteUserPermissionsBoundaryResponse> DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteUserPermissionsBoundaryResponse>(req, "DeleteUserPermissionsBoundary");
        }

        /// <summary>
        /// This API is used to delete a user permission boundary.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="DeleteUserPermissionsBoundaryResponse"/></returns>
        public DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundarySync(DeleteUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<DeleteUserPermissionsBoundaryResponse>(req, "DeleteUserPermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeOIDCConfigResponse"/></returns>
        public Task<DescribeOIDCConfigResponse> DescribeOIDCConfig(DescribeOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeOIDCConfigResponse>(req, "DescribeOIDCConfig");
        }

        /// <summary>
        /// This API is used to query role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeOIDCConfigResponse"/></returns>
        public DescribeOIDCConfigResponse DescribeOIDCConfigSync(DescribeOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeOIDCConfigResponse>(req, "DescribeOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRoleList) is used to get the role list under the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public Task<DescribeRoleListResponse> DescribeRoleList(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList");
        }

        /// <summary>
        /// This API (DescribeRoleList) is used to get the role list under the account.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoleListRequest"/></param>
        /// <returns><see cref="DescribeRoleListResponse"/></returns>
        public DescribeRoleListResponse DescribeRoleListSync(DescribeRoleListRequest req)
        {
            return InternalRequestAsync<DescribeRoleListResponse>(req, "DescribeRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a sub-account’s security settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public Task<DescribeSafeAuthFlagCollResponse> DescribeSafeAuthFlagColl(DescribeSafeAuthFlagCollRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagCollResponse>(req, "DescribeSafeAuthFlagColl");
        }

        /// <summary>
        /// This API is used to get a sub-account’s security settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagCollRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagCollResponse"/></returns>
        public DescribeSafeAuthFlagCollResponse DescribeSafeAuthFlagCollSync(DescribeSafeAuthFlagCollRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagCollResponse>(req, "DescribeSafeAuthFlagColl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query security settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public Task<DescribeSafeAuthFlagIntlResponse> DescribeSafeAuthFlagIntl(DescribeSafeAuthFlagIntlRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagIntlResponse>(req, "DescribeSafeAuthFlagIntl");
        }

        /// <summary>
        /// This API is used to query security settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeSafeAuthFlagIntlRequest"/></param>
        /// <returns><see cref="DescribeSafeAuthFlagIntlResponse"/></returns>
        public DescribeSafeAuthFlagIntlResponse DescribeSafeAuthFlagIntlSync(DescribeSafeAuthFlagIntlRequest req)
        {
            return InternalRequestAsync<DescribeSafeAuthFlagIntlResponse>(req, "DescribeSafeAuthFlagIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sub-users through the sub-user UIN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public Task<DescribeSubAccountsResponse> DescribeSubAccounts(DescribeSubAccountsRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountsResponse>(req, "DescribeSubAccounts");
        }

        /// <summary>
        /// This API is used to query sub-users through the sub-user UIN list.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubAccountsRequest"/></param>
        /// <returns><see cref="DescribeSubAccountsResponse"/></returns>
        public DescribeSubAccountsResponse DescribeSubAccountsSync(DescribeSubAccountsRequest req)
        {
            return InternalRequestAsync<DescribeSubAccountsResponse>(req, "DescribeSubAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user OIDC configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeUserOIDCConfigResponse"/></returns>
        public Task<DescribeUserOIDCConfigResponse> DescribeUserOIDCConfig(DescribeUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserOIDCConfigResponse>(req, "DescribeUserOIDCConfig");
        }

        /// <summary>
        /// This API is used to query the user OIDC configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserOIDCConfigRequest"/></param>
        /// <returns><see cref="DescribeUserOIDCConfigResponse"/></returns>
        public DescribeUserOIDCConfigResponse DescribeUserOIDCConfigSync(DescribeUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserOIDCConfigResponse>(req, "DescribeUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public Task<DescribeUserSAMLConfigResponse> DescribeUserSAMLConfig(DescribeUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserSAMLConfigResponse>(req, "DescribeUserSAMLConfig");
        }

        /// <summary>
        /// This API is used to query user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSAMLConfigRequest"/></param>
        /// <returns><see cref="DescribeUserSAMLConfigResponse"/></returns>
        public DescribeUserSAMLConfigResponse DescribeUserSAMLConfigSync(DescribeUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserSAMLConfigResponse>(req, "DescribeUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DetachGroupPolicy) is used to unassociate a policy and a user group.
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public Task<DetachGroupPolicyResponse> DetachGroupPolicy(DetachGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachGroupPolicyResponse>(req, "DetachGroupPolicy");
        }

        /// <summary>
        /// This API (DetachGroupPolicy) is used to unassociate a policy and a user group.
        /// </summary>
        /// <param name="req"><see cref="DetachGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachGroupPolicyResponse"/></returns>
        public DetachGroupPolicyResponse DetachGroupPolicySync(DetachGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachGroupPolicyResponse>(req, "DetachGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DetachRolePolicy) is used to unassociate a policy and a role.
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public Task<DetachRolePolicyResponse> DetachRolePolicy(DetachRolePolicyRequest req)
        {
            return InternalRequestAsync<DetachRolePolicyResponse>(req, "DetachRolePolicy");
        }

        /// <summary>
        /// This API (DetachRolePolicy) is used to unassociate a policy and a role.
        /// </summary>
        /// <param name="req"><see cref="DetachRolePolicyRequest"/></param>
        /// <returns><see cref="DetachRolePolicyResponse"/></returns>
        public DetachRolePolicyResponse DetachRolePolicySync(DetachRolePolicyRequest req)
        {
            return InternalRequestAsync<DetachRolePolicyResponse>(req, "DetachRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DetachUserPolicy) is used to unassociate a policy and a user.
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy");
        }

        /// <summary>
        /// This API (DetachUserPolicy) is used to unassociate a policy and a user.
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable user SSO.
        /// </summary>
        /// <param name="req"><see cref="DisableUserSSORequest"/></param>
        /// <returns><see cref="DisableUserSSOResponse"/></returns>
        public Task<DisableUserSSOResponse> DisableUserSSO(DisableUserSSORequest req)
        {
            return InternalRequestAsync<DisableUserSSOResponse>(req, "DisableUserSSO");
        }

        /// <summary>
        /// This API is used to disable user SSO.
        /// </summary>
        /// <param name="req"><see cref="DisableUserSSORequest"/></param>
        /// <returns><see cref="DisableUserSSOResponse"/></returns>
        public DisableUserSSOResponse DisableUserSSOSync(DisableUserSSORequest req)
        {
            return InternalRequestAsync<DisableUserSSOResponse>(req, "DisableUserSSO")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query account summary. 
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public Task<GetAccountSummaryResponse> GetAccountSummary(GetAccountSummaryRequest req)
        {
            return InternalRequestAsync<GetAccountSummaryResponse>(req, "GetAccountSummary");
        }

        /// <summary>
        /// This API is used to query account summary. 
        /// </summary>
        /// <param name="req"><see cref="GetAccountSummaryRequest"/></param>
        /// <returns><see cref="GetAccountSummaryResponse"/></returns>
        public GetAccountSummaryResponse GetAccountSummarySync(GetAccountSummaryRequest req)
        {
            return InternalRequestAsync<GetAccountSummaryResponse>(req, "GetAccountSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get information associated with a custom multi-factor Token
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public Task<GetCustomMFATokenInfoResponse> GetCustomMFATokenInfo(GetCustomMFATokenInfoRequest req)
        {
            return InternalRequestAsync<GetCustomMFATokenInfoResponse>(req, "GetCustomMFATokenInfo");
        }

        /// <summary>
        /// This API is used to get information associated with a custom multi-factor Token
        /// </summary>
        /// <param name="req"><see cref="GetCustomMFATokenInfoRequest"/></param>
        /// <returns><see cref="GetCustomMFATokenInfoResponse"/></returns>
        public GetCustomMFATokenInfoResponse GetCustomMFATokenInfoSync(GetCustomMFATokenInfoRequest req)
        {
            return InternalRequestAsync<GetCustomMFATokenInfoResponse>(req, "GetCustomMFATokenInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user group details.
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public Task<GetGroupResponse> GetGroup(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup");
        }

        /// <summary>
        /// This API is used to query user group details.
        /// </summary>
        /// <param name="req"><see cref="GetGroupRequest"/></param>
        /// <returns><see cref="GetGroupResponse"/></returns>
        public GetGroupResponse GetGroupSync(GetGroupRequest req)
        {
            return InternalRequestAsync<GetGroupResponse>(req, "GetGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (GetPolicy) is used to query and view policy details.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public Task<GetPolicyResponse> GetPolicy(GetPolicyRequest req)
        {
            return InternalRequestAsync<GetPolicyResponse>(req, "GetPolicy");
        }

        /// <summary>
        /// This API (GetPolicy) is used to query and view policy details.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyRequest"/></param>
        /// <returns><see cref="GetPolicyResponse"/></returns>
        public GetPolicyResponse GetPolicySync(GetPolicyRequest req)
        {
            return InternalRequestAsync<GetPolicyResponse>(req, "GetPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query policy version details.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public Task<GetPolicyVersionResponse> GetPolicyVersion(GetPolicyVersionRequest req)
        {
            return InternalRequestAsync<GetPolicyVersionResponse>(req, "GetPolicyVersion");
        }

        /// <summary>
        /// This API is used to query policy version details.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyVersionRequest"/></param>
        /// <returns><see cref="GetPolicyVersionResponse"/></returns>
        public GetPolicyVersionResponse GetPolicyVersionSync(GetPolicyVersionRequest req)
        {
            return InternalRequestAsync<GetPolicyVersionResponse>(req, "GetPolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (GetRole) is used to get the details of a specified role.
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public Task<GetRoleResponse> GetRole(GetRoleRequest req)
        {
            return InternalRequestAsync<GetRoleResponse>(req, "GetRole");
        }

        /// <summary>
        /// This API (GetRole) is used to get the details of a specified role.
        /// </summary>
        /// <param name="req"><see cref="GetRoleRequest"/></param>
        /// <returns><see cref="GetRoleResponse"/></returns>
        public GetRoleResponse GetRoleSync(GetRoleRequest req)
        {
            return InternalRequestAsync<GetRoleResponse>(req, "GetRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query SAML identity provider details.
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public Task<GetSAMLProviderResponse> GetSAMLProvider(GetSAMLProviderRequest req)
        {
            return InternalRequestAsync<GetSAMLProviderResponse>(req, "GetSAMLProvider");
        }

        /// <summary>
        /// This API is used to query SAML identity provider details.
        /// </summary>
        /// <param name="req"><see cref="GetSAMLProviderRequest"/></param>
        /// <returns><see cref="GetSAMLProviderResponse"/></returns>
        public GetSAMLProviderResponse GetSAMLProviderSync(GetSAMLProviderRequest req)
        {
            return InternalRequestAsync<GetSAMLProviderResponse>(req, "GetSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a key’s recent usage details.
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public Task<GetSecurityLastUsedResponse> GetSecurityLastUsed(GetSecurityLastUsedRequest req)
        {
            return InternalRequestAsync<GetSecurityLastUsedResponse>(req, "GetSecurityLastUsed");
        }

        /// <summary>
        /// This API is used to get a key’s recent usage details.
        /// </summary>
        /// <param name="req"><see cref="GetSecurityLastUsedRequest"/></param>
        /// <returns><see cref="GetSecurityLastUsedResponse"/></returns>
        public GetSecurityLastUsedResponse GetSecurityLastUsedSync(GetSecurityLastUsedRequest req)
        {
            return InternalRequestAsync<GetSecurityLastUsedResponse>(req, "GetSecurityLastUsed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of the service-linked role deletion based on the `TaskId`
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest req)
        {
            return InternalRequestAsync<GetServiceLinkedRoleDeletionStatusResponse>(req, "GetServiceLinkedRoleDeletionStatus");
        }

        /// <summary>
        /// This API is used to get the status of the service-linked role deletion based on the `TaskId`
        /// </summary>
        /// <param name="req"><see cref="GetServiceLinkedRoleDeletionStatusRequest"/></param>
        /// <returns><see cref="GetServiceLinkedRoleDeletionStatusResponse"/></returns>
        public GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatusSync(GetServiceLinkedRoleDeletionStatusRequest req)
        {
            return InternalRequestAsync<GetServiceLinkedRoleDeletionStatusResponse>(req, "GetServiceLinkedRoleDeletionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sub-users.
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public Task<GetUserResponse> GetUser(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser");
        }

        /// <summary>
        /// This API is used to query sub-users.
        /// </summary>
        /// <param name="req"><see cref="GetUserRequest"/></param>
        /// <returns><see cref="GetUserResponse"/></returns>
        public GetUserResponse GetUserSync(GetUserRequest req)
        {
            return InternalRequestAsync<GetUserResponse>(req, "GetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the user AppId.
        /// </summary>
        /// <param name="req"><see cref="GetUserAppIdRequest"/></param>
        /// <returns><see cref="GetUserAppIdResponse"/></returns>
        public Task<GetUserAppIdResponse> GetUserAppId(GetUserAppIdRequest req)
        {
            return InternalRequestAsync<GetUserAppIdResponse>(req, "GetUserAppId");
        }

        /// <summary>
        /// This API is used to get the user AppId.
        /// </summary>
        /// <param name="req"><see cref="GetUserAppIdRequest"/></param>
        /// <returns><see cref="GetUserAppIdResponse"/></returns>
        public GetUserAppIdResponse GetUserAppIdSync(GetUserAppIdRequest req)
        {
            return InternalRequestAsync<GetUserAppIdResponse>(req, "GetUserAppId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list the access keys associated with a specified CAM user.
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public Task<ListAccessKeysResponse> ListAccessKeys(ListAccessKeysRequest req)
        {
            return InternalRequestAsync<ListAccessKeysResponse>(req, "ListAccessKeys");
        }

        /// <summary>
        /// This API is used to list the access keys associated with a specified CAM user.
        /// </summary>
        /// <param name="req"><see cref="ListAccessKeysRequest"/></param>
        /// <returns><see cref="ListAccessKeysResponse"/></returns>
        public ListAccessKeysResponse ListAccessKeysSync(ListAccessKeysRequest req)
        {
            return InternalRequestAsync<ListAccessKeysResponse>(req, "ListAccessKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ListAttachedGroupPolicies) is used to query the list of policies associated with a user group.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedGroupPoliciesResponse>(req, "ListAttachedGroupPolicies");
        }

        /// <summary>
        /// This API (ListAttachedGroupPolicies) is used to query the list of policies associated with a user group.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedGroupPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedGroupPoliciesResponse"/></returns>
        public ListAttachedGroupPoliciesResponse ListAttachedGroupPoliciesSync(ListAttachedGroupPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedGroupPoliciesResponse>(req, "ListAttachedGroupPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ListAttachedRolePolicies) is used to obtain the list of the policies associated with a role.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public Task<ListAttachedRolePoliciesResponse> ListAttachedRolePolicies(ListAttachedRolePoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedRolePoliciesResponse>(req, "ListAttachedRolePolicies");
        }

        /// <summary>
        /// This API (ListAttachedRolePolicies) is used to obtain the list of the policies associated with a role.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedRolePoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedRolePoliciesResponse"/></returns>
        public ListAttachedRolePoliciesResponse ListAttachedRolePoliciesSync(ListAttachedRolePoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedRolePoliciesResponse>(req, "ListAttachedRolePolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list policies associated with the user (including those inherited from the user group).
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserAllPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserAllPoliciesResponse"/></returns>
        public Task<ListAttachedUserAllPoliciesResponse> ListAttachedUserAllPolicies(ListAttachedUserAllPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserAllPoliciesResponse>(req, "ListAttachedUserAllPolicies");
        }

        /// <summary>
        /// This API is used to list policies associated with the user (including those inherited from the user group).
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserAllPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserAllPoliciesResponse"/></returns>
        public ListAttachedUserAllPoliciesResponse ListAttachedUserAllPoliciesSync(ListAttachedUserAllPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserAllPoliciesResponse>(req, "ListAttachedUserAllPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ListAttachedUserPolicies) is used to query the list of policies associated with a sub-account.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public Task<ListAttachedUserPoliciesResponse> ListAttachedUserPolicies(ListAttachedUserPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserPoliciesResponse>(req, "ListAttachedUserPolicies");
        }

        /// <summary>
        /// This API (ListAttachedUserPolicies) is used to query the list of policies associated with a sub-account.
        /// </summary>
        /// <param name="req"><see cref="ListAttachedUserPoliciesRequest"/></param>
        /// <returns><see cref="ListAttachedUserPoliciesResponse"/></returns>
        public ListAttachedUserPoliciesResponse ListAttachedUserPoliciesSync(ListAttachedUserPoliciesRequest req)
        {
            return InternalRequestAsync<ListAttachedUserPoliciesResponse>(req, "ListAttachedUserPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the collaborator list.
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public Task<ListCollaboratorsResponse> ListCollaborators(ListCollaboratorsRequest req)
        {
            return InternalRequestAsync<ListCollaboratorsResponse>(req, "ListCollaborators");
        }

        /// <summary>
        /// This API is used to get the collaborator list.
        /// </summary>
        /// <param name="req"><see cref="ListCollaboratorsRequest"/></param>
        /// <returns><see cref="ListCollaboratorsResponse"/></returns>
        public ListCollaboratorsResponse ListCollaboratorsSync(ListCollaboratorsRequest req)
        {
            return InternalRequestAsync<ListCollaboratorsResponse>(req, "ListCollaborators")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ListEntitiesForPolicy) is used to query the list of entities associated with a policy.
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicy(ListEntitiesForPolicyRequest req)
        {
            return InternalRequestAsync<ListEntitiesForPolicyResponse>(req, "ListEntitiesForPolicy");
        }

        /// <summary>
        /// This API (ListEntitiesForPolicy) is used to query the list of entities associated with a policy.
        /// </summary>
        /// <param name="req"><see cref="ListEntitiesForPolicyRequest"/></param>
        /// <returns><see cref="ListEntitiesForPolicyResponse"/></returns>
        public ListEntitiesForPolicyResponse ListEntitiesForPolicySync(ListEntitiesForPolicyRequest req)
        {
            return InternalRequestAsync<ListEntitiesForPolicyResponse>(req, "ListEntitiesForPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of user groups.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public Task<ListGroupsResponse> ListGroups(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups");
        }

        /// <summary>
        /// This API is used to query the list of user groups.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsRequest"/></param>
        /// <returns><see cref="ListGroupsResponse"/></returns>
        public ListGroupsResponse ListGroupsSync(ListGroupsRequest req)
        {
            return InternalRequestAsync<ListGroupsResponse>(req, "ListGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list user groups associated with a user.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public Task<ListGroupsForUserResponse> ListGroupsForUser(ListGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListGroupsForUserResponse>(req, "ListGroupsForUser");
        }

        /// <summary>
        /// This API is used to list user groups associated with a user.
        /// </summary>
        /// <param name="req"><see cref="ListGroupsForUserRequest"/></param>
        /// <returns><see cref="ListGroupsForUserResponse"/></returns>
        public ListGroupsForUserResponse ListGroupsForUserSync(ListGroupsForUserRequest req)
        {
            return InternalRequestAsync<ListGroupsForUserResponse>(req, "ListGroupsForUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the policy list.
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public Task<ListPoliciesResponse> ListPolicies(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies");
        }

        /// <summary>
        /// This API is used to query the policy list.
        /// </summary>
        /// <param name="req"><see cref="ListPoliciesRequest"/></param>
        /// <returns><see cref="ListPoliciesResponse"/></returns>
        public ListPoliciesResponse ListPoliciesSync(ListPoliciesRequest req)
        {
            return InternalRequestAsync<ListPoliciesResponse>(req, "ListPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of policy versions.
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public Task<ListPolicyVersionsResponse> ListPolicyVersions(ListPolicyVersionsRequest req)
        {
            return InternalRequestAsync<ListPolicyVersionsResponse>(req, "ListPolicyVersions");
        }

        /// <summary>
        /// This API is used to get the list of policy versions.
        /// </summary>
        /// <param name="req"><see cref="ListPolicyVersionsRequest"/></param>
        /// <returns><see cref="ListPolicyVersionsResponse"/></returns>
        public ListPolicyVersionsResponse ListPolicyVersionsSync(ListPolicyVersionsRequest req)
        {
            return InternalRequestAsync<ListPolicyVersionsResponse>(req, "ListPolicyVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of SAML identity providers.
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public Task<ListSAMLProvidersResponse> ListSAMLProviders(ListSAMLProvidersRequest req)
        {
            return InternalRequestAsync<ListSAMLProvidersResponse>(req, "ListSAMLProviders");
        }

        /// <summary>
        /// This API is used to query the list of SAML identity providers.
        /// </summary>
        /// <param name="req"><see cref="ListSAMLProvidersRequest"/></param>
        /// <returns><see cref="ListSAMLProvidersResponse"/></returns>
        public ListSAMLProvidersResponse ListSAMLProvidersSync(ListSAMLProvidersRequest req)
        {
            return InternalRequestAsync<ListSAMLProvidersResponse>(req, "ListSAMLProviders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull sub-users.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers");
        }

        /// <summary>
        /// This API is used to pull sub-users.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of users associated with a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public Task<ListUsersForGroupResponse> ListUsersForGroup(ListUsersForGroupRequest req)
        {
            return InternalRequestAsync<ListUsersForGroupResponse>(req, "ListUsersForGroup");
        }

        /// <summary>
        /// This API is used to query the list of users associated with a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersForGroupRequest"/></param>
        /// <returns><see cref="ListUsersForGroupResponse"/></returns>
        public ListUsersForGroupResponse ListUsersForGroupSync(ListUsersForGroupRequest req)
        {
            return InternalRequestAsync<ListUsersForGroupResponse>(req, "ListUsersForGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a role permission boundary.
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public Task<PutRolePermissionsBoundaryResponse> PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutRolePermissionsBoundaryResponse>(req, "PutRolePermissionsBoundary");
        }

        /// <summary>
        /// This API is used to set a role permission boundary.
        /// </summary>
        /// <param name="req"><see cref="PutRolePermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutRolePermissionsBoundaryResponse"/></returns>
        public PutRolePermissionsBoundaryResponse PutRolePermissionsBoundarySync(PutRolePermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutRolePermissionsBoundaryResponse>(req, "PutRolePermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set a user permission boundary.
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public Task<PutUserPermissionsBoundaryResponse> PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutUserPermissionsBoundaryResponse>(req, "PutUserPermissionsBoundary");
        }

        /// <summary>
        /// This API is used to set a user permission boundary.
        /// </summary>
        /// <param name="req"><see cref="PutUserPermissionsBoundaryRequest"/></param>
        /// <returns><see cref="PutUserPermissionsBoundaryResponse"/></returns>
        public PutUserPermissionsBoundaryResponse PutUserPermissionsBoundarySync(PutUserPermissionsBoundaryRequest req)
        {
            return InternalRequestAsync<PutUserPermissionsBoundaryResponse>(req, "PutUserPermissionsBoundary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete users from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public Task<RemoveUserFromGroupResponse> RemoveUserFromGroup(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup");
        }

        /// <summary>
        /// This API is used to delete users from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromGroupResponse"/></returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroupSync(RemoveUserFromGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromGroupResponse>(req, "RemoveUserFromGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the operative policy version.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest req)
        {
            return InternalRequestAsync<SetDefaultPolicyVersionResponse>(req, "SetDefaultPolicyVersion");
        }

        /// <summary>
        /// This API is used to set the operative policy version.
        /// </summary>
        /// <param name="req"><see cref="SetDefaultPolicyVersionRequest"/></param>
        /// <returns><see cref="SetDefaultPolicyVersionResponse"/></returns>
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersionSync(SetDefaultPolicyVersionRequest req)
        {
            return InternalRequestAsync<SetDefaultPolicyVersionResponse>(req, "SetDefaultPolicyVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set account verification for login and sensitive operations for sub-users.
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public Task<SetMfaFlagResponse> SetMfaFlag(SetMfaFlagRequest req)
        {
            return InternalRequestAsync<SetMfaFlagResponse>(req, "SetMfaFlag");
        }

        /// <summary>
        /// This API is used to set account verification for login and sensitive operations for sub-users.
        /// </summary>
        /// <param name="req"><see cref="SetMfaFlagRequest"/></param>
        /// <returns><see cref="SetMfaFlagResponse"/></returns>
        public SetMfaFlagResponse SetMfaFlagSync(SetMfaFlagRequest req)
        {
            return InternalRequestAsync<SetMfaFlagResponse>(req, "SetMfaFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind tags to a role.
        /// </summary>
        /// <param name="req"><see cref="TagRoleRequest"/></param>
        /// <returns><see cref="TagRoleResponse"/></returns>
        public Task<TagRoleResponse> TagRole(TagRoleRequest req)
        {
            return InternalRequestAsync<TagRoleResponse>(req, "TagRole");
        }

        /// <summary>
        /// This API is used to bind tags to a role.
        /// </summary>
        /// <param name="req"><see cref="TagRoleRequest"/></param>
        /// <returns><see cref="TagRoleResponse"/></returns>
        public TagRoleResponse TagRoleSync(TagRoleRequest req)
        {
            return InternalRequestAsync<TagRoleResponse>(req, "TagRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind tags from a role.
        /// </summary>
        /// <param name="req"><see cref="UntagRoleRequest"/></param>
        /// <returns><see cref="UntagRoleResponse"/></returns>
        public Task<UntagRoleResponse> UntagRole(UntagRoleRequest req)
        {
            return InternalRequestAsync<UntagRoleResponse>(req, "UntagRole");
        }

        /// <summary>
        /// This API is used to unbind tags from a role.
        /// </summary>
        /// <param name="req"><see cref="UntagRoleRequest"/></param>
        /// <returns><see cref="UntagRoleResponse"/></returns>
        public UntagRoleResponse UntagRoleSync(UntagRoleRequest req)
        {
            return InternalRequestAsync<UntagRoleResponse>(req, "UntagRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an access key for a CAM user.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyResponse"/></returns>
        public Task<UpdateAccessKeyResponse> UpdateAccessKey(UpdateAccessKeyRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyResponse>(req, "UpdateAccessKey");
        }

        /// <summary>
        /// This API is used to update an access key for a CAM user.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyResponse"/></returns>
        public UpdateAccessKeyResponse UpdateAccessKeySync(UpdateAccessKeyRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyResponse>(req, "UpdateAccessKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UpdateAssumeRolePolicy) is used to modify the trust policy of a role.
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest req)
        {
            return InternalRequestAsync<UpdateAssumeRolePolicyResponse>(req, "UpdateAssumeRolePolicy");
        }

        /// <summary>
        /// This API (UpdateAssumeRolePolicy) is used to modify the trust policy of a role.
        /// </summary>
        /// <param name="req"><see cref="UpdateAssumeRolePolicyRequest"/></param>
        /// <returns><see cref="UpdateAssumeRolePolicyResponse"/></returns>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicySync(UpdateAssumeRolePolicyRequest req)
        {
            return InternalRequestAsync<UpdateAssumeRolePolicyResponse>(req, "UpdateAssumeRolePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a user group.
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup");
        }

        /// <summary>
        /// This API is used to update a user group.
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateOIDCConfigResponse"/></returns>
        public Task<UpdateOIDCConfigResponse> UpdateOIDCConfig(UpdateOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateOIDCConfigResponse>(req, "UpdateOIDCConfig");
        }

        /// <summary>
        /// This API is used to modify role OIDC configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateOIDCConfigResponse"/></returns>
        public UpdateOIDCConfigResponse UpdateOIDCConfigSync(UpdateOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateOIDCConfigResponse>(req, "UpdateOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a policy.
        /// This API will update the default version of an existing policy instead of creating a new one. If no policy exists, a default version will be created.
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public Task<UpdatePolicyResponse> UpdatePolicy(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy");
        }

        /// <summary>
        /// This API is used to update a policy.
        /// This API will update the default version of an existing policy instead of creating a new one. If no policy exists, a default version will be created.
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public UpdatePolicyResponse UpdatePolicySync(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a role's login permissions.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public Task<UpdateRoleConsoleLoginResponse> UpdateRoleConsoleLogin(UpdateRoleConsoleLoginRequest req)
        {
            return InternalRequestAsync<UpdateRoleConsoleLoginResponse>(req, "UpdateRoleConsoleLogin");
        }

        /// <summary>
        /// This API is used to modify a role's login permissions.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleConsoleLoginRequest"/></param>
        /// <returns><see cref="UpdateRoleConsoleLoginResponse"/></returns>
        public UpdateRoleConsoleLoginResponse UpdateRoleConsoleLoginSync(UpdateRoleConsoleLoginRequest req)
        {
            return InternalRequestAsync<UpdateRoleConsoleLoginResponse>(req, "UpdateRoleConsoleLogin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UpdateRoleDescription) is used to modify the description of a role.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public Task<UpdateRoleDescriptionResponse> UpdateRoleDescription(UpdateRoleDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateRoleDescriptionResponse>(req, "UpdateRoleDescription");
        }

        /// <summary>
        /// This API (UpdateRoleDescription) is used to modify the description of a role.
        /// </summary>
        /// <param name="req"><see cref="UpdateRoleDescriptionRequest"/></param>
        /// <returns><see cref="UpdateRoleDescriptionResponse"/></returns>
        public UpdateRoleDescriptionResponse UpdateRoleDescriptionSync(UpdateRoleDescriptionRequest req)
        {
            return InternalRequestAsync<UpdateRoleDescriptionResponse>(req, "UpdateRoleDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update SAML identity provider information.
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public Task<UpdateSAMLProviderResponse> UpdateSAMLProvider(UpdateSAMLProviderRequest req)
        {
            return InternalRequestAsync<UpdateSAMLProviderResponse>(req, "UpdateSAMLProvider");
        }

        /// <summary>
        /// This API is used to update SAML identity provider information.
        /// </summary>
        /// <param name="req"><see cref="UpdateSAMLProviderRequest"/></param>
        /// <returns><see cref="UpdateSAMLProviderResponse"/></returns>
        public UpdateSAMLProviderResponse UpdateSAMLProviderSync(UpdateSAMLProviderRequest req)
        {
            return InternalRequestAsync<UpdateSAMLProviderResponse>(req, "UpdateSAMLProvider")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a sub-user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// This API is used to update a sub-user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the user OIDC configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateUserOIDCConfigResponse"/></returns>
        public Task<UpdateUserOIDCConfigResponse> UpdateUserOIDCConfig(UpdateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserOIDCConfigResponse>(req, "UpdateUserOIDCConfig");
        }

        /// <summary>
        /// This API is used to modify the user OIDC configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserOIDCConfigRequest"/></param>
        /// <returns><see cref="UpdateUserOIDCConfigResponse"/></returns>
        public UpdateUserOIDCConfigResponse UpdateUserOIDCConfigSync(UpdateUserOIDCConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserOIDCConfigResponse>(req, "UpdateUserOIDCConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public Task<UpdateUserSAMLConfigResponse> UpdateUserSAMLConfig(UpdateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserSAMLConfigResponse>(req, "UpdateUserSAMLConfig");
        }

        /// <summary>
        /// This API is used to modify user SAML configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserSAMLConfigRequest"/></param>
        /// <returns><see cref="UpdateUserSAMLConfigResponse"/></returns>
        public UpdateUserSAMLConfigResponse UpdateUserSAMLConfigSync(UpdateUserSAMLConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserSAMLConfigResponse>(req, "UpdateUserSAMLConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
