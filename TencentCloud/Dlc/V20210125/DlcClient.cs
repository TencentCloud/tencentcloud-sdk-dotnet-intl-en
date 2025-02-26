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

namespace TencentCloud.Dlc.V20210125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dlc.V20210125.Models;

   public class DlcClient : AbstractClient{

       private const string endpoint = "dlc.tencentcloudapi.com";
       private const string version = "2021-01-25";
       private const string sdkVersion = "SDK_NET_3.0.1078";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DlcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add users to working groups.
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public Task<AddUsersToWorkGroupResponse> AddUsersToWorkGroup(AddUsersToWorkGroupRequest req)
        {
            return InternalRequestAsync<AddUsersToWorkGroupResponse>(req, "AddUsersToWorkGroup");
        }

        /// <summary>
        /// This API is used to add users to working groups.
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public AddUsersToWorkGroupResponse AddUsersToWorkGroupSync(AddUsersToWorkGroupRequest req)
        {
            return InternalRequestAsync<AddUsersToWorkGroupResponse>(req, "AddUsersToWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public Task<AlterDMSDatabaseResponse> AlterDMSDatabase(AlterDMSDatabaseRequest req)
        {
            return InternalRequestAsync<AlterDMSDatabaseResponse>(req, "AlterDMSDatabase");
        }

        /// <summary>
        /// This API is used to update databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public AlterDMSDatabaseResponse AlterDMSDatabaseSync(AlterDMSDatabaseRequest req)
        {
            return InternalRequestAsync<AlterDMSDatabaseResponse>(req, "AlterDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind the authentication policy to the user.
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy");
        }

        /// <summary>
        /// This API is used to bind the authentication policy to the user.
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind an authentication policy to a working group.
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public Task<AttachWorkGroupPolicyResponse> AttachWorkGroupPolicy(AttachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachWorkGroupPolicyResponse>(req, "AttachWorkGroupPolicy");
        }

        /// <summary>
        /// This API is used to bind an authentication policy to a working group.
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public AttachWorkGroupPolicyResponse AttachWorkGroupPolicySync(AttachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachWorkGroupPolicyResponse>(req, "AttachWorkGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind working groups to users.
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public Task<BindWorkGroupsToUserResponse> BindWorkGroupsToUser(BindWorkGroupsToUserRequest req)
        {
            return InternalRequestAsync<BindWorkGroupsToUserResponse>(req, "BindWorkGroupsToUser");
        }

        /// <summary>
        /// This API is used to bind working groups to users.
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public BindWorkGroupsToUserResponse BindWorkGroupsToUserSync(BindWorkGroupsToUserRequest req)
        {
            return InternalRequestAsync<BindWorkGroupsToUserResponse>(req, "BindWorkGroupsToUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public Task<CancelSparkSessionBatchSQLResponse> CancelSparkSessionBatchSQL(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL");
        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public CancelSparkSessionBatchSQLResponse CancelSparkSessionBatchSQLSync(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask");
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the validity of the engine's user-defined parameters.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public Task<CheckDataEngineConfigPairsValidityResponse> CheckDataEngineConfigPairsValidity(CheckDataEngineConfigPairsValidityRequest req)
        {
            return InternalRequestAsync<CheckDataEngineConfigPairsValidityResponse>(req, "CheckDataEngineConfigPairsValidity");
        }

        /// <summary>
        /// This API is used to check the validity of the engine's user-defined parameters.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public CheckDataEngineConfigPairsValidityResponse CheckDataEngineConfigPairsValiditySync(CheckDataEngineConfigPairsValidityRequest req)
        {
            return InternalRequestAsync<CheckDataEngineConfigPairsValidityResponse>(req, "CheckDataEngineConfigPairsValidity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the cluster can be rolled back.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public Task<CheckDataEngineImageCanBeRollbackResponse> CheckDataEngineImageCanBeRollback(CheckDataEngineImageCanBeRollbackRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeRollbackResponse>(req, "CheckDataEngineImageCanBeRollback");
        }

        /// <summary>
        /// This API is used to check whether the cluster can be rolled back.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public CheckDataEngineImageCanBeRollbackResponse CheckDataEngineImageCanBeRollbackSync(CheckDataEngineImageCanBeRollbackRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeRollbackResponse>(req, "CheckDataEngineImageCanBeRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the cluster image can be upgraded.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public Task<CheckDataEngineImageCanBeUpgradeResponse> CheckDataEngineImageCanBeUpgrade(CheckDataEngineImageCanBeUpgradeRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeUpgradeResponse>(req, "CheckDataEngineImageCanBeUpgrade");
        }

        /// <summary>
        /// This API is used to check whether the cluster image can be upgraded.
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public CheckDataEngineImageCanBeUpgradeResponse CheckDataEngineImageCanBeUpgradeSync(CheckDataEngineImageCanBeUpgradeRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeUpgradeResponse>(req, "CheckDataEngineImageCanBeUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the permission status.
        /// </summary>
        /// <param name="req"><see cref="CheckGrantedPermissionRequest"/></param>
        /// <returns><see cref="CheckGrantedPermissionResponse"/></returns>
        public Task<CheckGrantedPermissionResponse> CheckGrantedPermission(CheckGrantedPermissionRequest req)
        {
            return InternalRequestAsync<CheckGrantedPermissionResponse>(req, "CheckGrantedPermission");
        }

        /// <summary>
        /// This API is used to check the permission status.
        /// </summary>
        /// <param name="req"><see cref="CheckGrantedPermissionRequest"/></param>
        /// <returns><see cref="CheckGrantedPermissionResponse"/></returns>
        public CheckGrantedPermissionResponse CheckGrantedPermissionSync(CheckGrantedPermissionRequest req)
        {
            return InternalRequestAsync<CheckGrantedPermissionResponse>(req, "CheckGrantedPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to copy a table.
        /// </summary>
        /// <param name="req"><see cref="CopyDLCTableRequest"/></param>
        /// <returns><see cref="CopyDLCTableResponse"/></returns>
        public Task<CopyDLCTableResponse> CopyDLCTable(CopyDLCTableRequest req)
        {
            return InternalRequestAsync<CopyDLCTableResponse>(req, "CopyDLCTable");
        }

        /// <summary>
        /// This API is used to copy a table.
        /// </summary>
        /// <param name="req"><see cref="CopyDLCTableRequest"/></param>
        /// <returns><see cref="CopyDLCTableResponse"/></returns>
        public CopyDLCTableResponse CopyDLCTableSync(CopyDLCTableRequest req)
        {
            return InternalRequestAsync<CopyDLCTableResponse>(req, "CopyDLCTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create metadata acceleration buckets and the binding relationship between products.
        /// </summary>
        /// <param name="req"><see cref="CreateCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="CreateCHDFSBindingProductResponse"/></returns>
        public Task<CreateCHDFSBindingProductResponse> CreateCHDFSBindingProduct(CreateCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<CreateCHDFSBindingProductResponse>(req, "CreateCHDFSBindingProduct");
        }

        /// <summary>
        /// This API is used to create metadata acceleration buckets and the binding relationship between products.
        /// </summary>
        /// <param name="req"><see cref="CreateCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="CreateCHDFSBindingProductResponse"/></returns>
        public CreateCHDFSBindingProductResponse CreateCHDFSBindingProductSync(CreateCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<CreateCHDFSBindingProductResponse>(req, "CreateCHDFSBindingProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a table.
        /// </summary>
        /// <param name="req"><see cref="CreateDLCTableRequest"/></param>
        /// <returns><see cref="CreateDLCTableResponse"/></returns>
        public Task<CreateDLCTableResponse> CreateDLCTable(CreateDLCTableRequest req)
        {
            return InternalRequestAsync<CreateDLCTableResponse>(req, "CreateDLCTable");
        }

        /// <summary>
        /// This API is used to create a table.
        /// </summary>
        /// <param name="req"><see cref="CreateDLCTableRequest"/></param>
        /// <returns><see cref="CreateDLCTableResponse"/></returns>
        public CreateDLCTableResponse CreateDLCTableSync(CreateDLCTableRequest req)
        {
            return InternalRequestAsync<CreateDLCTableResponse>(req, "CreateDLCTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public Task<CreateDMSDatabaseResponse> CreateDMSDatabase(CreateDMSDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDMSDatabaseResponse>(req, "CreateDMSDatabase");
        }

        /// <summary>
        /// This API is used to create databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public CreateDMSDatabaseResponse CreateDMSDatabaseSync(CreateDMSDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDMSDatabaseResponse>(req, "CreateDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public Task<CreateDataEngineResponse> CreateDataEngine(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine");
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public CreateDataEngineResponse CreateDataEngineSync(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public Task<CreateInternalTableResponse> CreateInternalTable(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable");
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public CreateInternalTableResponse CreateInternalTableSync(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public Task<CreateResultDownloadResponse> CreateResultDownload(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload");
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public CreateResultDownloadResponse CreateResultDownloadSync(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public Task<CreateSparkAppResponse> CreateSparkApp(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp");
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public CreateSparkAppResponse CreateSparkAppSync(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public Task<CreateSparkAppTaskResponse> CreateSparkAppTask(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask");
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public CreateSparkAppTaskResponse CreateSparkAppTaskSync(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public Task<CreateSparkSessionBatchSQLResponse> CreateSparkSessionBatchSQL(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL");
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public CreateSparkSessionBatchSQLResponse CreateSparkSessionBatchSQLSync(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or overwrite the storage location of results.
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public Task<CreateStoreLocationResponse> CreateStoreLocation(CreateStoreLocationRequest req)
        {
            return InternalRequestAsync<CreateStoreLocationResponse>(req, "CreateStoreLocation");
        }

        /// <summary>
        /// This API is used to add or overwrite the storage location of results.
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public CreateStoreLocationResponse CreateStoreLocationSync(CreateStoreLocationRequest req)
        {
            return InternalRequestAsync<CreateStoreLocationResponse>(req, "CreateStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public Task<CreateTasksResponse> CreateTasks(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks");
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public CreateTasksResponse CreateTasksSync(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create users.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// This API is used to create users.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create working groups.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public Task<CreateWorkGroupResponse> CreateWorkGroup(CreateWorkGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkGroupResponse>(req, "CreateWorkGroup");
        }

        /// <summary>
        /// This API is used to create working groups.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public CreateWorkGroupResponse CreateWorkGroupSync(CreateWorkGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkGroupResponse>(req, "CreateWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the binding relationship between metadata acceleration buckets and products.
        /// </summary>
        /// <param name="req"><see cref="DeleteCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="DeleteCHDFSBindingProductResponse"/></returns>
        public Task<DeleteCHDFSBindingProductResponse> DeleteCHDFSBindingProduct(DeleteCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<DeleteCHDFSBindingProductResponse>(req, "DeleteCHDFSBindingProduct");
        }

        /// <summary>
        /// This API is used to delete the binding relationship between metadata acceleration buckets and products.
        /// </summary>
        /// <param name="req"><see cref="DeleteCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="DeleteCHDFSBindingProductResponse"/></returns>
        public DeleteCHDFSBindingProductResponse DeleteCHDFSBindingProductSync(DeleteCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<DeleteCHDFSBindingProductResponse>(req, "DeleteCHDFSBindingProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the data engine.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public Task<DeleteDataEngineResponse> DeleteDataEngine(DeleteDataEngineRequest req)
        {
            return InternalRequestAsync<DeleteDataEngineResponse>(req, "DeleteDataEngine");
        }

        /// <summary>
        /// This API is used to delete the data engine.
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public DeleteDataEngineResponse DeleteDataEngineSync(DeleteDataEngineRequest req)
        {
            return InternalRequestAsync<DeleteDataEngineResponse>(req, "DeleteDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public Task<DeleteSparkAppResponse> DeleteSparkApp(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp");
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public DeleteSparkAppResponse DeleteSparkAppSync(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove visits through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DeleteThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DeleteThirdPartyAccessUserResponse"/></returns>
        public Task<DeleteThirdPartyAccessUserResponse> DeleteThirdPartyAccessUser(DeleteThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DeleteThirdPartyAccessUserResponse>(req, "DeleteThirdPartyAccessUser");
        }

        /// <summary>
        /// This API is used to remove visits through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DeleteThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DeleteThirdPartyAccessUserResponse"/></returns>
        public DeleteThirdPartyAccessUserResponse DeleteThirdPartyAccessUserSync(DeleteThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DeleteThirdPartyAccessUserResponse>(req, "DeleteThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete users.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// This API is used to delete users.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete users from working groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public Task<DeleteUsersFromWorkGroupResponse> DeleteUsersFromWorkGroup(DeleteUsersFromWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteUsersFromWorkGroupResponse>(req, "DeleteUsersFromWorkGroup");
        }

        /// <summary>
        /// This API is used to delete users from working groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public DeleteUsersFromWorkGroupResponse DeleteUsersFromWorkGroupSync(DeleteUsersFromWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteUsersFromWorkGroupResponse>(req, "DeleteUsersFromWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete working groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public Task<DeleteWorkGroupResponse> DeleteWorkGroup(DeleteWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkGroupResponse>(req, "DeleteWorkGroup");
        }

        /// <summary>
        /// This API is used to delete working groups.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public DeleteWorkGroupResponse DeleteWorkGroupSync(DeleteWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkGroupResponse>(req, "DeleteWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the advanced settings of the SQL query interface.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public Task<DescribeAdvancedStoreLocationResponse> DescribeAdvancedStoreLocation(DescribeAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeAdvancedStoreLocationResponse>(req, "DescribeAdvancedStoreLocation");
        }

        /// <summary>
        /// This API is used to query the advanced settings of the SQL query interface.
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public DescribeAdvancedStoreLocationResponse DescribeAdvancedStoreLocationSync(DescribeAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeAdvancedStoreLocationResponse>(req, "DescribeAdvancedStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the DLC Catalog authorization list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="DescribeDLCCatalogAccessResponse"/></returns>
        public Task<DescribeDLCCatalogAccessResponse> DescribeDLCCatalogAccess(DescribeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<DescribeDLCCatalogAccessResponse>(req, "DescribeDLCCatalogAccess");
        }

        /// <summary>
        /// This API is used to query the DLC Catalog authorization list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="DescribeDLCCatalogAccessResponse"/></returns>
        public DescribeDLCCatalogAccessResponse DescribeDLCCatalogAccessSync(DescribeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<DescribeDLCCatalogAccessResponse>(req, "DescribeDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the table.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCTableRequest"/></param>
        /// <returns><see cref="DescribeDLCTableResponse"/></returns>
        public Task<DescribeDLCTableResponse> DescribeDLCTable(DescribeDLCTableRequest req)
        {
            return InternalRequestAsync<DescribeDLCTableResponse>(req, "DescribeDLCTable");
        }

        /// <summary>
        /// This API is used to obtain the table.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCTableRequest"/></param>
        /// <returns><see cref="DescribeDLCTableResponse"/></returns>
        public DescribeDLCTableResponse DescribeDLCTableSync(DescribeDLCTableRequest req)
        {
            return InternalRequestAsync<DescribeDLCTableResponse>(req, "DescribeDLCTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCTableListRequest"/></param>
        /// <returns><see cref="DescribeDLCTableListResponse"/></returns>
        public Task<DescribeDLCTableListResponse> DescribeDLCTableList(DescribeDLCTableListRequest req)
        {
            return InternalRequestAsync<DescribeDLCTableListResponse>(req, "DescribeDLCTableList");
        }

        /// <summary>
        /// This API is used to obtain the list of tables.
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCTableListRequest"/></param>
        /// <returns><see cref="DescribeDLCTableListResponse"/></returns>
        public DescribeDLCTableListResponse DescribeDLCTableListSync(DescribeDLCTableListRequest req)
        {
            return InternalRequestAsync<DescribeDLCTableListResponse>(req, "DescribeDLCTableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public Task<DescribeDMSDatabaseResponse> DescribeDMSDatabase(DescribeDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseResponse>(req, "DescribeDMSDatabase");
        }

        /// <summary>
        /// This API is used to obtain databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public DescribeDMSDatabaseResponse DescribeDMSDatabaseSync(DescribeDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseResponse>(req, "DescribeDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseListResponse"/></returns>
        public Task<DescribeDMSDatabaseListResponse> DescribeDMSDatabaseList(DescribeDMSDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseListResponse>(req, "DescribeDMSDatabaseList");
        }

        /// <summary>
        /// This API is used to obtain the list of databases.
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseListResponse"/></returns>
        public DescribeDMSDatabaseListResponse DescribeDMSDatabaseListSync(DescribeDMSDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseListResponse>(req, "DescribeDMSDatabaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain detailed data engine information based on names.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public Task<DescribeDataEngineResponse> DescribeDataEngine(DescribeDataEngineRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineResponse>(req, "DescribeDataEngine");
        }

        /// <summary>
        /// This API is used to obtain detailed data engine information based on names.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public DescribeDataEngineResponse DescribeDataEngineSync(DescribeDataEngineRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineResponse>(req, "DescribeDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the major version image list of exclusive clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public Task<DescribeDataEngineImageVersionsResponse> DescribeDataEngineImageVersions(DescribeDataEngineImageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineImageVersionsResponse>(req, "DescribeDataEngineImageVersions");
        }

        /// <summary>
        /// This API is used to obtain the major version image list of exclusive clusters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public DescribeDataEngineImageVersionsResponse DescribeDataEngineImageVersionsSync(DescribeDataEngineImageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineImageVersionsResponse>(req, "DescribeDataEngineImageVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the PYSPARK image list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public Task<DescribeDataEnginePythonSparkImagesResponse> DescribeDataEnginePythonSparkImages(DescribeDataEnginePythonSparkImagesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginePythonSparkImagesResponse>(req, "DescribeDataEnginePythonSparkImages");
        }

        /// <summary>
        /// This API is used to obtain the PYSPARK image list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public DescribeDataEnginePythonSparkImagesResponse DescribeDataEnginePythonSparkImagesSync(DescribeDataEnginePythonSparkImagesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginePythonSparkImagesResponse>(req, "DescribeDataEnginePythonSparkImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query engine specification details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesScaleDetailRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesScaleDetailResponse"/></returns>
        public Task<DescribeDataEnginesScaleDetailResponse> DescribeDataEnginesScaleDetail(DescribeDataEnginesScaleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesScaleDetailResponse>(req, "DescribeDataEnginesScaleDetail");
        }

        /// <summary>
        /// This API is used to query engine specification details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesScaleDetailRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesScaleDetailResponse"/></returns>
        public DescribeDataEnginesScaleDetailResponse DescribeDataEnginesScaleDetailSync(DescribeDataEnginesScaleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesScaleDetailResponse>(req, "DescribeDataEnginesScaleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public Task<DescribeEngineUsageInfoResponse> DescribeEngineUsageInfo(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo");
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public DescribeEngineUsageInfoResponse DescribeEngineUsageInfoSync(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public Task<DescribeForbiddenTableProResponse> DescribeForbiddenTablePro(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro");
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public DescribeForbiddenTableProResponse DescribeForbiddenTableProSync(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the job information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob");
        }

        /// <summary>
        /// This API is used to obtain the job information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of job information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// This API is used to obtain the list of job information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public Task<DescribeLakeFsDirSummaryResponse> DescribeLakeFsDirSummary(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary");
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public DescribeLakeFsDirSummaryResponse DescribeLakeFsDirSummarySync(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public Task<DescribeLakeFsInfoResponse> DescribeLakeFsInfo(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo");
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public DescribeLakeFsInfoResponse DescribeLakeFsInfoSync(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of metadata acceleration buckets bound to other products.
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCHDFSBindingListRequest"/></param>
        /// <returns><see cref="DescribeOtherCHDFSBindingListResponse"/></returns>
        public Task<DescribeOtherCHDFSBindingListResponse> DescribeOtherCHDFSBindingList(DescribeOtherCHDFSBindingListRequest req)
        {
            return InternalRequestAsync<DescribeOtherCHDFSBindingListResponse>(req, "DescribeOtherCHDFSBindingList");
        }

        /// <summary>
        /// This API is used to query the list of metadata acceleration buckets bound to other products.
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCHDFSBindingListRequest"/></param>
        /// <returns><see cref="DescribeOtherCHDFSBindingListResponse"/></returns>
        public DescribeOtherCHDFSBindingListResponse DescribeOtherCHDFSBindingListSync(DescribeOtherCHDFSBindingListRequest req)
        {
            return InternalRequestAsync<DescribeOtherCHDFSBindingListResponse>(req, "DescribeOtherCHDFSBindingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueryRequest"/></param>
        /// <returns><see cref="DescribeQueryResponse"/></returns>
        public Task<DescribeQueryResponse> DescribeQuery(DescribeQueryRequest req)
        {
            return InternalRequestAsync<DescribeQueryResponse>(req, "DescribeQuery");
        }

        /// <summary>
        /// This API is used to obtain the query results.
        /// </summary>
        /// <param name="req"><see cref="DescribeQueryRequest"/></param>
        /// <returns><see cref="DescribeQueryResponse"/></returns>
        public DescribeQueryResponse DescribeQuerySync(DescribeQueryRequest req)
        {
            return InternalRequestAsync<DescribeQueryResponse>(req, "DescribeQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public Task<DescribeResultDownloadResponse> DescribeResultDownload(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload");
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public DescribeResultDownloadResponse DescribeResultDownloadSync(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public Task<DescribeSparkAppJobResponse> DescribeSparkAppJob(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob");
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public DescribeSparkAppJobResponse DescribeSparkAppJobSync(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public Task<DescribeSparkAppJobsResponse> DescribeSparkAppJobs(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs");
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public DescribeSparkAppJobsResponse DescribeSparkAppJobsSync(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public Task<DescribeSparkAppTasksResponse> DescribeSparkAppTasks(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks");
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public DescribeSparkAppTasksResponse DescribeSparkAppTasksSync(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Spark SQL batch task logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public Task<DescribeSparkSessionBatchSqlLogResponse> DescribeSparkSessionBatchSqlLog(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog");
        }

        /// <summary>
        /// This API is used to query Spark SQL batch task logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public DescribeSparkSessionBatchSqlLogResponse DescribeSparkSessionBatchSqlLogSync(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the storage location of calculation results.
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public Task<DescribeStoreLocationResponse> DescribeStoreLocation(DescribeStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeStoreLocationResponse>(req, "DescribeStoreLocation");
        }

        /// <summary>
        /// This API is used to query the storage location of calculation results.
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public DescribeStoreLocationResponse DescribeStoreLocationSync(DescribeStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeStoreLocationResponse>(req, "DescribeStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the sub-user's visiting policy for users accessing through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserAccessPolicyRequest"/></param>
        /// <returns><see cref="DescribeSubUserAccessPolicyResponse"/></returns>
        public Task<DescribeSubUserAccessPolicyResponse> DescribeSubUserAccessPolicy(DescribeSubUserAccessPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSubUserAccessPolicyResponse>(req, "DescribeSubUserAccessPolicy");
        }

        /// <summary>
        /// This API is used to query the sub-user's visiting policy for users accessing through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserAccessPolicyRequest"/></param>
        /// <returns><see cref="DescribeSubUserAccessPolicyResponse"/></returns>
        public DescribeSubUserAccessPolicyResponse DescribeSubUserAccessPolicySync(DescribeSubUserAccessPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSubUserAccessPolicyResponse>(req, "DescribeSubUserAccessPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the data table name list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesNameRequest"/></param>
        /// <returns><see cref="DescribeTablesNameResponse"/></returns>
        public Task<DescribeTablesNameResponse> DescribeTablesName(DescribeTablesNameRequest req)
        {
            return InternalRequestAsync<DescribeTablesNameResponse>(req, "DescribeTablesName");
        }

        /// <summary>
        /// This API is used to query the data table name list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesNameRequest"/></param>
        /// <returns><see cref="DescribeTablesNameResponse"/></returns>
        public DescribeTablesNameResponse DescribeTablesNameSync(DescribeTablesNameRequest req)
        {
            return InternalRequestAsync<DescribeTablesNameResponse>(req, "DescribeTablesName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe the information on task statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeTaskStatisticsResponse"/></returns>
        public Task<DescribeTaskStatisticsResponse> DescribeTaskStatistics(DescribeTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatisticsResponse>(req, "DescribeTaskStatistics");
        }

        /// <summary>
        /// This API is used to describe the information on task statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeTaskStatisticsResponse"/></returns>
        public DescribeTaskStatisticsResponse DescribeTaskStatisticsSync(DescribeTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatisticsResponse>(req, "DescribeTaskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of users visiting through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAccessUserResponse"/></returns>
        public Task<DescribeThirdPartyAccessUserResponse> DescribeThirdPartyAccessUser(DescribeThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DescribeThirdPartyAccessUserResponse>(req, "DescribeThirdPartyAccessUser");
        }

        /// <summary>
        /// This API is used to query the information of users visiting through the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAccessUserResponse"/></returns>
        public DescribeThirdPartyAccessUserResponse DescribeThirdPartyAccessUserSync(DescribeThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DescribeThirdPartyAccessUserResponse>(req, "DescribeThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of engines that are able to upgrade their configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpdatableDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeUpdatableDataEnginesResponse"/></returns>
        public Task<DescribeUpdatableDataEnginesResponse> DescribeUpdatableDataEngines(DescribeUpdatableDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeUpdatableDataEnginesResponse>(req, "DescribeUpdatableDataEngines");
        }

        /// <summary>
        /// This API is used to query the list of engines that are able to upgrade their configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpdatableDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeUpdatableDataEnginesResponse"/></returns>
        public DescribeUpdatableDataEnginesResponse DescribeUpdatableDataEnginesSync(DescribeUpdatableDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeUpdatableDataEnginesResponse>(req, "DescribeUpdatableDataEngines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user-defined engine parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public Task<DescribeUserDataEngineConfigResponse> DescribeUserDataEngineConfig(DescribeUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserDataEngineConfigResponse>(req, "DescribeUserDataEngineConfig");
        }

        /// <summary>
        /// This API is used to query user-defined engine parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public DescribeUserDataEngineConfigResponse DescribeUserDataEngineConfigSync(DescribeUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserDataEngineConfigResponse>(req, "DescribeUserDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get detailed user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// This API is used to get detailed user information.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public Task<DescribeUserRolesResponse> DescribeUserRoles(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles");
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public DescribeUserRolesResponse DescribeUserRolesSync(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the types of users.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public Task<DescribeUserTypeResponse> DescribeUserType(DescribeUserTypeRequest req)
        {
            return InternalRequestAsync<DescribeUserTypeResponse>(req, "DescribeUserType");
        }

        /// <summary>
        /// This API is used to get the types of users.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public DescribeUserTypeResponse DescribeUserTypeSync(DescribeUserTypeRequest req)
        {
            return InternalRequestAsync<DescribeUserTypeResponse>(req, "DescribeUserType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// This API is used to obtain the user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get detailed information about working groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public Task<DescribeWorkGroupInfoResponse> DescribeWorkGroupInfo(DescribeWorkGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupInfoResponse>(req, "DescribeWorkGroupInfo");
        }

        /// <summary>
        /// This API is used to get detailed information about working groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public DescribeWorkGroupInfoResponse DescribeWorkGroupInfoSync(DescribeWorkGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupInfoResponse>(req, "DescribeWorkGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of working groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public Task<DescribeWorkGroupsResponse> DescribeWorkGroups(DescribeWorkGroupsRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupsResponse>(req, "DescribeWorkGroups");
        }

        /// <summary>
        /// This API is used to get a list of working groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public DescribeWorkGroupsResponse DescribeWorkGroupsSync(DescribeWorkGroupsRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupsResponse>(req, "DescribeWorkGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind the authentication policy from the user.
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy");
        }

        /// <summary>
        /// This API is used to unbind the authentication policy from the user.
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind the authentication policy from the working group.
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public Task<DetachWorkGroupPolicyResponse> DetachWorkGroupPolicy(DetachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachWorkGroupPolicyResponse>(req, "DetachWorkGroupPolicy");
        }

        /// <summary>
        /// This API is used to unbind the authentication policy from the working group.
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public DetachWorkGroupPolicyResponse DetachWorkGroupPolicySync(DetachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachWorkGroupPolicyResponse>(req, "DetachWorkGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the table.
        /// </summary>
        /// <param name="req"><see cref="DropDLCTableRequest"/></param>
        /// <returns><see cref="DropDLCTableResponse"/></returns>
        public Task<DropDLCTableResponse> DropDLCTable(DropDLCTableRequest req)
        {
            return InternalRequestAsync<DropDLCTableResponse>(req, "DropDLCTable");
        }

        /// <summary>
        /// This API is used to delete the table.
        /// </summary>
        /// <param name="req"><see cref="DropDLCTableRequest"/></param>
        /// <returns><see cref="DropDLCTableResponse"/></returns>
        public DropDLCTableResponse DropDLCTableSync(DropDLCTableRequest req)
        {
            return InternalRequestAsync<DropDLCTableResponse>(req, "DropDLCTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public Task<DropDMSDatabaseResponse> DropDMSDatabase(DropDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DropDMSDatabaseResponse>(req, "DropDMSDatabase");
        }

        /// <summary>
        /// This API is used to delete databases in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public DropDMSDatabaseResponse DropDMSDatabaseSync(DropDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DropDMSDatabaseResponse>(req, "DropDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete tables in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public Task<DropDMSTableResponse> DropDMSTable(DropDMSTableRequest req)
        {
            return InternalRequestAsync<DropDMSTableResponse>(req, "DropDMSTable");
        }

        /// <summary>
        /// This API is used to delete tables in the DMS metadata module.
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public DropDMSTableResponse DropDMSTableSync(DropDMSTableRequest req)
        {
            return InternalRequestAsync<DropDMSTableResponse>(req, "DropDMSTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public Task<GenerateCreateMangedTableSqlResponse> GenerateCreateMangedTableSql(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql");
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public GenerateCreateMangedTableSqlResponse GenerateCreateMangedTableSqlSync(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public Task<GetOptimizerPolicyResponse> GetOptimizerPolicy(GetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<GetOptimizerPolicyResponse>(req, "GetOptimizerPolicy");
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public GetOptimizerPolicyResponse GetOptimizerPolicySync(GetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<GetOptimizerPolicyResponse>(req, "GetOptimizerPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to grant permissions for visiting DLC Catalog.
        /// </summary>
        /// <param name="req"><see cref="GrantDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="GrantDLCCatalogAccessResponse"/></returns>
        public Task<GrantDLCCatalogAccessResponse> GrantDLCCatalogAccess(GrantDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<GrantDLCCatalogAccessResponse>(req, "GrantDLCCatalogAccess");
        }

        /// <summary>
        /// This API is used to grant permissions for visiting DLC Catalog.
        /// </summary>
        /// <param name="req"><see cref="GrantDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="GrantDLCCatalogAccessResponse"/></returns>
        public GrantDLCCatalogAccessResponse GrantDLCCatalogAccessSync(GrantDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<GrantDLCCatalogAccessResponse>(req, "GrantDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the advanced settings of the SQL query interface.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public Task<ModifyAdvancedStoreLocationResponse> ModifyAdvancedStoreLocation(ModifyAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<ModifyAdvancedStoreLocationResponse>(req, "ModifyAdvancedStoreLocation");
        }

        /// <summary>
        /// This API is used to modify the advanced settings of the SQL query interface.
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public ModifyAdvancedStoreLocationResponse ModifyAdvancedStoreLocationSync(ModifyAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<ModifyAdvancedStoreLocationResponse>(req, "ModifyAdvancedStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the engine's description.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public Task<ModifyDataEngineDescriptionResponse> ModifyDataEngineDescription(ModifyDataEngineDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyDataEngineDescriptionResponse>(req, "ModifyDataEngineDescription");
        }

        /// <summary>
        /// This API is used to modify the engine's description.
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public ModifyDataEngineDescriptionResponse ModifyDataEngineDescriptionSync(ModifyDataEngineDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyDataEngineDescriptionResponse>(req, "ModifyDataEngineDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public Task<ModifyGovernEventRuleResponse> ModifyGovernEventRule(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule");
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public ModifyGovernEventRuleResponse ModifyGovernEventRuleSync(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public Task<ModifySparkAppResponse> ModifySparkApp(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp");
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public ModifySparkAppResponse ModifySparkAppSync(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public Task<ModifySparkAppBatchResponse> ModifySparkAppBatch(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch");
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public ModifySparkAppBatchResponse ModifySparkAppBatchSync(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch")
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
        /// This API is used to modify the types of users. Only users who are also administrators can call this API to conduct the operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public Task<ModifyUserTypeResponse> ModifyUserType(ModifyUserTypeRequest req)
        {
            return InternalRequestAsync<ModifyUserTypeResponse>(req, "ModifyUserType");
        }

        /// <summary>
        /// This API is used to modify the types of users. Only users who are also administrators can call this API to conduct the operation.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public ModifyUserTypeResponse ModifyUserTypeSync(ModifyUserTypeRequest req)
        {
            return InternalRequestAsync<ModifyUserTypeResponse>(req, "ModifyUserType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify working group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public Task<ModifyWorkGroupResponse> ModifyWorkGroup(ModifyWorkGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkGroupResponse>(req, "ModifyWorkGroup");
        }

        /// <summary>
        /// This API is used to modify working group information.
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public ModifyWorkGroupResponse ModifyWorkGroupSync(ModifyWorkGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkGroupResponse>(req, "ModifyWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of obtaining tasks.
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public Task<QueryResultResponse> QueryResult(QueryResultRequest req)
        {
            return InternalRequestAsync<QueryResultResponse>(req, "QueryResult");
        }

        /// <summary>
        /// This API is used to query the result of obtaining tasks.
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public QueryResultResponse QueryResultSync(QueryResultRequest req)
        {
            return InternalRequestAsync<QueryResultResponse>(req, "QueryResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query task consumption details.
        /// </summary>
        /// <param name="req"><see cref="QueryTaskCostDetailRequest"/></param>
        /// <returns><see cref="QueryTaskCostDetailResponse"/></returns>
        public Task<QueryTaskCostDetailResponse> QueryTaskCostDetail(QueryTaskCostDetailRequest req)
        {
            return InternalRequestAsync<QueryTaskCostDetailResponse>(req, "QueryTaskCostDetail");
        }

        /// <summary>
        /// This API is used to query task consumption details.
        /// </summary>
        /// <param name="req"><see cref="QueryTaskCostDetailRequest"/></param>
        /// <returns><see cref="QueryTaskCostDetailResponse"/></returns>
        public QueryTaskCostDetailResponse QueryTaskCostDetailSync(QueryTaskCostDetailRequest req)
        {
            return InternalRequestAsync<QueryTaskCostDetailResponse>(req, "QueryTaskCostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable visits to the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="RegisterThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="RegisterThirdPartyAccessUserResponse"/></returns>
        public Task<RegisterThirdPartyAccessUserResponse> RegisterThirdPartyAccessUser(RegisterThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<RegisterThirdPartyAccessUserResponse>(req, "RegisterThirdPartyAccessUser");
        }

        /// <summary>
        /// This API is used to enable visits to the third-party platform.
        /// </summary>
        /// <param name="req"><see cref="RegisterThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="RegisterThirdPartyAccessUserResponse"/></returns>
        public RegisterThirdPartyAccessUserResponse RegisterThirdPartyAccessUserSync(RegisterThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<RegisterThirdPartyAccessUserResponse>(req, "RegisterThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to renew the data engine.
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public Task<RenewDataEngineResponse> RenewDataEngine(RenewDataEngineRequest req)
        {
            return InternalRequestAsync<RenewDataEngineResponse>(req, "RenewDataEngine");
        }

        /// <summary>
        /// This API is used to renew the data engine.
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public RenewDataEngineResponse RenewDataEngineSync(RenewDataEngineRequest req)
        {
            return InternalRequestAsync<RenewDataEngineResponse>(req, "RenewDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to restart engines.
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public Task<RestartDataEngineResponse> RestartDataEngine(RestartDataEngineRequest req)
        {
            return InternalRequestAsync<RestartDataEngineResponse>(req, "RestartDataEngine");
        }

        /// <summary>
        /// This API is used to restart engines.
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public RestartDataEngineResponse RestartDataEngineSync(RestartDataEngineRequest req)
        {
            return InternalRequestAsync<RestartDataEngineResponse>(req, "RestartDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to revoke permissions for visiting DLC Catalog.
        /// </summary>
        /// <param name="req"><see cref="RevokeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="RevokeDLCCatalogAccessResponse"/></returns>
        public Task<RevokeDLCCatalogAccessResponse> RevokeDLCCatalogAccess(RevokeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<RevokeDLCCatalogAccessResponse>(req, "RevokeDLCCatalogAccess");
        }

        /// <summary>
        /// This API is used to revoke permissions for visiting DLC Catalog.
        /// </summary>
        /// <param name="req"><see cref="RevokeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="RevokeDLCCatalogAccessResponse"/></returns>
        public RevokeDLCCatalogAccessResponse RevokeDLCCatalogAccessSync(RevokeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<RevokeDLCCatalogAccessResponse>(req, "RevokeDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to roll back the versions of the engine image.
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public Task<RollbackDataEngineImageResponse> RollbackDataEngineImage(RollbackDataEngineImageRequest req)
        {
            return InternalRequestAsync<RollbackDataEngineImageResponse>(req, "RollbackDataEngineImage");
        }

        /// <summary>
        /// This API is used to roll back the versions of the engine image.
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public RollbackDataEngineImageResponse RollbackDataEngineImageSync(RollbackDataEngineImageRequest req)
        {
            return InternalRequestAsync<RollbackDataEngineImageResponse>(req, "RollbackDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public Task<SuspendResumeDataEngineResponse> SuspendResumeDataEngine(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine");
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public SuspendResumeDataEngineResponse SuspendResumeDataEngineSync(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public Task<SwitchDataEngineResponse> SwitchDataEngine(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine");
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public SwitchDataEngineResponse SwitchDataEngineSync(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch the versions of the engine image.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public Task<SwitchDataEngineImageResponse> SwitchDataEngineImage(SwitchDataEngineImageRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineImageResponse>(req, "SwitchDataEngineImage");
        }

        /// <summary>
        /// This API is used to switch the versions of the engine image.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public SwitchDataEngineImageResponse SwitchDataEngineImageSync(SwitchDataEngineImageRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineImageResponse>(req, "SwitchDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a user group from a user.
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public Task<UnbindWorkGroupsFromUserResponse> UnbindWorkGroupsFromUser(UnbindWorkGroupsFromUserRequest req)
        {
            return InternalRequestAsync<UnbindWorkGroupsFromUserResponse>(req, "UnbindWorkGroupsFromUser");
        }

        /// <summary>
        /// This API is used to unbind a user group from a user.
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public UnbindWorkGroupsFromUserResponse UnbindWorkGroupsFromUserSync(UnbindWorkGroupsFromUserRequest req)
        {
            return InternalRequestAsync<UnbindWorkGroupsFromUserResponse>(req, "UnbindWorkGroupsFromUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade data engine configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public Task<UpdateDataEngineResponse> UpdateDataEngine(UpdateDataEngineRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineResponse>(req, "UpdateDataEngine");
        }

        /// <summary>
        /// This API is used to upgrade data engine configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public UpdateDataEngineResponse UpdateDataEngineSync(UpdateDataEngineRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineResponse>(req, "UpdateDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trigger the modification of the engine configuration by the user through a certain operation.
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public Task<UpdateDataEngineConfigResponse> UpdateDataEngineConfig(UpdateDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineConfigResponse>(req, "UpdateDataEngineConfig");
        }

        /// <summary>
        /// This API is used to trigger the modification of the engine configuration by the user through a certain operation.
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public UpdateDataEngineConfigResponse UpdateDataEngineConfigSync(UpdateDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineConfigResponse>(req, "UpdateDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public Task<UpdateRowFilterResponse> UpdateRowFilter(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter");
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public UpdateRowFilterResponse UpdateRowFilterSync(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the custom configuration of the user's engine.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public Task<UpdateUserDataEngineConfigResponse> UpdateUserDataEngineConfig(UpdateUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserDataEngineConfigResponse>(req, "UpdateUserDataEngineConfig");
        }

        /// <summary>
        /// This API is used to modify the custom configuration of the user's engine.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public UpdateUserDataEngineConfigResponse UpdateUserDataEngineConfigSync(UpdateUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserDataEngineConfigResponse>(req, "UpdateUserDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the engine image.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public Task<UpgradeDataEngineImageResponse> UpgradeDataEngineImage(UpgradeDataEngineImageRequest req)
        {
            return InternalRequestAsync<UpgradeDataEngineImageResponse>(req, "UpgradeDataEngineImage");
        }

        /// <summary>
        /// This API is used to upgrade the engine image.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public UpgradeDataEngineImageResponse UpgradeDataEngineImageSync(UpgradeDataEngineImageRequest req)
        {
            return InternalRequestAsync<UpgradeDataEngineImageResponse>(req, "UpgradeDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
