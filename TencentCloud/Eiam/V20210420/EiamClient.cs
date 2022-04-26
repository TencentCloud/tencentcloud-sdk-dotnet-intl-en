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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to add an account to an account group.
        /// </summary>
        /// <param name="req"><see cref="AddAccountToAccountGroupRequest"/></param>
        /// <returns><see cref="AddAccountToAccountGroupResponse"/></returns>
        public async Task<AddAccountToAccountGroupResponse> AddAccountToAccountGroup(AddAccountToAccountGroupRequest req)
        {
             JsonResponseModel<AddAccountToAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAccountToAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAccountToAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an account to an account group.
        /// </summary>
        /// <param name="req"><see cref="AddAccountToAccountGroupRequest"/></param>
        /// <returns><see cref="AddAccountToAccountGroupResponse"/></returns>
        public AddAccountToAccountGroupResponse AddAccountToAccountGroupSync(AddAccountToAccountGroupRequest req)
        {
             JsonResponseModel<AddAccountToAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAccountToAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAccountToAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a user to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public async Task<AddUserToUserGroupResponse> AddUserToUserGroup(AddUserToUserGroupRequest req)
        {
             JsonResponseModel<AddUserToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a user to a user group.
        /// </summary>
        /// <param name="req"><see cref="AddUserToUserGroupRequest"/></param>
        /// <returns><see cref="AddUserToUserGroupResponse"/></returns>
        public AddUserToUserGroupResponse AddUserToUserGroupSync(AddUserToUserGroupRequest req)
        {
             JsonResponseModel<AddUserToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an account group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountGroupRequest"/></param>
        /// <returns><see cref="CreateAccountGroupResponse"/></returns>
        public async Task<CreateAccountGroupResponse> CreateAccountGroup(CreateAccountGroupRequest req)
        {
             JsonResponseModel<CreateAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an account group.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountGroupRequest"/></param>
        /// <returns><see cref="CreateAccountGroupResponse"/></returns>
        public CreateAccountGroupResponse CreateAccountGroupSync(CreateAccountGroupRequest req)
        {
             JsonResponseModel<CreateAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application account.
        /// </summary>
        /// <param name="req"><see cref="CreateAppAccountRequest"/></param>
        /// <returns><see cref="CreateAppAccountResponse"/></returns>
        public async Task<CreateAppAccountResponse> CreateAppAccount(CreateAppAccountRequest req)
        {
             JsonResponseModel<CreateAppAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an application account.
        /// </summary>
        /// <param name="req"><see cref="CreateAppAccountRequest"/></param>
        /// <returns><see cref="CreateAppAccountResponse"/></returns>
        public CreateAppAccountResponse CreateAppAccountSync(CreateAppAccountRequest req)
        {
             JsonResponseModel<CreateAppAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public async Task<CreateOrgNodeResponse> CreateOrgNode(CreateOrgNodeRequest req)
        {
             JsonResponseModel<CreateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="CreateOrgNodeRequest"/></param>
        /// <returns><see cref="CreateOrgNodeResponse"/></returns>
        public CreateOrgNodeResponse CreateOrgNodeSync(CreateOrgNodeRequest req)
        {
             JsonResponseModel<CreateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a user.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public async Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a user group.
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an account group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountGroupRequest"/></param>
        /// <returns><see cref="DeleteAccountGroupResponse"/></returns>
        public async Task<DeleteAccountGroupResponse> DeleteAccountGroup(DeleteAccountGroupRequest req)
        {
             JsonResponseModel<DeleteAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an account group.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountGroupRequest"/></param>
        /// <returns><see cref="DeleteAccountGroupResponse"/></returns>
        public DeleteAccountGroupResponse DeleteAccountGroupSync(DeleteAccountGroupRequest req)
        {
             JsonResponseModel<DeleteAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppAccountRequest"/></param>
        /// <returns><see cref="DeleteAppAccountResponse"/></returns>
        public async Task<DeleteAppAccountResponse> DeleteAppAccount(DeleteAppAccountRequest req)
        {
             JsonResponseModel<DeleteAppAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an application account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppAccountRequest"/></param>
        /// <returns><see cref="DeleteAppAccountResponse"/></returns>
        public DeleteAppAccountResponse DeleteAppAccountSync(DeleteAppAccountRequest req)
        {
             JsonResponseModel<DeleteAppAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an organization node.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public async Task<DeleteOrgNodeResponse> DeleteOrgNode(DeleteOrgNodeRequest req)
        {
             JsonResponseModel<DeleteOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an organization node.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrgNodeRequest"/></param>
        /// <returns><see cref="DeleteOrgNodeResponse"/></returns>
        public DeleteOrgNodeResponse DeleteOrgNodeSync(DeleteOrgNodeRequest req)
        {
             JsonResponseModel<DeleteOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroup(DeleteUserGroupRequest req)
        {
             JsonResponseModel<DeleteUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a user group.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupRequest"/></param>
        /// <returns><see cref="DeleteUserGroupResponse"/></returns>
        public DeleteUserGroupResponse DeleteUserGroupSync(DeleteUserGroupRequest req)
        {
             JsonResponseModel<DeleteUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete the users under the current node. If an error occurs when a user is deleted, the deletion of other selected users will not be affected, and the username/ID of the user who fails to be deleted will be prompted.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public async Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete the users under the current node. If an error occurs when a user is deleted, the deletion of other selected users will not be affected, and the username/ID of the user who fails to be deleted will be prompted.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupResponse"/></returns>
        public async Task<DescribeAccountGroupResponse> DescribeAccountGroup(DescribeAccountGroupRequest req)
        {
             JsonResponseModel<DescribeAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of account groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupResponse"/></returns>
        public DescribeAccountGroupResponse DescribeAccountGroupSync(DescribeAccountGroupRequest req)
        {
             JsonResponseModel<DescribeAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of application accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppAccountRequest"/></param>
        /// <returns><see cref="DescribeAppAccountResponse"/></returns>
        public async Task<DescribeAppAccountResponse> DescribeAppAccount(DescribeAppAccountRequest req)
        {
             JsonResponseModel<DescribeAppAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of application accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppAccountRequest"/></param>
        /// <returns><see cref="DescribeAppAccountResponse"/></returns>
        public DescribeAppAccountResponse DescribeAppAccountSync(DescribeAppAccountRequest req)
        {
             JsonResponseModel<DescribeAppAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public async Task<DescribeApplicationResponse> DescribeApplication(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationRequest"/></param>
        /// <returns><see cref="DescribeApplicationResponse"/></returns>
        public DescribeApplicationResponse DescribeApplicationSync(DescribeApplicationRequest req)
        {
             JsonResponseModel<DescribeApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read the information of an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public async Task<DescribeOrgNodeResponse> DescribeOrgNode(DescribeOrgNodeRequest req)
        {
             JsonResponseModel<DescribeOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read the information of an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrgNodeRequest"/></param>
        /// <returns><see cref="DescribeOrgNodeResponse"/></returns>
        public DescribeOrgNodeResponse DescribeOrgNodeSync(DescribeOrgNodeRequest req)
        {
             JsonResponseModel<DescribeOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a JWT public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public async Task<DescribePublicKeyResponse> DescribePublicKey(DescribePublicKeyRequest req)
        {
             JsonResponseModel<DescribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a JWT public key.
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public DescribePublicKeyResponse DescribePublicKeySync(DescribePublicKeyRequest req)
        {
             JsonResponseModel<DescribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public async Task<DescribeUserGroupResponse> DescribeUserGroup(DescribeUserGroupRequest req)
        {
             JsonResponseModel<DescribeUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a user group.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupRequest"/></param>
        /// <returns><see cref="DescribeUserGroupResponse"/></returns>
        public DescribeUserGroupResponse DescribeUserGroupSync(DescribeUserGroupRequest req)
        {
             JsonResponseModel<DescribeUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public async Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of resource authorizations under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesAuthorizationResponse"/></returns>
        public async Task<DescribeUserResourcesAuthorizationResponse> DescribeUserResourcesAuthorization(DescribeUserResourcesAuthorizationRequest req)
        {
             JsonResponseModel<DescribeUserResourcesAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserResourcesAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of resource authorizations under the specified user.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserResourcesAuthorizationRequest"/></param>
        /// <returns><see cref="DescribeUserResourcesAuthorizationResponse"/></returns>
        public DescribeUserResourcesAuthorizationResponse DescribeUserResourcesAuthorizationSync(DescribeUserResourcesAuthorizationRequest req)
        {
             JsonResponseModel<DescribeUserResourcesAuthorizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserResourcesAuthorization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResourcesAuthorizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the third-party account binding information by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserThirdPartyAccountInfoRequest"/></param>
        /// <returns><see cref="DescribeUserThirdPartyAccountInfoResponse"/></returns>
        public async Task<DescribeUserThirdPartyAccountInfoResponse> DescribeUserThirdPartyAccountInfo(DescribeUserThirdPartyAccountInfoRequest req)
        {
             JsonResponseModel<DescribeUserThirdPartyAccountInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserThirdPartyAccountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserThirdPartyAccountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the third-party account binding information by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserThirdPartyAccountInfoRequest"/></param>
        /// <returns><see cref="DescribeUserThirdPartyAccountInfoResponse"/></returns>
        public DescribeUserThirdPartyAccountInfoResponse DescribeUserThirdPartyAccountInfoSync(DescribeUserThirdPartyAccountInfoRequest req)
        {
             JsonResponseModel<DescribeUserThirdPartyAccountInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserThirdPartyAccountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserThirdPartyAccountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to get the list of accounts in an account group.
        /// </summary>
        /// <param name="req"><see cref="ListAccountInAccountGroupRequest"/></param>
        /// <returns><see cref="ListAccountInAccountGroupResponse"/></returns>
        public async Task<ListAccountInAccountGroupResponse> ListAccountInAccountGroup(ListAccountInAccountGroupRequest req)
        {
             JsonResponseModel<ListAccountInAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAccountInAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAccountInAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to get the list of accounts in an account group.
        /// </summary>
        /// <param name="req"><see cref="ListAccountInAccountGroupRequest"/></param>
        /// <returns><see cref="ListAccountInAccountGroupResponse"/></returns>
        public ListAccountInAccountGroupResponse ListAccountInAccountGroupSync(ListAccountInAccountGroupRequest req)
        {
             JsonResponseModel<ListAccountInAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAccountInAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAccountInAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of authorization relationships of an application (including search criteria-based match).
        /// </summary>
        /// <param name="req"><see cref="ListApplicationAuthorizationsRequest"/></param>
        /// <returns><see cref="ListApplicationAuthorizationsResponse"/></returns>
        public async Task<ListApplicationAuthorizationsResponse> ListApplicationAuthorizations(ListApplicationAuthorizationsRequest req)
        {
             JsonResponseModel<ListApplicationAuthorizationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListApplicationAuthorizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListApplicationAuthorizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of authorization relationships of an application (including search criteria-based match).
        /// </summary>
        /// <param name="req"><see cref="ListApplicationAuthorizationsRequest"/></param>
        /// <returns><see cref="ListApplicationAuthorizationsResponse"/></returns>
        public ListApplicationAuthorizationsResponse ListApplicationAuthorizationsSync(ListApplicationAuthorizationsRequest req)
        {
             JsonResponseModel<ListApplicationAuthorizationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListApplicationAuthorizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListApplicationAuthorizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of applications.
        /// </summary>
        /// <param name="req"><see cref="ListApplicationsRequest"/></param>
        /// <returns><see cref="ListApplicationsResponse"/></returns>
        public async Task<ListApplicationsResponse> ListApplications(ListApplicationsRequest req)
        {
             JsonResponseModel<ListApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of applications.
        /// </summary>
        /// <param name="req"><see cref="ListApplicationsRequest"/></param>
        /// <returns><see cref="ListApplicationsResponse"/></returns>
        public ListApplicationsResponse ListApplicationsSync(ListApplicationsRequest req)
        {
             JsonResponseModel<ListApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToOrgNodeResponse> ListAuthorizedApplicationsToOrgNode(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToOrgNodeRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToOrgNodeResponse"/></returns>
        public ListAuthorizedApplicationsToOrgNodeResponse ListAuthorizedApplicationsToOrgNodeSync(ListAuthorizedApplicationsToOrgNodeRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToUserResponse> ListAuthorizedApplicationsToUser(ListAuthorizedApplicationsToUserRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserResponse"/></returns>
        public ListAuthorizedApplicationsToUserResponse ListAuthorizedApplicationsToUserSync(ListAuthorizedApplicationsToUserRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user group ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public async Task<ListAuthorizedApplicationsToUserGroupResponse> ListAuthorizedApplicationsToUserGroup(ListAuthorizedApplicationsToUserGroupRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAuthorizedApplicationsToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of accessible applications by user group ID.
        /// </summary>
        /// <param name="req"><see cref="ListAuthorizedApplicationsToUserGroupRequest"/></param>
        /// <returns><see cref="ListAuthorizedApplicationsToUserGroupResponse"/></returns>
        public ListAuthorizedApplicationsToUserGroupResponse ListAuthorizedApplicationsToUserGroupSync(ListAuthorizedApplicationsToUserGroupRequest req)
        {
             JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAuthorizedApplicationsToUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAuthorizedApplicationsToUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the user group list (including query conditions).
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public async Task<ListUserGroupsResponse> ListUserGroups(ListUserGroupsRequest req)
        {
             JsonResponseModel<ListUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the user group list (including query conditions).
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public ListUserGroupsResponse ListUserGroupsSync(ListUserGroupsRequest req)
        {
             JsonResponseModel<ListUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of a user's user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public async Task<ListUserGroupsOfUserResponse> ListUserGroupsOfUser(ListUserGroupsOfUserRequest req)
        {
             JsonResponseModel<ListUserGroupsOfUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUserGroupsOfUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsOfUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of a user's user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsOfUserRequest"/></param>
        /// <returns><see cref="ListUserGroupsOfUserResponse"/></returns>
        public ListUserGroupsOfUserResponse ListUserGroupsOfUserSync(ListUserGroupsOfUserRequest req)
        {
             JsonResponseModel<ListUserGroupsOfUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUserGroupsOfUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUserGroupsOfUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public async Task<ListUsersResponse> ListUsers(ListUsersRequest req)
        {
             JsonResponseModel<ListUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the user list.
        /// </summary>
        /// <param name="req"><see cref="ListUsersRequest"/></param>
        /// <returns><see cref="ListUsersResponse"/></returns>
        public ListUsersResponse ListUsersSync(ListUsersRequest req)
        {
             JsonResponseModel<ListUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read the users under an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public async Task<ListUsersInOrgNodeResponse> ListUsersInOrgNode(ListUsersInOrgNodeRequest req)
        {
             JsonResponseModel<ListUsersInOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsersInOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to read the users under an organization node by organization node ID.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInOrgNodeRequest"/></param>
        /// <returns><see cref="ListUsersInOrgNodeResponse"/></returns>
        public ListUsersInOrgNodeResponse ListUsersInOrgNodeSync(ListUsersInOrgNodeRequest req)
        {
             JsonResponseModel<ListUsersInOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsersInOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of the users in a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public async Task<ListUsersInUserGroupResponse> ListUsersInUserGroup(ListUsersInUserGroupRequest req)
        {
             JsonResponseModel<ListUsersInUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListUsersInUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of the users in a user group.
        /// </summary>
        /// <param name="req"><see cref="ListUsersInUserGroupRequest"/></param>
        /// <returns><see cref="ListUsersInUserGroupResponse"/></returns>
        public ListUsersInUserGroupResponse ListUsersInUserGroupSync(ListUsersInUserGroupRequest req)
        {
             JsonResponseModel<ListUsersInUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListUsersInUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListUsersInUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an account group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountGroupRequest"/></param>
        /// <returns><see cref="ModifyAccountGroupResponse"/></returns>
        public async Task<ModifyAccountGroupResponse> ModifyAccountGroup(ModifyAccountGroupRequest req)
        {
             JsonResponseModel<ModifyAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an account group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountGroupRequest"/></param>
        /// <returns><see cref="ModifyAccountGroupResponse"/></returns>
        public ModifyAccountGroupResponse ModifyAccountGroupSync(ModifyAccountGroupRequest req)
        {
             JsonResponseModel<ModifyAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppAccountRequest"/></param>
        /// <returns><see cref="ModifyAppAccountResponse"/></returns>
        public async Task<ModifyAppAccountResponse> ModifyAppAccount(ModifyAppAccountRequest req)
        {
             JsonResponseModel<ModifyAppAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppAccountRequest"/></param>
        /// <returns><see cref="ModifyAppAccountResponse"/></returns>
        public ModifyAppAccountResponse ModifyAppAccountSync(ModifyAppAccountRequest req)
        {
             JsonResponseModel<ModifyAppAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public async Task<ModifyApplicationResponse> ModifyApplication(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationRequest"/></param>
        /// <returns><see cref="ModifyApplicationResponse"/></returns>
        public ModifyApplicationResponse ModifyApplicationSync(ModifyApplicationRequest req)
        {
             JsonResponseModel<ModifyApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public async Task<ModifyUserInfoResponse> ModifyUserInfo(ModifyUserInfoRequest req)
        {
             JsonResponseModel<ModifyUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a user by username or user ID.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserInfoRequest"/></param>
        /// <returns><see cref="ModifyUserInfoResponse"/></returns>
        public ModifyUserInfoResponse ModifyUserInfoSync(ModifyUserInfoRequest req)
        {
             JsonResponseModel<ModifyUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove an account from an account group.
        /// </summary>
        /// <param name="req"><see cref="RemoveAccountFromAccountGroupRequest"/></param>
        /// <returns><see cref="RemoveAccountFromAccountGroupResponse"/></returns>
        public async Task<RemoveAccountFromAccountGroupResponse> RemoveAccountFromAccountGroup(RemoveAccountFromAccountGroupRequest req)
        {
             JsonResponseModel<RemoveAccountFromAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveAccountFromAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAccountFromAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove an account from an account group.
        /// </summary>
        /// <param name="req"><see cref="RemoveAccountFromAccountGroupRequest"/></param>
        /// <returns><see cref="RemoveAccountFromAccountGroupResponse"/></returns>
        public RemoveAccountFromAccountGroupResponse RemoveAccountFromAccountGroupSync(RemoveAccountFromAccountGroupRequest req)
        {
             JsonResponseModel<RemoveAccountFromAccountGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveAccountFromAccountGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAccountFromAccountGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a user from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public async Task<RemoveUserFromUserGroupResponse> RemoveUserFromUserGroup(RemoveUserFromUserGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUserFromUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a user from a user group.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserFromUserGroupRequest"/></param>
        /// <returns><see cref="RemoveUserFromUserGroupResponse"/></returns>
        public RemoveUserFromUserGroupResponse RemoveUserFromUserGroupSync(RemoveUserFromUserGroupRequest req)
        {
             JsonResponseModel<RemoveUserFromUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUserFromUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserFromUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public async Task<UpdateOrgNodeResponse> UpdateOrgNode(UpdateOrgNodeRequest req)
        {
             JsonResponseModel<UpdateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an organization node.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrgNodeRequest"/></param>
        /// <returns><see cref="UpdateOrgNodeResponse"/></returns>
        public UpdateOrgNodeResponse UpdateOrgNodeSync(UpdateOrgNodeRequest req)
        {
             JsonResponseModel<UpdateOrgNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateOrgNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateOrgNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
