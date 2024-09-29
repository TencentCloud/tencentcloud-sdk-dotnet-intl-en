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

namespace TencentCloud.Eiam.V20210420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eiam.V20210420.Models;

   public class EiamClient : AbstractClient{

       private const string endpoint = "eiam.tencentcloudapi.com";
       private const string version = "2021-04-20";
       private const string sdkVersion = "SDK_NET_3.0.990";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add an account to an account group.
        /// </summary>
        /// <param name="req"><see cref="AddAccountToAccountGroupRequest"/></param>
        /// <returns><see cref="AddAccountToAccountGroupResponse"/></returns>
        public Task<AddAccountToAccountGroupResponse> AddAccountToAccountGroup(AddAccountToAccountGroupRequest req)
        {
            return InternalRequestAsync<AddAccountToAccountGroupResponse>(req, "AddAccountToAccountGroup");
        }

        /// <summary>
        /// This API is used to add an account to an account group.
        /// </summary>
        /// <param name="req"><see cref="AddAccountToAccountGroupRequest"/></param>
        /// <returns><see cref="AddAccountToAccountGroupResponse"/></returns>
        public AddAccountToAccountGroupResponse AddAccountToAccountGroupSync(AddAccountToAccountGroupRequest req)
        {
            return InternalRequestAsync<AddAccountToAccountGroupResponse>(req, "AddAccountToAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a user to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public Task<AddUserToUserGroupResponse> AddUserToUserGroup(AddUserToUserGroupRequest req)
        {
            return InternalRequestAsync<AddUserToUserGroupResponse>(req, "AddUserToUserGroup");
        }

        /// <summary>
        /// This API is used to add a user to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public AddUserToUserGroupResponse AddUserToUserGroupSync(AddUserToUserGroupRequest req)
        {
            return InternalRequestAsync<AddUserToUserGroupResponse>(req, "AddUserToUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an account group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountGroupRequest"/></param>
        /// <returns><see cref="CreateAccountGroupResponse"/></returns>
        public Task<CreateAccountGroupResponse> CreateAccountGroup(CreateAccountGroupRequest req)
        {
            return InternalRequestAsync<CreateAccountGroupResponse>(req, "CreateAccountGroup");
        }

        /// <summary>
        /// This API is used to create an account group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountGroupRequest"/></param>
        /// <returns><see cref="CreateAccountGroupResponse"/></returns>
        public CreateAccountGroupResponse CreateAccountGroupSync(CreateAccountGroupRequest req)
        {
            return InternalRequestAsync<CreateAccountGroupResponse>(req, "CreateAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application account.
        /// </summary>
        /// <param name="req"><see cref="CreateAppAccountRequest"/></param>
        /// <returns><see cref="CreateAppAccountResponse"/></returns>
        public Task<CreateAppAccountResponse> CreateAppAccount(CreateAppAccountRequest req)
        {
            return InternalRequestAsync<CreateAppAccountResponse>(req, "CreateAppAccount");
        }

        /// <summary>
        /// This API is used to create an application account.
        /// </summary>
        /// <param name="req"><see cref="CreateAppAccountRequest"/></param>
        /// <returns><see cref="CreateAppAccountResponse"/></returns>
        public CreateAppAccountResponse CreateAppAccountSync(CreateAppAccountRequest req)
        {
            return InternalRequestAsync<CreateAppAccountResponse>(req, "CreateAppAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public Task<CreateOrgNodeResponse> CreateOrgNode(CreateOrgNodeRequest req)
        {
            return InternalRequestAsync<CreateOrgNodeResponse>(req, "CreateOrgNode");
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public CreateOrgNodeResponse CreateOrgNodeSync(CreateOrgNodeRequest req)
        {
            return InternalRequestAsync<CreateOrgNodeResponse>(req, "CreateOrgNode")
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
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup");
        }

        /// <summary>
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an account group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountGroupRequest"/></param>
        /// <returns><see cref="DeleteAccountGroupResponse"/></returns>
        public Task<DeleteAccountGroupResponse> DeleteAccountGroup(DeleteAccountGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccountGroupResponse>(req, "DeleteAccountGroup");
        }

        /// <summary>
        /// This API is used to delete an account group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountGroupRequest"/></param>
        /// <returns><see cref="DeleteAccountGroupResponse"/></returns>
        public DeleteAccountGroupResponse DeleteAccountGroupSync(DeleteAccountGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccountGroupResponse>(req, "DeleteAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an application account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppAccountRequest"/></param>
        /// <returns><see cref="DeleteAppAccountResponse"/></returns>
        public Task<DeleteAppAccountResponse> DeleteAppAccount(DeleteAppAccountRequest req)
        {
            return InternalRequestAsync<DeleteAppAccountResponse>(req, "DeleteAppAccount");
        }

        /// <summary>
        /// This API is used to delete an application account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppAccountRequest"/></param>
        /// <returns><see cref="DeleteAppAccountResponse"/></returns>
        public DeleteAppAccountResponse DeleteAppAccountSync(DeleteAppAccountRequest req)
        {
            return InternalRequestAsync<DeleteAppAccountResponse>(req, "DeleteAppAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an organization node.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public Task<DeleteOrgNodeResponse> DeleteOrgNode(DeleteOrgNodeRequest req)
        {
            return InternalRequestAsync<DeleteOrgNodeResponse>(req, "DeleteOrgNode");
        }

        /// <summary>
        /// This API is used to delete an organization node.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public DeleteOrgNodeResponse DeleteOrgNodeSync(DeleteOrgNodeRequest req)
        {
            return InternalRequestAsync<DeleteOrgNodeResponse>(req, "DeleteOrgNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public Task<DeleteUserGroupResponse> DeleteUserGroup(DeleteUserGroupRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupResponse>(req, "DeleteUserGroup");
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public DeleteUserGroupResponse DeleteUserGroupSync(DeleteUserGroupRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupResponse>(req, "DeleteUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete the users under the current node. If an error occurs when a user is deleted, the deletion of other selected users will not be affected, and the username/ID of the user who fails to be deleted will be prompted.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// This API is used to batch delete the users under the current node. If an error occurs when a user is deleted, the deletion of other selected users will not be affected, and the username/ID of the user who fails to be deleted will be prompted.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupResponse"/></returns>
        public Task<DescribeAccountGroupResponse> DescribeAccountGroup(DescribeAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupResponse>(req, "DescribeAccountGroup");
        }

        /// <summary>
        /// This API is used to query the list of account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupResponse"/></returns>
        public DescribeAccountGroupResponse DescribeAccountGroupSync(DescribeAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupResponse>(req, "DescribeAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of application accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppAccountRequest"/></param>
        /// <returns><see cref="DescribeAppAccountResponse"/></returns>
        public Task<DescribeAppAccountResponse> DescribeAppAccount(DescribeAppAccountRequest req)
        {
            return InternalRequestAsync<DescribeAppAccountResponse>(req, "DescribeAppAccount");
        }

        /// <summary>
        /// This API is used to query the list of application accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppAccountRequest"/></param>
        /// <returns><see cref="DescribeAppAccountResponse"/></returns>
        public DescribeAppAccountResponse DescribeAppAccountSync(DescribeAppAccountRequest req)
        {
            return InternalRequestAsync<DescribeAppAccountResponse>(req, "DescribeAppAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication");
        }

        /// <summary>
        /// This API is used to get the information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
            return InternalRequestAsync<DescribeApplicationResponse>(req, "DescribeApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to read the information of an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public Task<DescribeOrgNodeResponse> DescribeOrgNode(DescribeOrgNodeRequest req)
        {
            return InternalRequestAsync<DescribeOrgNodeResponse>(req, "DescribeOrgNode");
        }

        /// <summary>
        /// This API is used to read the information of an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public DescribeOrgNodeResponse DescribeOrgNodeSync(DescribeOrgNodeRequest req)
        {
            return InternalRequestAsync<DescribeOrgNodeResponse>(req, "DescribeOrgNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a JWT public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public Task<DescribePublicKeyResponse> DescribePublicKey(DescribePublicKeyRequest req)
        {
            return InternalRequestAsync<DescribePublicKeyResponse>(req, "DescribePublicKey");
        }

        /// <summary>
        /// This API is used to get the information of a JWT public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public DescribePublicKeyResponse DescribePublicKeySync(DescribePublicKeyRequest req)
        {
            return InternalRequestAsync<DescribePublicKeyResponse>(req, "DescribePublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public Task<DescribeUserGroupResponse> DescribeUserGroup(DescribeUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupResponse>(req, "DescribeUserGroup");
        }

        /// <summary>
        /// This API is used to get the information of a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public DescribeUserGroupResponse DescribeUserGroupSync(DescribeUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupResponse>(req, "DescribeUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// This API is used to search for a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of resource authorizations under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesAuthorizationResponse"/></returns>
        public Task<DescribeUserResourcesAuthorizationResponse> DescribeUserResourcesAuthorization(DescribeUserResourcesAuthorizationRequest req)
        {
            return InternalRequestAsync<DescribeUserResourcesAuthorizationResponse>(req, "DescribeUserResourcesAuthorization");
        }

        /// <summary>
        /// This API is used to query the list of resource authorizations under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesAuthorizationResponse"/></returns>
        public DescribeUserResourcesAuthorizationResponse DescribeUserResourcesAuthorizationSync(DescribeUserResourcesAuthorizationRequest req)
        {
            return InternalRequestAsync<DescribeUserResourcesAuthorizationResponse>(req, "DescribeUserResourcesAuthorization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the third-party account binding information by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserThirdPartyAccountInfoRequest"/></param>
        /// <returns><see cref="DescribeUserThirdPartyAccountInfoResponse"/></returns>
        public Task<DescribeUserThirdPartyAccountInfoResponse> DescribeUserThirdPartyAccountInfo(DescribeUserThirdPartyAccountInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserThirdPartyAccountInfoResponse>(req, "DescribeUserThirdPartyAccountInfo");
        }

        /// <summary>
        /// This API is used to get the third-party account binding information by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserThirdPartyAccountInfoRequest"/></param>
        /// <returns><see cref="DescribeUserThirdPartyAccountInfoResponse"/></returns>
        public DescribeUserThirdPartyAccountInfoResponse DescribeUserThirdPartyAccountInfoSync(DescribeUserThirdPartyAccountInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserThirdPartyAccountInfoResponse>(req, "DescribeUserThirdPartyAccountInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to get the list of accounts in an account group.
        /// </summary>
        /// <param name="req"><see cref="ListAccountInAccountGroupRequest"/></param>
        /// <returns><see cref="ListAccountInAccountGroupResponse"/></returns>
        public Task<ListAccountInAccountGroupResponse> ListAccountInAccountGroup(ListAccountInAccountGroupRequest req)
        {
            return InternalRequestAsync<ListAccountInAccountGroupResponse>(req, "ListAccountInAccountGroup");
        }

        /// <summary>
        ///  This API is used to get the list of accounts in an account group.
        /// </summary>
        /// <param name="req"><see cref="ListAccountInAccountGroupRequest"/></param>
        /// <returns><see cref="ListAccountInAccountGroupResponse"/></returns>
        public ListAccountInAccountGroupResponse ListAccountInAccountGroupSync(ListAccountInAccountGroupRequest req)
        {
            return InternalRequestAsync<ListAccountInAccountGroupResponse>(req, "ListAccountInAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of authorization relationships of an application (including search criteria-based match).
        /// </summary>
        /// <param name="req"><see cref="ListApplicationAuthorizationsRequest"/></param>
        /// <returns><see cref="ListApplicationAuthorizationsResponse"/></returns>
        public Task<ListApplicationAuthorizationsResponse> ListApplicationAuthorizations(ListApplicationAuthorizationsRequest req)
        {
            return InternalRequestAsync<ListApplicationAuthorizationsResponse>(req, "ListApplicationAuthorizations");
        }

        /// <summary>
        /// This API is used to get the list of authorization relationships of an application (including search criteria-based match).
        /// </summary>
        /// <param name="req"><see cref="ListApplicationAuthorizationsRequest"/></param>
        /// <returns><see cref="ListApplicationAuthorizationsResponse"/></returns>
        public ListApplicationAuthorizationsResponse ListApplicationAuthorizationsSync(ListApplicationAuthorizationsRequest req)
        {
            return InternalRequestAsync<ListApplicationAuthorizationsResponse>(req, "ListApplicationAuthorizations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of applications.
        /// </summary>
        /// <param name="req"><see cref="ListApplicationsRequest"/></param>
        /// <returns><see cref="ListApplicationsResponse"/></returns>
        public Task<ListApplicationsResponse> ListApplications(ListApplicationsRequest req)
        {
            return InternalRequestAsync<ListApplicationsResponse>(req, "ListApplications");
        }

        /// <summary>
        /// This API is used to get the list of applications.
        /// </summary>
        /// <param name="req"><see cref="ListApplicationsRequest"/></param>
        /// <returns><see cref="ListApplicationsResponse"/></returns>
        public ListApplicationsResponse ListApplicationsSync(ListApplicationsRequest req)
        {
            return InternalRequestAsync<ListApplicationsResponse>(req, "ListApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public Task<ListAuthorizedApplicationsToOrgNodeResponse> ListAuthorizedApplicationsToOrgNode(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToOrgNodeResponse>(req, "ListAuthorizedApplicationsToOrgNode");
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public ListAuthorizedApplicationsToOrgNodeResponse ListAuthorizedApplicationsToOrgNodeSync(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToOrgNodeResponse>(req, "ListAuthorizedApplicationsToOrgNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public Task<ListAuthorizedApplicationsToUserResponse> ListAuthorizedApplicationsToUser(ListAuthorizedApplicationsToUserRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToUserResponse>(req, "ListAuthorizedApplicationsToUser");
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public ListAuthorizedApplicationsToUserResponse ListAuthorizedApplicationsToUserSync(ListAuthorizedApplicationsToUserRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToUserResponse>(req, "ListAuthorizedApplicationsToUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user group ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public Task<ListAuthorizedApplicationsToUserGroupResponse> ListAuthorizedApplicationsToUserGroup(ListAuthorizedApplicationsToUserGroupRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToUserGroupResponse>(req, "ListAuthorizedApplicationsToUserGroup");
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user group ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public ListAuthorizedApplicationsToUserGroupResponse ListAuthorizedApplicationsToUserGroupSync(ListAuthorizedApplicationsToUserGroupRequest req)
        {
            return InternalRequestAsync<ListAuthorizedApplicationsToUserGroupResponse>(req, "ListAuthorizedApplicationsToUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of the user group list (including query conditions).
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public Task<ListUserGroupsResponse> ListUserGroups(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups");
        }

        /// <summary>
        /// This API is used to get the information of the user group list (including query conditions).
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public ListUserGroupsResponse ListUserGroupsSync(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of a user's user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public Task<ListUserGroupsOfUserResponse> ListUserGroupsOfUser(ListUserGroupsOfUserRequest req)
        {
            return InternalRequestAsync<ListUserGroupsOfUserResponse>(req, "ListUserGroupsOfUser");
        }

        /// <summary>
        /// This API is used to get the list of a user's user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public ListUserGroupsOfUserResponse ListUserGroupsOfUserSync(ListUserGroupsOfUserRequest req)
        {
            return InternalRequestAsync<ListUserGroupsOfUserResponse>(req, "ListUserGroupsOfUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers");
        }

        /// <summary>
        /// This API is used to get the information of the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
            return InternalRequestAsync<ListUsersResponse>(req, "ListUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to read the users under an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public Task<ListUsersInOrgNodeResponse> ListUsersInOrgNode(ListUsersInOrgNodeRequest req)
        {
            return InternalRequestAsync<ListUsersInOrgNodeResponse>(req, "ListUsersInOrgNode");
        }

        /// <summary>
        /// This API is used to read the users under an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public ListUsersInOrgNodeResponse ListUsersInOrgNodeSync(ListUsersInOrgNodeRequest req)
        {
            return InternalRequestAsync<ListUsersInOrgNodeResponse>(req, "ListUsersInOrgNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of the users in a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public Task<ListUsersInUserGroupResponse> ListUsersInUserGroup(ListUsersInUserGroupRequest req)
        {
            return InternalRequestAsync<ListUsersInUserGroupResponse>(req, "ListUsersInUserGroup");
        }

        /// <summary>
        /// This API is used to get the list of the users in a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public ListUsersInUserGroupResponse ListUsersInUserGroupSync(ListUsersInUserGroupRequest req)
        {
            return InternalRequestAsync<ListUsersInUserGroupResponse>(req, "ListUsersInUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an account group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountGroupRequest"/></param>
        /// <returns><see cref="ModifyAccountGroupResponse"/></returns>
        public Task<ModifyAccountGroupResponse> ModifyAccountGroup(ModifyAccountGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccountGroupResponse>(req, "ModifyAccountGroup");
        }

        /// <summary>
        /// This API is used to modify an account group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountGroupRequest"/></param>
        /// <returns><see cref="ModifyAccountGroupResponse"/></returns>
        public ModifyAccountGroupResponse ModifyAccountGroupSync(ModifyAccountGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccountGroupResponse>(req, "ModifyAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an application account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppAccountRequest"/></param>
        /// <returns><see cref="ModifyAppAccountResponse"/></returns>
        public Task<ModifyAppAccountResponse> ModifyAppAccount(ModifyAppAccountRequest req)
        {
            return InternalRequestAsync<ModifyAppAccountResponse>(req, "ModifyAppAccount");
        }

        /// <summary>
        /// This API is used to modify an application account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppAccountRequest"/></param>
        /// <returns><see cref="ModifyAppAccountResponse"/></returns>
        public ModifyAppAccountResponse ModifyAppAccountSync(ModifyAppAccountRequest req)
        {
            return InternalRequestAsync<ModifyAppAccountResponse>(req, "ModifyAppAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication");
        }

        /// <summary>
        /// This API is used to update the information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
            return InternalRequestAsync<ModifyApplicationResponse>(req, "ModifyApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information of a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public Task<ModifyUserInfoResponse> ModifyUserInfo(ModifyUserInfoRequest req)
        {
            return InternalRequestAsync<ModifyUserInfoResponse>(req, "ModifyUserInfo");
        }

        /// <summary>
        /// This API is used to modify the information of a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public ModifyUserInfoResponse ModifyUserInfoSync(ModifyUserInfoRequest req)
        {
            return InternalRequestAsync<ModifyUserInfoResponse>(req, "ModifyUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove an account from an account group.
        /// </summary>
        /// <param name="req"><see cref="RemoveAccountFromAccountGroupRequest"/></param>
        /// <returns><see cref="RemoveAccountFromAccountGroupResponse"/></returns>
        public Task<RemoveAccountFromAccountGroupResponse> RemoveAccountFromAccountGroup(RemoveAccountFromAccountGroupRequest req)
        {
            return InternalRequestAsync<RemoveAccountFromAccountGroupResponse>(req, "RemoveAccountFromAccountGroup");
        }

        /// <summary>
        /// This API is used to remove an account from an account group.
        /// </summary>
        /// <param name="req"><see cref="RemoveAccountFromAccountGroupRequest"/></param>
        /// <returns><see cref="RemoveAccountFromAccountGroupResponse"/></returns>
        public RemoveAccountFromAccountGroupResponse RemoveAccountFromAccountGroupSync(RemoveAccountFromAccountGroupRequest req)
        {
            return InternalRequestAsync<RemoveAccountFromAccountGroupResponse>(req, "RemoveAccountFromAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a user from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public Task<RemoveUserFromUserGroupResponse> RemoveUserFromUserGroup(RemoveUserFromUserGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromUserGroupResponse>(req, "RemoveUserFromUserGroup");
        }

        /// <summary>
        /// This API is used to remove a user from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public RemoveUserFromUserGroupResponse RemoveUserFromUserGroupSync(RemoveUserFromUserGroupRequest req)
        {
            return InternalRequestAsync<RemoveUserFromUserGroupResponse>(req, "RemoveUserFromUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public Task<UpdateOrgNodeResponse> UpdateOrgNode(UpdateOrgNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrgNodeResponse>(req, "UpdateOrgNode");
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public UpdateOrgNodeResponse UpdateOrgNodeSync(UpdateOrgNodeRequest req)
        {
            return InternalRequestAsync<UpdateOrgNodeResponse>(req, "UpdateOrgNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
