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

namespace TencentCloud.Bi.V20220105
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bi.V20220105.Models;

   public class BiClient : AbstractClient{

       private const string endpoint = "bi.intl.tencentcloudapi.com";
       private const string version = "2022-01-05";
       private const string sdkVersion = "SDK_NET_3.0.1196";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to extend the available time of a token with strong authentication.
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public Task<ApplyEmbedIntervalResponse> ApplyEmbedInterval(ApplyEmbedIntervalRequest req)
        {
            return InternalRequestAsync<ApplyEmbedIntervalResponse>(req, "ApplyEmbedInterval");
        }

        /// <summary>
        /// This API is used to extend the available time of a token with strong authentication.
        /// </summary>
        /// <param name="req"><see cref="ApplyEmbedIntervalRequest"/></param>
        /// <returns><see cref="ApplyEmbedIntervalResponse"/></returns>
        public ApplyEmbedIntervalResponse ApplyEmbedIntervalSync(ApplyEmbedIntervalRequest req)
        {
            return InternalRequestAsync<ApplyEmbedIntervalResponse>(req, "ApplyEmbedInterval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data source.
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public Task<CreateDatasourceResponse> CreateDatasource(CreateDatasourceRequest req)
        {
            return InternalRequestAsync<CreateDatasourceResponse>(req, "CreateDatasource");
        }

        /// <summary>
        /// This API is used to create a data source.
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceRequest"/></param>
        /// <returns><see cref="CreateDatasourceResponse"/></returns>
        public CreateDatasourceResponse CreateDatasourceSync(CreateDatasourceRequest req)
        {
            return InternalRequestAsync<CreateDatasourceResponse>(req, "CreateDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud database.
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public Task<CreateDatasourceCloudResponse> CreateDatasourceCloud(CreateDatasourceCloudRequest req)
        {
            return InternalRequestAsync<CreateDatasourceCloudResponse>(req, "CreateDatasourceCloud");
        }

        /// <summary>
        /// This API is used to create a cloud database.
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceCloudRequest"/></param>
        /// <returns><see cref="CreateDatasourceCloudResponse"/></returns>
        public CreateDatasourceCloudResponse CreateDatasourceCloudSync(CreateDatasourceCloudRequest req)
        {
            return InternalRequestAsync<CreateDatasourceCloudResponse>(req, "CreateDatasourceCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an embedded report with strong authentication.
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public Task<CreateEmbedTokenResponse> CreateEmbedToken(CreateEmbedTokenRequest req)
        {
            return InternalRequestAsync<CreateEmbedTokenResponse>(req, "CreateEmbedToken");
        }

        /// <summary>
        /// This API is used to create an embedded report with strong authentication.
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedTokenRequest"/></param>
        /// <returns><see cref="CreateEmbedTokenResponse"/></returns>
        public CreateEmbedTokenResponse CreateEmbedTokenSync(CreateEmbedTokenRequest req)
        {
            return InternalRequestAsync<CreateEmbedTokenResponse>(req, "CreateEmbedToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a project.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// This API is used to create a project.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user role.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole");
        }

        /// <summary>
        /// This API is used to create a user role.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public CreateUserRoleResponse CreateUserRoleSync(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user role in the project.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public Task<CreateUserRoleProjectResponse> CreateUserRoleProject(CreateUserRoleProjectRequest req)
        {
            return InternalRequestAsync<CreateUserRoleProjectResponse>(req, "CreateUserRoleProject");
        }

        /// <summary>
        /// This API is used to create a user role in the project.
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleProjectRequest"/></param>
        /// <returns><see cref="CreateUserRoleProjectResponse"/></returns>
        public CreateUserRoleProjectResponse CreateUserRoleProjectSync(CreateUserRoleProjectRequest req)
        {
            return InternalRequestAsync<CreateUserRoleProjectResponse>(req, "CreateUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a data source.
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public Task<DeleteDatasourceResponse> DeleteDatasource(DeleteDatasourceRequest req)
        {
            return InternalRequestAsync<DeleteDatasourceResponse>(req, "DeleteDatasource");
        }

        /// <summary>
        /// This API is used to delete a data source.
        /// </summary>
        /// <param name="req"><see cref="DeleteDatasourceRequest"/></param>
        /// <returns><see cref="DeleteDatasourceResponse"/></returns>
        public DeleteDatasourceResponse DeleteDatasourceSync(DeleteDatasourceRequest req)
        {
            return InternalRequestAsync<DeleteDatasourceResponse>(req, "DeleteDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a project.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// This API is used to delete a project.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a user role, which will result in user deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public Task<DeleteUserRoleResponse> DeleteUserRole(DeleteUserRoleRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleResponse>(req, "DeleteUserRole");
        }

        /// <summary>
        /// This API is used to remove a user role, which will result in user deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleRequest"/></param>
        /// <returns><see cref="DeleteUserRoleResponse"/></returns>
        public DeleteUserRoleResponse DeleteUserRoleSync(DeleteUserRoleRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleResponse>(req, "DeleteUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a user role in the project.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public Task<DeleteUserRoleProjectResponse> DeleteUserRoleProject(DeleteUserRoleProjectRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleProjectResponse>(req, "DeleteUserRoleProject");
        }

        /// <summary>
        /// This API is used to delete a user role in the project.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRoleProjectRequest"/></param>
        /// <returns><see cref="DeleteUserRoleProjectResponse"/></returns>
        public DeleteUserRoleProjectResponse DeleteUserRoleProjectSync(DeleteUserRoleProjectRequest req)
        {
            return InternalRequestAsync<DeleteUserRoleProjectResponse>(req, "DeleteUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a data source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public Task<DescribeDatasourceListResponse> DescribeDatasourceList(DescribeDatasourceListRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceListResponse>(req, "DescribeDatasourceList");
        }

        /// <summary>
        /// This API is used to query a data source list.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceListRequest"/></param>
        /// <returns><see cref="DescribeDatasourceListResponse"/></returns>
        public DescribeDatasourceListResponse DescribeDatasourceListSync(DescribeDatasourceListRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceListResponse>(req, "DescribeDatasourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query component information on the page.
        /// </summary>
        /// <param name="req"><see cref="DescribePageWidgetListRequest"/></param>
        /// <returns><see cref="DescribePageWidgetListResponse"/></returns>
        public Task<DescribePageWidgetListResponse> DescribePageWidgetList(DescribePageWidgetListRequest req)
        {
            return InternalRequestAsync<DescribePageWidgetListResponse>(req, "DescribePageWidgetList");
        }

        /// <summary>
        /// This API is used to query component information on the page.
        /// </summary>
        /// <param name="req"><see cref="DescribePageWidgetListRequest"/></param>
        /// <returns><see cref="DescribePageWidgetListResponse"/></returns>
        public DescribePageWidgetListResponse DescribePageWidgetListSync(DescribePageWidgetListRequest req)
        {
            return InternalRequestAsync<DescribePageWidgetListResponse>(req, "DescribePageWidgetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain project details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo");
        }

        /// <summary>
        /// This API is used to obtain project details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain project information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList");
        }

        /// <summary>
        /// This API is used to obtain project information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the user interface in the project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public Task<DescribeUserProjectListResponse> DescribeUserProjectList(DescribeUserProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserProjectListResponse>(req, "DescribeUserProjectList");
        }

        /// <summary>
        /// This API is used to obtain the user interface in the project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserProjectListResponse"/></returns>
        public DescribeUserProjectListResponse DescribeUserProjectListSync(DescribeUserProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserProjectListResponse>(req, "DescribeUserProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the user role list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public Task<DescribeUserRoleListResponse> DescribeUserRoleList(DescribeUserRoleListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleListResponse>(req, "DescribeUserRoleList");
        }

        /// <summary>
        /// This API is used to obtain the user role list.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleListResponse"/></returns>
        public DescribeUserRoleListResponse DescribeUserRoleListSync(DescribeUserRoleListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleListResponse>(req, "DescribeUserRoleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the user role list in the project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleProjectListResponse"/></returns>
        public Task<DescribeUserRoleProjectListResponse> DescribeUserRoleProjectList(DescribeUserRoleProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleProjectListResponse>(req, "DescribeUserRoleProjectList");
        }

        /// <summary>
        /// This API is used to obtain the user role list in the project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRoleProjectListRequest"/></param>
        /// <returns><see cref="DescribeUserRoleProjectListResponse"/></returns>
        public DescribeUserRoleProjectListResponse DescribeUserRoleProjectListSync(DescribeUserRoleProjectListRequest req)
        {
            return InternalRequestAsync<DescribeUserRoleProjectListResponse>(req, "DescribeUserRoleProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export a screenshot.
        /// </summary>
        /// <param name="req"><see cref="ExportScreenPageRequest"/></param>
        /// <returns><see cref="ExportScreenPageResponse"/></returns>
        public Task<ExportScreenPageResponse> ExportScreenPage(ExportScreenPageRequest req)
        {
            return InternalRequestAsync<ExportScreenPageResponse>(req, "ExportScreenPage");
        }

        /// <summary>
        /// This API is used to export a screenshot.
        /// </summary>
        /// <param name="req"><see cref="ExportScreenPageRequest"/></param>
        /// <returns><see cref="ExportScreenPageResponse"/></returns>
        public ExportScreenPageResponse ExportScreenPageSync(ExportScreenPageRequest req)
        {
            return InternalRequestAsync<ExportScreenPageResponse>(req, "ExportScreenPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a data source.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public Task<ModifyDatasourceResponse> ModifyDatasource(ModifyDatasourceRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceResponse>(req, "ModifyDatasource");
        }

        /// <summary>
        /// This API is used to update a data source.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceRequest"/></param>
        /// <returns><see cref="ModifyDatasourceResponse"/></returns>
        public ModifyDatasourceResponse ModifyDatasourceSync(ModifyDatasourceRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceResponse>(req, "ModifyDatasource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a cloud database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public Task<ModifyDatasourceCloudResponse> ModifyDatasourceCloud(ModifyDatasourceCloudRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceCloudResponse>(req, "ModifyDatasourceCloud");
        }

        /// <summary>
        /// This API is used to update a cloud database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDatasourceCloudRequest"/></param>
        /// <returns><see cref="ModifyDatasourceCloudResponse"/></returns>
        public ModifyDatasourceCloudResponse ModifyDatasourceCloudSync(ModifyDatasourceCloudRequest req)
        {
            return InternalRequestAsync<ModifyDatasourceCloudResponse>(req, "ModifyDatasourceCloud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify project information.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// This API is used to modify project information.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user role info.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public Task<ModifyUserRoleResponse> ModifyUserRole(ModifyUserRoleRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleResponse>(req, "ModifyUserRole");
        }

        /// <summary>
        /// This API is used to modify user role info.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleRequest"/></param>
        /// <returns><see cref="ModifyUserRoleResponse"/></returns>
        public ModifyUserRoleResponse ModifyUserRoleSync(ModifyUserRoleRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleResponse>(req, "ModifyUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the user role info in the project.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public Task<ModifyUserRoleProjectResponse> ModifyUserRoleProject(ModifyUserRoleProjectRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleProjectResponse>(req, "ModifyUserRoleProject");
        }

        /// <summary>
        /// This API is used to modify the user role info in the project.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRoleProjectRequest"/></param>
        /// <returns><see cref="ModifyUserRoleProjectResponse"/></returns>
        public ModifyUserRoleProjectResponse ModifyUserRoleProjectSync(ModifyUserRoleProjectRequest req)
        {
            return InternalRequestAsync<ModifyUserRoleProjectResponse>(req, "ModifyUserRoleProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
