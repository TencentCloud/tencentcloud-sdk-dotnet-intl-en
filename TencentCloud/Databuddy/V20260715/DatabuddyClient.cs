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

namespace TencentCloud.Databuddy.V20260715
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Databuddy.V20260715.Models;

   public class DatabuddyClient : AbstractClient{

       private const string endpoint = "databuddy.intl.tencentcloudapi.com";
       private const string version = "2026-07-15";
       private const string sdkVersion = "SDK_NET_3.0.1407";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DatabuddyClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DatabuddyClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Add a console user
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public Task<AddConsoleUsersResponse> AddConsoleUsers(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers");
        }

        /// <summary>
        /// Add a console user
        /// </summary>
        /// <param name="req"><see cref="AddConsoleUsersRequest"/></param>
        /// <returns><see cref="AddConsoleUsersResponse"/></returns>
        public AddConsoleUsersResponse AddConsoleUsersSync(AddConsoleUsersRequest req)
        {
            return InternalRequestAsync<AddConsoleUsersResponse>(req, "AddConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a user group to a workspace.
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="AddWorkspaceGroupsResponse"/></returns>
        public Task<AddWorkspaceGroupsResponse> AddWorkspaceGroups(AddWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<AddWorkspaceGroupsResponse>(req, "AddWorkspaceGroups");
        }

        /// <summary>
        /// This API is used to add a user group to a workspace.
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="AddWorkspaceGroupsResponse"/></returns>
        public AddWorkspaceGroupsResponse AddWorkspaceGroupsSync(AddWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<AddWorkspaceGroupsResponse>(req, "AddWorkspaceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create user groups.
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceUsersRequest"/></param>
        /// <returns><see cref="AddWorkspaceUsersResponse"/></returns>
        public Task<AddWorkspaceUsersResponse> AddWorkspaceUsers(AddWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<AddWorkspaceUsersResponse>(req, "AddWorkspaceUsers");
        }

        /// <summary>
        /// This API is used to create user groups.
        /// </summary>
        /// <param name="req"><see cref="AddWorkspaceUsersRequest"/></param>
        /// <returns><see cref="AddWorkspaceUsersResponse"/></returns>
        public AddWorkspaceUsersResponse AddWorkspaceUsersSync(AddWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<AddWorkspaceUsersResponse>(req, "AddWorkspaceUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data catalog.
        /// </summary>
        /// <param name="req"><see cref="CreateCatalogRequest"/></param>
        /// <returns><see cref="CreateCatalogResponse"/></returns>
        public Task<CreateCatalogResponse> CreateCatalog(CreateCatalogRequest req)
        {
            return InternalRequestAsync<CreateCatalogResponse>(req, "CreateCatalog");
        }

        /// <summary>
        /// This API is used to create a data catalog.
        /// </summary>
        /// <param name="req"><see cref="CreateCatalogRequest"/></param>
        /// <returns><see cref="CreateCatalogResponse"/></returns>
        public CreateCatalogResponse CreateCatalogSync(CreateCatalogRequest req)
        {
            return InternalRequestAsync<CreateCatalogResponse>(req, "CreateCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a console user group
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleGroupRequest"/></param>
        /// <returns><see cref="CreateConsoleGroupResponse"/></returns>
        public Task<CreateConsoleGroupResponse> CreateConsoleGroup(CreateConsoleGroupRequest req)
        {
            return InternalRequestAsync<CreateConsoleGroupResponse>(req, "CreateConsoleGroup");
        }

        /// <summary>
        /// Create a console user group
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleGroupRequest"/></param>
        /// <returns><see cref="CreateConsoleGroupResponse"/></returns>
        public CreateConsoleGroupResponse CreateConsoleGroupSync(CreateConsoleGroupRequest req)
        {
            return InternalRequestAsync<CreateConsoleGroupResponse>(req, "CreateConsoleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new file (Notebook/SQL/Python, etc.) in the workspace file tree of Studio (unified development IDE), and return the complete meta-information of the file upon success.
        /// 
        /// **Prerequisite**
        /// 1. WorkspaceId corresponds to an existent workspace, and the caller is a space member of this workspace;
        /// 2. The parent folder corresponding to ParentFolderPath must exist, and the caller must have write permission on it (pass `/` for the root directory);
        /// 3. FileName must be unique under the same parent folder, including suffix comparison.
        /// 4. The FileName suffix must be consistent with FileType (`.ipynb`↔`NOTEBOOK_FILE`, `.sql`↔`SQL_FILE`);
        /// 5. To create with file content, pass it through Storage (large files are transferred via COS, and small files are placed in Storage.Content).
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public Task<CreateFileResponse> CreateFile(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile");
        }

        /// <summary>
        /// Create a new file (Notebook/SQL/Python, etc.) in the workspace file tree of Studio (unified development IDE), and return the complete meta-information of the file upon success.
        /// 
        /// **Prerequisite**
        /// 1. WorkspaceId corresponds to an existent workspace, and the caller is a space member of this workspace;
        /// 2. The parent folder corresponding to ParentFolderPath must exist, and the caller must have write permission on it (pass `/` for the root directory);
        /// 3. FileName must be unique under the same parent folder, including suffix comparison.
        /// 4. The FileName suffix must be consistent with FileType (`.ipynb`↔`NOTEBOOK_FILE`, `.sql`↔`SQL_FILE`);
        /// 5. To create with file content, pass it through Storage (large files are transferred via COS, and small files are placed in Storage.Content).
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public CreateFileResponse CreateFileSync(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public Task<CreateFolderResponse> CreateFolder(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder");
        }

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <param name="req"><see cref="CreateFolderRequest"/></param>
        /// <returns><see cref="CreateFolderResponse"/></returns>
        public CreateFolderResponse CreateFolderSync(CreateFolderRequest req)
        {
            return InternalRequestAsync<CreateFolderResponse>(req, "CreateFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <param name="req"><see cref="CreateSchemaRequest"/></param>
        /// <returns><see cref="CreateSchemaResponse"/></returns>
        public Task<CreateSchemaResponse> CreateSchema(CreateSchemaRequest req)
        {
            return InternalRequestAsync<CreateSchemaResponse>(req, "CreateSchema");
        }

        /// <summary>
        /// Create a schema
        /// </summary>
        /// <param name="req"><see cref="CreateSchemaRequest"/></param>
        /// <returns><see cref="CreateSchemaResponse"/></returns>
        public CreateSchemaResponse CreateSchemaSync(CreateSchemaRequest req)
        {
            return InternalRequestAsync<CreateSchemaResponse>(req, "CreateSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a workflow
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow");
        }

        /// <summary>
        /// Create a workflow
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
            return InternalRequestAsync<CreateWorkflowResponse>(req, "CreateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a workspace.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public Task<CreateWorkspaceResponse> CreateWorkspace(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace");
        }

        /// <summary>
        /// This API is used to create a workspace.
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRequest"/></param>
        /// <returns><see cref="CreateWorkspaceResponse"/></returns>
        public CreateWorkspaceResponse CreateWorkspaceSync(CreateWorkspaceRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceResponse>(req, "CreateWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a workspace role
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="CreateWorkspaceRoleResponse"/></returns>
        public Task<CreateWorkspaceRoleResponse> CreateWorkspaceRole(CreateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceRoleResponse>(req, "CreateWorkspaceRole");
        }

        /// <summary>
        /// Creates a workspace role
        /// </summary>
        /// <param name="req"><see cref="CreateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="CreateWorkspaceRoleResponse"/></returns>
        public CreateWorkspaceRoleResponse CreateWorkspaceRoleSync(CreateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<CreateWorkspaceRoleResponse>(req, "CreateWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a catalog.
        /// </summary>
        /// <param name="req"><see cref="DeleteCatalogRequest"/></param>
        /// <returns><see cref="DeleteCatalogResponse"/></returns>
        public Task<DeleteCatalogResponse> DeleteCatalog(DeleteCatalogRequest req)
        {
            return InternalRequestAsync<DeleteCatalogResponse>(req, "DeleteCatalog");
        }

        /// <summary>
        /// Delete a catalog.
        /// </summary>
        /// <param name="req"><see cref="DeleteCatalogRequest"/></param>
        /// <returns><see cref="DeleteCatalogResponse"/></returns>
        public DeleteCatalogResponse DeleteCatalogSync(DeleteCatalogRequest req)
        {
            return InternalRequestAsync<DeleteCatalogResponse>(req, "DeleteCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a console user group
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleGroupsRequest"/></param>
        /// <returns><see cref="DeleteConsoleGroupsResponse"/></returns>
        public Task<DeleteConsoleGroupsResponse> DeleteConsoleGroups(DeleteConsoleGroupsRequest req)
        {
            return InternalRequestAsync<DeleteConsoleGroupsResponse>(req, "DeleteConsoleGroups");
        }

        /// <summary>
        /// Delete a console user group
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleGroupsRequest"/></param>
        /// <returns><see cref="DeleteConsoleGroupsResponse"/></returns>
        public DeleteConsoleGroupsResponse DeleteConsoleGroupsSync(DeleteConsoleGroupsRequest req)
        {
            return InternalRequestAsync<DeleteConsoleGroupsResponse>(req, "DeleteConsoleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Move the file to Recycle Bin (soft deletion) and clear its version history and execution result snapshots.
        /// 
        /// **Prerequisite**
        /// 1. The file corresponding to FileId must exist and be in active status;
        /// 2. The caller has permission to delete the file;
        /// 3. The file hasn't been referenced by a workflow task.
        /// 
        /// **Error codes (Module are all `Studio`)**
        /// 
        /// | Error Code (Code) | InnerCode | Description | Handling Suggestion |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | lack of FileId | Please import FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value not supported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | Please confirm the FileId |
        /// | `ResourceInUse.FileReferencedByTask` | 1030204 | The file is referenced by a workflow task and cannot be deleted. | Disassociate the task reference first. |
        /// | `UnauthorizedOperation.FileDeleteDenied` | 1030303 | No deletion permission for this file | Contact the file owner or space admin for authorization |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public Task<DeleteFileResponse> DeleteFile(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile");
        }

        /// <summary>
        /// Move the file to Recycle Bin (soft deletion) and clear its version history and execution result snapshots.
        /// 
        /// **Prerequisite**
        /// 1. The file corresponding to FileId must exist and be in active status;
        /// 2. The caller has permission to delete the file;
        /// 3. The file hasn't been referenced by a workflow task.
        /// 
        /// **Error codes (Module are all `Studio`)**
        /// 
        /// | Error Code (Code) | InnerCode | Description | Handling Suggestion |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | lack of FileId | Please import FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value not supported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | Please confirm the FileId |
        /// | `ResourceInUse.FileReferencedByTask` | 1030204 | The file is referenced by a workflow task and cannot be deleted. | Disassociate the task reference first. |
        /// | `UnauthorizedOperation.FileDeleteDenied` | 1030303 | No deletion permission for this file | Contact the file owner or space admin for authorization |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="DeleteFileRequest"/></param>
        /// <returns><see cref="DeleteFileResponse"/></returns>
        public DeleteFileResponse DeleteFileSync(DeleteFileRequest req)
        {
            return InternalRequestAsync<DeleteFileResponse>(req, "DeleteFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder");
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <param name="req"><see cref="DeleteFolderRequest"/></param>
        /// <returns><see cref="DeleteFolderResponse"/></returns>
        public DeleteFolderResponse DeleteFolderSync(DeleteFolderRequest req)
        {
            return InternalRequestAsync<DeleteFolderResponse>(req, "DeleteFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete schema
        /// </summary>
        /// <param name="req"><see cref="DeleteSchemaRequest"/></param>
        /// <returns><see cref="DeleteSchemaResponse"/></returns>
        public Task<DeleteSchemaResponse> DeleteSchema(DeleteSchemaRequest req)
        {
            return InternalRequestAsync<DeleteSchemaResponse>(req, "DeleteSchema");
        }

        /// <summary>
        /// Delete schema
        /// </summary>
        /// <param name="req"><see cref="DeleteSchemaRequest"/></param>
        /// <returns><see cref="DeleteSchemaResponse"/></returns>
        public DeleteSchemaResponse DeleteSchemaSync(DeleteSchemaRequest req)
        {
            return InternalRequestAsync<DeleteSchemaResponse>(req, "DeleteSchema")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes a workflow
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow");
        }

        /// <summary>
        /// Deletes a workflow
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
            return InternalRequestAsync<DeleteWorkflowResponse>(req, "DeleteWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a workspace.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceResponse"/></returns>
        public Task<DeleteWorkspaceResponse> DeleteWorkspace(DeleteWorkspaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceResponse>(req, "DeleteWorkspace");
        }

        /// <summary>
        /// Delete a workspace.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceResponse"/></returns>
        public DeleteWorkspaceResponse DeleteWorkspaceSync(DeleteWorkspaceRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceResponse>(req, "DeleteWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a workspace role.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRoleRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceRoleResponse"/></returns>
        public Task<DeleteWorkspaceRoleResponse> DeleteWorkspaceRole(DeleteWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceRoleResponse>(req, "DeleteWorkspaceRole");
        }

        /// <summary>
        /// Delete a workspace role.
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkspaceRoleRequest"/></param>
        /// <returns><see cref="DeleteWorkspaceRoleResponse"/></returns>
        public DeleteWorkspaceRoleResponse DeleteWorkspaceRoleSync(DeleteWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<DeleteWorkspaceRoleResponse>(req, "DeleteWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query catalog description
        /// </summary>
        /// <param name="req"><see cref="GetCatalogRequest"/></param>
        /// <returns><see cref="GetCatalogResponse"/></returns>
        public Task<GetCatalogResponse> GetCatalog(GetCatalogRequest req)
        {
            return InternalRequestAsync<GetCatalogResponse>(req, "GetCatalog");
        }

        /// <summary>
        /// Query catalog description
        /// </summary>
        /// <param name="req"><see cref="GetCatalogRequest"/></param>
        /// <returns><see cref="GetCatalogResponse"/></returns>
        public GetCatalogResponse GetCatalogSync(GetCatalogRequest req)
        {
            return InternalRequestAsync<GetCatalogResponse>(req, "GetCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the file's metadata, optionally including file content, and read historical snapshots by version.
        /// 
        /// **Prerequisite**
        /// 1. Pass at least one of FileId and FilePath. If both are passed, FileId takes precedence.
        /// 2. The corresponding file must exist, and the caller must have read permission for the file;
        /// 3. If VersionId is passed, the version must exist.
        /// 
        /// **Error codes (Module: `Studio`)**
        /// 
        /// | Error Code | Inner Code | Description | Handling Suggestion |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | Lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | FileId and FilePath cannot be empty at the same time | Pass at least one of FileId and FilePath |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value unsupported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | Confirm the FileId or FilePath |
        /// | `ResourceNotFound.FileVersionNotFound` | 1030205 | The specified file version does not exist | Confirm the VersionId or call ListFileVersions to retrieve |
        /// | `UnauthorizedOperation.FileReadDenied` | 1030304 | No read permission for this file | Contact the file owner or space admin for authorization |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="GetFileRequest"/></param>
        /// <returns><see cref="GetFileResponse"/></returns>
        public Task<GetFileResponse> GetFile(GetFileRequest req)
        {
            return InternalRequestAsync<GetFileResponse>(req, "GetFile");
        }

        /// <summary>
        /// Get the file's metadata, optionally including file content, and read historical snapshots by version.
        /// 
        /// **Prerequisite**
        /// 1. Pass at least one of FileId and FilePath. If both are passed, FileId takes precedence.
        /// 2. The corresponding file must exist, and the caller must have read permission for the file;
        /// 3. If VersionId is passed, the version must exist.
        /// 
        /// **Error codes (Module: `Studio`)**
        /// 
        /// | Error Code | Inner Code | Description | Handling Suggestion |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | Lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | FileId and FilePath cannot be empty at the same time | Pass at least one of FileId and FilePath |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value unsupported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | Confirm the FileId or FilePath |
        /// | `ResourceNotFound.FileVersionNotFound` | 1030205 | The specified file version does not exist | Confirm the VersionId or call ListFileVersions to retrieve |
        /// | `UnauthorizedOperation.FileReadDenied` | 1030304 | No read permission for this file | Contact the file owner or space admin for authorization |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="GetFileRequest"/></param>
        /// <returns><see cref="GetFileResponse"/></returns>
        public GetFileResponse GetFileSync(GetFileRequest req)
        {
            return InternalRequestAsync<GetFileResponse>(req, "GetFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get folder details.
        /// </summary>
        /// <param name="req"><see cref="GetFolderRequest"/></param>
        /// <returns><see cref="GetFolderResponse"/></returns>
        public Task<GetFolderResponse> GetFolder(GetFolderRequest req)
        {
            return InternalRequestAsync<GetFolderResponse>(req, "GetFolder");
        }

        /// <summary>
        /// Get folder details.
        /// </summary>
        /// <param name="req"><see cref="GetFolderRequest"/></param>
        /// <returns><see cref="GetFolderResponse"/></returns>
        public GetFolderResponse GetFolderSync(GetFolderRequest req)
        {
            return InternalRequestAsync<GetFolderResponse>(req, "GetFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query workflow details.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public Task<GetWorkflowResponse> GetWorkflow(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow");
        }

        /// <summary>
        /// This API is used to query workflow details.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRequest"/></param>
        /// <returns><see cref="GetWorkflowResponse"/></returns>
        public GetWorkflowResponse GetWorkflowSync(GetWorkflowRequest req)
        {
            return InternalRequestAsync<GetWorkflowResponse>(req, "GetWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries workflow running details.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRunRequest"/></param>
        /// <returns><see cref="GetWorkflowRunResponse"/></returns>
        public Task<GetWorkflowRunResponse> GetWorkflowRun(GetWorkflowRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowRunResponse>(req, "GetWorkflowRun");
        }

        /// <summary>
        /// Queries workflow running details.
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowRunRequest"/></param>
        /// <returns><see cref="GetWorkflowRunResponse"/></returns>
        public GetWorkflowRunResponse GetWorkflowRunSync(GetWorkflowRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowRunResponse>(req, "GetWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query task execution details
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowTaskRunRequest"/></param>
        /// <returns><see cref="GetWorkflowTaskRunResponse"/></returns>
        public Task<GetWorkflowTaskRunResponse> GetWorkflowTaskRun(GetWorkflowTaskRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowTaskRunResponse>(req, "GetWorkflowTaskRun");
        }

        /// <summary>
        /// Query task execution details
        /// </summary>
        /// <param name="req"><see cref="GetWorkflowTaskRunRequest"/></param>
        /// <returns><see cref="GetWorkflowTaskRunResponse"/></returns>
        public GetWorkflowTaskRunResponse GetWorkflowTaskRunSync(GetWorkflowTaskRunRequest req)
        {
            return InternalRequestAsync<GetWorkflowTaskRunResponse>(req, "GetWorkflowTaskRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the details of a workspace.
        /// </summary>
        /// <param name="req"><see cref="GetWorkspaceRequest"/></param>
        /// <returns><see cref="GetWorkspaceResponse"/></returns>
        public Task<GetWorkspaceResponse> GetWorkspace(GetWorkspaceRequest req)
        {
            return InternalRequestAsync<GetWorkspaceResponse>(req, "GetWorkspace");
        }

        /// <summary>
        /// Queries the details of a workspace.
        /// </summary>
        /// <param name="req"><see cref="GetWorkspaceRequest"/></param>
        /// <returns><see cref="GetWorkspaceResponse"/></returns>
        public GetWorkspaceResponse GetWorkspaceSync(GetWorkspaceRequest req)
        {
            return InternalRequestAsync<GetWorkspaceResponse>(req, "GetWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Terminate the operation of a workflow.
        /// </summary>
        /// <param name="req"><see cref="KillWorkflowRunRequest"/></param>
        /// <returns><see cref="KillWorkflowRunResponse"/></returns>
        public Task<KillWorkflowRunResponse> KillWorkflowRun(KillWorkflowRunRequest req)
        {
            return InternalRequestAsync<KillWorkflowRunResponse>(req, "KillWorkflowRun");
        }

        /// <summary>
        /// Terminate the operation of a workflow.
        /// </summary>
        /// <param name="req"><see cref="KillWorkflowRunRequest"/></param>
        /// <returns><see cref="KillWorkflowRunResponse"/></returns>
        public KillWorkflowRunResponse KillWorkflowRunSync(KillWorkflowRunRequest req)
        {
            return InternalRequestAsync<KillWorkflowRunResponse>(req, "KillWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Pagination fetch data catalog list
        /// </summary>
        /// <param name="req"><see cref="ListCatalogsRequest"/></param>
        /// <returns><see cref="ListCatalogsResponse"/></returns>
        public Task<ListCatalogsResponse> ListCatalogs(ListCatalogsRequest req)
        {
            return InternalRequestAsync<ListCatalogsResponse>(req, "ListCatalogs");
        }

        /// <summary>
        /// Pagination fetch data catalog list
        /// </summary>
        /// <param name="req"><see cref="ListCatalogsRequest"/></param>
        /// <returns><see cref="ListCatalogsResponse"/></returns>
        public ListCatalogsResponse ListCatalogsSync(ListCatalogsRequest req)
        {
            return InternalRequestAsync<ListCatalogsResponse>(req, "ListCatalogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the console user group member list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public Task<ListConsoleGroupUsersResponse> ListConsoleGroupUsers(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers");
        }

        /// <summary>
        /// Queries the console user group member list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupUsersRequest"/></param>
        /// <returns><see cref="ListConsoleGroupUsersResponse"/></returns>
        public ListConsoleGroupUsersResponse ListConsoleGroupUsersSync(ListConsoleGroupUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupUsersResponse>(req, "ListConsoleGroupUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the console user group list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public Task<ListConsoleGroupsResponse> ListConsoleGroups(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups");
        }

        /// <summary>
        /// Queries the console user group list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleGroupsRequest"/></param>
        /// <returns><see cref="ListConsoleGroupsResponse"/></returns>
        public ListConsoleGroupsResponse ListConsoleGroupsSync(ListConsoleGroupsRequest req)
        {
            return InternalRequestAsync<ListConsoleGroupsResponse>(req, "ListConsoleGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the console role list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public Task<ListConsoleRolesResponse> ListConsoleRoles(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles");
        }

        /// <summary>
        /// Queries the console role list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleRolesRequest"/></param>
        /// <returns><see cref="ListConsoleRolesResponse"/></returns>
        public ListConsoleRolesResponse ListConsoleRolesSync(ListConsoleRolesRequest req)
        {
            return InternalRequestAsync<ListConsoleRolesResponse>(req, "ListConsoleRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the console user list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public Task<ListConsoleUsersResponse> ListConsoleUsers(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers");
        }

        /// <summary>
        /// Queries the console user list. This API is a console-level API and is only supported in the central region: use ap-guangzhou for the Chinese site and ap-singapore for the international site. Calls from other regions will return UnsupportedRegion.
        /// </summary>
        /// <param name="req"><see cref="ListConsoleUsersRequest"/></param>
        /// <returns><see cref="ListConsoleUsersResponse"/></returns>
        public ListConsoleUsersResponse ListConsoleUsersSync(ListConsoleUsersRequest req)
        {
            return InternalRequestAsync<ListConsoleUsersResponse>(req, "ListConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the folder and file list
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public Task<ListFilesResponse> ListFiles(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles");
        }

        /// <summary>
        /// Get the folder and file list
        /// </summary>
        /// <param name="req"><see cref="ListFilesRequest"/></param>
        /// <returns><see cref="ListFilesResponse"/></returns>
        public ListFilesResponse ListFilesSync(ListFilesRequest req)
        {
            return InternalRequestAsync<ListFilesResponse>(req, "ListFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get schema list
        /// </summary>
        /// <param name="req"><see cref="ListSchemasRequest"/></param>
        /// <returns><see cref="ListSchemasResponse"/></returns>
        public Task<ListSchemasResponse> ListSchemas(ListSchemasRequest req)
        {
            return InternalRequestAsync<ListSchemasResponse>(req, "ListSchemas");
        }

        /// <summary>
        /// Get schema list
        /// </summary>
        /// <param name="req"><see cref="ListSchemasRequest"/></param>
        /// <returns><see cref="ListSchemasResponse"/></returns>
        public ListSchemasResponse ListSchemasSync(ListSchemasRequest req)
        {
            return InternalRequestAsync<ListSchemasResponse>(req, "ListSchemas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Workflow run list
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowRunsResponse"/></returns>
        public Task<ListWorkflowRunsResponse> ListWorkflowRuns(ListWorkflowRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowRunsResponse>(req, "ListWorkflowRuns");
        }

        /// <summary>
        /// Workflow run list
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowRunsResponse"/></returns>
        public ListWorkflowRunsResponse ListWorkflowRunsSync(ListWorkflowRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowRunsResponse>(req, "ListWorkflowRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the historical operation list of workflow tasks
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowTaskRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowTaskRunsResponse"/></returns>
        public Task<ListWorkflowTaskRunsResponse> ListWorkflowTaskRuns(ListWorkflowTaskRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowTaskRunsResponse>(req, "ListWorkflowTaskRuns");
        }

        /// <summary>
        /// Query the historical operation list of workflow tasks
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowTaskRunsRequest"/></param>
        /// <returns><see cref="ListWorkflowTaskRunsResponse"/></returns>
        public ListWorkflowTaskRunsResponse ListWorkflowTaskRunsSync(ListWorkflowTaskRunsRequest req)
        {
            return InternalRequestAsync<ListWorkflowTaskRunsResponse>(req, "ListWorkflowTaskRuns")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of workflows.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public Task<ListWorkflowsResponse> ListWorkflows(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows");
        }

        /// <summary>
        /// This API is used to query the list of workflows.
        /// </summary>
        /// <param name="req"><see cref="ListWorkflowsRequest"/></param>
        /// <returns><see cref="ListWorkflowsResponse"/></returns>
        public ListWorkflowsResponse ListWorkflowsSync(ListWorkflowsRequest req)
        {
            return InternalRequestAsync<ListWorkflowsResponse>(req, "ListWorkflows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of user groups in a workspace.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupsResponse"/></returns>
        public Task<ListWorkspaceGroupsResponse> ListWorkspaceGroups(ListWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupsResponse>(req, "ListWorkspaceGroups");
        }

        /// <summary>
        /// This API is used to query the list of user groups in a workspace.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="ListWorkspaceGroupsResponse"/></returns>
        public ListWorkspaceGroupsResponse ListWorkspaceGroupsSync(ListWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<ListWorkspaceGroupsResponse>(req, "ListWorkspaceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the list of users in a workspace.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceUsersResponse"/></returns>
        public Task<ListWorkspaceUsersResponse> ListWorkspaceUsers(ListWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceUsersResponse>(req, "ListWorkspaceUsers");
        }

        /// <summary>
        /// Queries the list of users in a workspace.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspaceUsersRequest"/></param>
        /// <returns><see cref="ListWorkspaceUsersResponse"/></returns>
        public ListWorkspaceUsersResponse ListWorkspaceUsersSync(ListWorkspaceUsersRequest req)
        {
            return InternalRequestAsync<ListWorkspaceUsersResponse>(req, "ListWorkspaceUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the workspace list.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspacesRequest"/></param>
        /// <returns><see cref="ListWorkspacesResponse"/></returns>
        public Task<ListWorkspacesResponse> ListWorkspaces(ListWorkspacesRequest req)
        {
            return InternalRequestAsync<ListWorkspacesResponse>(req, "ListWorkspaces");
        }

        /// <summary>
        /// Queries the workspace list.
        /// </summary>
        /// <param name="req"><see cref="ListWorkspacesRequest"/></param>
        /// <returns><see cref="ListWorkspacesResponse"/></returns>
        public ListWorkspacesResponse ListWorkspacesSync(ListWorkspacesRequest req)
        {
            return InternalRequestAsync<ListWorkspacesResponse>(req, "ListWorkspaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <p>Batch remove console users (up to 10 at a time; pre-verification rejects the entire request if any fails; during the Execution Phase, a single failure does not interrupt subsequent deletion, and success or failure is determined by SuccessUins/FailItems)</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public Task<RemoveConsoleUsersResponse> RemoveConsoleUsers(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers");
        }

        /// <summary>
        /// <p>Batch remove console users (up to 10 at a time; pre-verification rejects the entire request if any fails; during the Execution Phase, a single failure does not interrupt subsequent deletion, and success or failure is determined by SuccessUins/FailItems)</p>
        /// </summary>
        /// <param name="req"><see cref="RemoveConsoleUsersRequest"/></param>
        /// <returns><see cref="RemoveConsoleUsersResponse"/></returns>
        public RemoveConsoleUsersResponse RemoveConsoleUsersSync(RemoveConsoleUsersRequest req)
        {
            return InternalRequestAsync<RemoveConsoleUsersResponse>(req, "RemoveConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Remove a user group from a workspace.
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceGroupsResponse"/></returns>
        public Task<RemoveWorkspaceGroupsResponse> RemoveWorkspaceGroups(RemoveWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceGroupsResponse>(req, "RemoveWorkspaceGroups");
        }

        /// <summary>
        /// Remove a user group from a workspace.
        /// </summary>
        /// <param name="req"><see cref="RemoveWorkspaceGroupsRequest"/></param>
        /// <returns><see cref="RemoveWorkspaceGroupsResponse"/></returns>
        public RemoveWorkspaceGroupsResponse RemoveWorkspaceGroupsSync(RemoveWorkspaceGroupsRequest req)
        {
            return InternalRequestAsync<RemoveWorkspaceGroupsResponse>(req, "RemoveWorkspaceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rerun a workflow
        /// </summary>
        /// <param name="req"><see cref="RerunWorkflowRunRequest"/></param>
        /// <returns><see cref="RerunWorkflowRunResponse"/></returns>
        public Task<RerunWorkflowRunResponse> RerunWorkflowRun(RerunWorkflowRunRequest req)
        {
            return InternalRequestAsync<RerunWorkflowRunResponse>(req, "RerunWorkflowRun");
        }

        /// <summary>
        /// Rerun a workflow
        /// </summary>
        /// <param name="req"><see cref="RerunWorkflowRunRequest"/></param>
        /// <returns><see cref="RerunWorkflowRunResponse"/></returns>
        public RerunWorkflowRunResponse RerunWorkflowRunSync(RerunWorkflowRunRequest req)
        {
            return InternalRequestAsync<RerunWorkflowRunResponse>(req, "RerunWorkflowRun")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Runs the workflow
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public Task<RunWorkflowResponse> RunWorkflow(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow");
        }

        /// <summary>
        /// Runs the workflow
        /// </summary>
        /// <param name="req"><see cref="RunWorkflowRequest"/></param>
        /// <returns><see cref="RunWorkflowResponse"/></returns>
        public RunWorkflowResponse RunWorkflowSync(RunWorkflowRequest req)
        {
            return InternalRequestAsync<RunWorkflowResponse>(req, "RunWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Start up the computational resource.
        /// </summary>
        /// <param name="req"><see cref="StartComputeRequest"/></param>
        /// <returns><see cref="StartComputeResponse"/></returns>
        public Task<StartComputeResponse> StartCompute(StartComputeRequest req)
        {
            return InternalRequestAsync<StartComputeResponse>(req, "StartCompute");
        }

        /// <summary>
        /// Start up the computational resource.
        /// </summary>
        /// <param name="req"><see cref="StartComputeRequest"/></param>
        /// <returns><see cref="StartComputeResponse"/></returns>
        public StartComputeResponse StartComputeSync(StartComputeRequest req)
        {
            return InternalRequestAsync<StartComputeResponse>(req, "StartCompute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Terminate computational resources
        /// </summary>
        /// <param name="req"><see cref="StopComputeRequest"/></param>
        /// <returns><see cref="StopComputeResponse"/></returns>
        public Task<StopComputeResponse> StopCompute(StopComputeRequest req)
        {
            return InternalRequestAsync<StopComputeResponse>(req, "StopCompute");
        }

        /// <summary>
        /// Terminate computational resources
        /// </summary>
        /// <param name="req"><see cref="StopComputeRequest"/></param>
        /// <returns><see cref="StopComputeResponse"/></returns>
        public StopComputeResponse StopComputeSync(StopComputeRequest req)
        {
            return InternalRequestAsync<StopComputeResponse>(req, "StopCompute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unbind workflow Bundle info
        /// Description: This interface is semantically equivalent to Detach in the standard verb list. The name Unbind is retained for compatibility with existing product forms.
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkflowBundleRequest"/></param>
        /// <returns><see cref="UnbindWorkflowBundleResponse"/></returns>
        public Task<UnbindWorkflowBundleResponse> UnbindWorkflowBundle(UnbindWorkflowBundleRequest req)
        {
            return InternalRequestAsync<UnbindWorkflowBundleResponse>(req, "UnbindWorkflowBundle");
        }

        /// <summary>
        /// Unbind workflow Bundle info
        /// Description: This interface is semantically equivalent to Detach in the standard verb list. The name Unbind is retained for compatibility with existing product forms.
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkflowBundleRequest"/></param>
        /// <returns><see cref="UnbindWorkflowBundleResponse"/></returns>
        public UnbindWorkflowBundleResponse UnbindWorkflowBundleSync(UnbindWorkflowBundleRequest req)
        {
            return InternalRequestAsync<UnbindWorkflowBundleResponse>(req, "UnbindWorkflowBundle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a console user group
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public Task<UpdateConsoleGroupResponse> UpdateConsoleGroup(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup");
        }

        /// <summary>
        /// Modify a console user group
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleGroupRequest"/></param>
        /// <returns><see cref="UpdateConsoleGroupResponse"/></returns>
        public UpdateConsoleGroupResponse UpdateConsoleGroupSync(UpdateConsoleGroupRequest req)
        {
            return InternalRequestAsync<UpdateConsoleGroupResponse>(req, "UpdateConsoleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a console user role
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleUsersRequest"/></param>
        /// <returns><see cref="UpdateConsoleUsersResponse"/></returns>
        public Task<UpdateConsoleUsersResponse> UpdateConsoleUsers(UpdateConsoleUsersRequest req)
        {
            return InternalRequestAsync<UpdateConsoleUsersResponse>(req, "UpdateConsoleUsers");
        }

        /// <summary>
        /// Modify a console user role
        /// </summary>
        /// <param name="req"><see cref="UpdateConsoleUsersRequest"/></param>
        /// <returns><see cref="UpdateConsoleUsersResponse"/></returns>
        public UpdateConsoleUsersResponse UpdateConsoleUsersSync(UpdateConsoleUsersRequest req)
        {
            return InternalRequestAsync<UpdateConsoleUsersResponse>(req, "UpdateConsoleUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update file contents and running configuration (computational resource, default catalog/schema, parameters), and return the file metadata after the update.
        /// 
        /// **Prerequisite**
        /// 1. The file corresponding to FileId must exist and be in active status;
        /// 2. The caller has write permission on the file;
        /// 3. To update only the configuration, do not pass in Storage. To update only the content, do not pass in FileConfig.
        /// 4. If FileConfig.ResourceId is not empty, the match between the resource type and file type will be validated.
        /// 
        /// **Error codes (Module: `Studio`)**
        /// 
        /// | Error Code (Code) | InnerCode | Description | Handling Suggestions |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | lack of FileId | Please import FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value not supported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `InvalidParameterValue.ResourceId` | 1030104 | Compute resource type and file type mismatch | Select a computational resource for Python/Notebook and a data analysis resource for SQL |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | confirm the FileId or call GetFile to check the file status |
        /// | `UnauthorizedOperation.FileWriteDenied` | 1030302 | No write permission for this file | Contact the file owner or space admin for authorization |
        /// | `FailedOperation.FileStorageUpdateFailed` | 1030401 | Failed to write file content to storage | Try again later. If the failure persists, contact support with the RequestId. |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="UpdateFileRequest"/></param>
        /// <returns><see cref="UpdateFileResponse"/></returns>
        public Task<UpdateFileResponse> UpdateFile(UpdateFileRequest req)
        {
            return InternalRequestAsync<UpdateFileResponse>(req, "UpdateFile");
        }

        /// <summary>
        /// Update file contents and running configuration (computational resource, default catalog/schema, parameters), and return the file metadata after the update.
        /// 
        /// **Prerequisite**
        /// 1. The file corresponding to FileId must exist and be in active status;
        /// 2. The caller has write permission on the file;
        /// 3. To update only the configuration, do not pass in Storage. To update only the content, do not pass in FileConfig.
        /// 4. If FileConfig.ResourceId is not empty, the match between the resource type and file type will be validated.
        /// 
        /// **Error codes (Module: `Studio`)**
        /// 
        /// | Error Code (Code) | InnerCode | Description | Handling Suggestions |
        /// | --- | --- | --- | --- |
        /// | `MissingParameter.WorkspaceId` | 1030001 | lack of WorkspaceId | Please input WorkspaceId |
        /// | `MissingParameter.FileId` | 1030003 | lack of FileId | Please import FileId |
        /// | `InvalidParameterValue.FileType` | 1030102 | FileType value not supported | FileType takes FILE/NOTEBOOK_FILE/SQL_FILE |
        /// | `InvalidParameterValue.ResourceId` | 1030104 | Compute resource type and file type mismatch | Select a computational resource for Python/Notebook and a data analysis resource for SQL |
        /// | `ResourceNotFound.FileNotFound` | 1030203 | File does not exist or has been deleted | confirm the FileId or call GetFile to check the file status |
        /// | `UnauthorizedOperation.FileWriteDenied` | 1030302 | No write permission for this file | Contact the file owner or space admin for authorization |
        /// | `FailedOperation.FileStorageUpdateFailed` | 1030401 | Failed to write file content to storage | Try again later. If the failure persists, contact support with the RequestId. |
        /// | `InternalError` | 1030900 | Internal service error | Please carry the RequestId and contact support |
        /// </summary>
        /// <param name="req"><see cref="UpdateFileRequest"/></param>
        /// <returns><see cref="UpdateFileResponse"/></returns>
        public UpdateFileResponse UpdateFileSync(UpdateFileRequest req)
        {
            return InternalRequestAsync<UpdateFileResponse>(req, "UpdateFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update folder (supports rename and move)
        /// </summary>
        /// <param name="req"><see cref="UpdateFolderRequest"/></param>
        /// <returns><see cref="UpdateFolderResponse"/></returns>
        public Task<UpdateFolderResponse> UpdateFolder(UpdateFolderRequest req)
        {
            return InternalRequestAsync<UpdateFolderResponse>(req, "UpdateFolder");
        }

        /// <summary>
        /// Update folder (supports rename and move)
        /// </summary>
        /// <param name="req"><see cref="UpdateFolderRequest"/></param>
        /// <returns><see cref="UpdateFolderResponse"/></returns>
        public UpdateFolderResponse UpdateFolderSync(UpdateFolderRequest req)
        {
            return InternalRequestAsync<UpdateFolderResponse>(req, "UpdateFolder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updating a Workflow
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public Task<UpdateWorkflowResponse> UpdateWorkflow(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow");
        }

        /// <summary>
        /// Updating a Workflow
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkflowRequest"/></param>
        /// <returns><see cref="UpdateWorkflowResponse"/></returns>
        public UpdateWorkflowResponse UpdateWorkflowSync(UpdateWorkflowRequest req)
        {
            return InternalRequestAsync<UpdateWorkflowResponse>(req, "UpdateWorkflow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies a workspace
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceResponse"/></returns>
        public Task<UpdateWorkspaceResponse> UpdateWorkspace(UpdateWorkspaceRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceResponse>(req, "UpdateWorkspace");
        }

        /// <summary>
        /// Modifies a workspace
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceResponse"/></returns>
        public UpdateWorkspaceResponse UpdateWorkspaceSync(UpdateWorkspaceRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceResponse>(req, "UpdateWorkspace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates a workspace role
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceRoleResponse"/></returns>
        public Task<UpdateWorkspaceRoleResponse> UpdateWorkspaceRole(UpdateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceRoleResponse>(req, "UpdateWorkspaceRole");
        }

        /// <summary>
        /// Updates a workspace role
        /// </summary>
        /// <param name="req"><see cref="UpdateWorkspaceRoleRequest"/></param>
        /// <returns><see cref="UpdateWorkspaceRoleResponse"/></returns>
        public UpdateWorkspaceRoleResponse UpdateWorkspaceRoleSync(UpdateWorkspaceRoleRequest req)
        {
            return InternalRequestAsync<UpdateWorkspaceRoleResponse>(req, "UpdateWorkspaceRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
