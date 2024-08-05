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

namespace TencentCloud.Ciam.V20220331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ciam.V20220331.Models;

   public class CiamClient : AbstractClient{

       private const string endpoint = "ciam.tencentcloudapi.com";
       private const string version = "2022-03-31";
       private const string sdkVersion = "SDK_NET_3.0.954";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an API for user import task.
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public Task<CreateApiImportUserJobResponse> CreateApiImportUserJob(CreateApiImportUserJobRequest req)
        {
            return InternalRequestAsync<CreateApiImportUserJobResponse>(req, "CreateApiImportUserJob");
        }

        /// <summary>
        /// This API is used to create an API for user import task.
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public CreateApiImportUserJobResponse CreateApiImportUserJobSync(CreateApiImportUserJobRequest req)
        {
            return InternalRequestAsync<CreateApiImportUserJobResponse>(req, "CreateApiImportUserJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file for user export task.
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public Task<CreateFileExportUserJobResponse> CreateFileExportUserJob(CreateFileExportUserJobRequest req)
        {
            return InternalRequestAsync<CreateFileExportUserJobResponse>(req, "CreateFileExportUserJob");
        }

        /// <summary>
        /// This API is used to create a file for user export task.
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public CreateFileExportUserJobResponse CreateFileExportUserJobSync(CreateFileExportUserJobRequest req)
        {
            return InternalRequestAsync<CreateFileExportUserJobResponse>(req, "CreateFileExportUserJob")
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
        /// This API is used to delete users in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// This API is used to delete users in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the user information with multiple conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// This API is used to query the user information with multiple conditions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a user by ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public Task<DescribeUserByIdResponse> DescribeUserById(DescribeUserByIdRequest req)
        {
            return InternalRequestAsync<DescribeUserByIdResponse>(req, "DescribeUserById");
        }

        /// <summary>
        /// This API is used to query a user by ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public DescribeUserByIdResponse DescribeUserByIdSync(DescribeUserByIdRequest req)
        {
            return InternalRequestAsync<DescribeUserByIdResponse>(req, "DescribeUserById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to merge accounts.
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public Task<LinkAccountResponse> LinkAccount(LinkAccountRequest req)
        {
            return InternalRequestAsync<LinkAccountResponse>(req, "LinkAccount");
        }

        /// <summary>
        /// This API is used to merge accounts.
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public LinkAccountResponse LinkAccountSync(LinkAccountRequest req)
        {
            return InternalRequestAsync<LinkAccountResponse>(req, "LinkAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a task.
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public Task<ListJobsResponse> ListJobs(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs");
        }

        /// <summary>
        /// This API is used to query the details of a task.
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public ListJobsResponse ListJobsSync(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a specified log.
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public Task<ListLogMessageByConditionResponse> ListLogMessageByCondition(ListLogMessageByConditionRequest req)
        {
            return InternalRequestAsync<ListLogMessageByConditionResponse>(req, "ListLogMessageByCondition");
        }

        /// <summary>
        /// This API is used to query a specified log.
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public ListLogMessageByConditionResponse ListLogMessageByConditionSync(ListLogMessageByConditionRequest req)
        {
            return InternalRequestAsync<ListLogMessageByConditionResponse>(req, "ListLogMessageByCondition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of users.
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public Task<ListUserResponse> ListUser(ListUserRequest req)
        {
            return InternalRequestAsync<ListUserResponse>(req, "ListUser");
        }

        /// <summary>
        /// This API is used to query the list of users.
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public ListUserResponse ListUserSync(ListUserRequest req)
        {
            return InternalRequestAsync<ListUserResponse>(req, "ListUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of users by attribute.
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public Task<ListUserByPropertyResponse> ListUserByProperty(ListUserByPropertyRequest req)
        {
            return InternalRequestAsync<ListUserByPropertyResponse>(req, "ListUserByProperty");
        }

        /// <summary>
        /// This API is used to query the list of users by attribute.
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public ListUserByPropertyResponse ListUserByPropertySync(ListUserByPropertyRequest req)
        {
            return InternalRequestAsync<ListUserByPropertyResponse>(req, "ListUserByProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password for a user.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// This API is used to reset the password for a user.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the password for a user.
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public Task<SetPasswordResponse> SetPassword(SetPasswordRequest req)
        {
            return InternalRequestAsync<SetPasswordResponse>(req, "SetPassword");
        }

        /// <summary>
        /// This API is used to set the password for a user.
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public SetPasswordResponse SetPasswordSync(SetPasswordRequest req)
        {
            return InternalRequestAsync<SetPasswordResponse>(req, "SetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// This API is used to update a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the status of a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public Task<UpdateUserStatusResponse> UpdateUserStatus(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus");
        }

        /// <summary>
        /// This API is used to update the status of a user.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public UpdateUserStatusResponse UpdateUserStatusSync(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
