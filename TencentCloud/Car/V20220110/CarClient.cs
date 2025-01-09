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

namespace TencentCloud.Car.V20220110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Car.V20220110.Models;

   public class CarClient : AbstractClient{

       private const string endpoint = "car.tencentcloudapi.com";
       private const string version = "2022-01-10";
       private const string sdkVersion = "SDK_NET_3.0.1051";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CarClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CarClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to request concurrency quota. The timeout period of the API is 20 seconds.
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public Task<ApplyConcurrentResponse> ApplyConcurrent(ApplyConcurrentRequest req)
        {
            return InternalRequestAsync<ApplyConcurrentResponse>(req, "ApplyConcurrent");
        }

        /// <summary>
        /// This API is used to request concurrency quota. The timeout period of the API is 20 seconds.
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public ApplyConcurrentResponse ApplyConcurrentSync(ApplyConcurrentRequest req)
        {
            return InternalRequestAsync<ApplyConcurrentResponse>(req, "ApplyConcurrent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a concurrency pack to a project.
        /// </summary>
        /// <param name="req"><see cref="BindConcurrentPackagesToProjectRequest"/></param>
        /// <returns><see cref="BindConcurrentPackagesToProjectResponse"/></returns>
        public Task<BindConcurrentPackagesToProjectResponse> BindConcurrentPackagesToProject(BindConcurrentPackagesToProjectRequest req)
        {
            return InternalRequestAsync<BindConcurrentPackagesToProjectResponse>(req, "BindConcurrentPackagesToProject");
        }

        /// <summary>
        /// This API is used to bind a concurrency pack to a project.
        /// </summary>
        /// <param name="req"><see cref="BindConcurrentPackagesToProjectRequest"/></param>
        /// <returns><see cref="BindConcurrentPackagesToProjectResponse"/></returns>
        public BindConcurrentPackagesToProjectResponse BindConcurrentPackagesToProjectSync(BindConcurrentPackagesToProjectRequest req)
        {
            return InternalRequestAsync<BindConcurrentPackagesToProjectResponse>(req, "BindConcurrentPackagesToProject")
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
        /// This API is used to create a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProjectRequest"/></param>
        /// <returns><see cref="CreateApplicationProjectResponse"/></returns>
        public Task<CreateApplicationProjectResponse> CreateApplicationProject(CreateApplicationProjectRequest req)
        {
            return InternalRequestAsync<CreateApplicationProjectResponse>(req, "CreateApplicationProject");
        }

        /// <summary>
        /// This API is used to create a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationProjectRequest"/></param>
        /// <returns><see cref="CreateApplicationProjectResponse"/></returns>
        public CreateApplicationProjectResponse CreateApplicationProjectSync(CreateApplicationProjectRequest req)
        {
            return InternalRequestAsync<CreateApplicationProjectResponse>(req, "CreateApplicationProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud application version snapshot.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationSnapshotRequest"/></param>
        /// <returns><see cref="CreateApplicationSnapshotResponse"/></returns>
        public Task<CreateApplicationSnapshotResponse> CreateApplicationSnapshot(CreateApplicationSnapshotRequest req)
        {
            return InternalRequestAsync<CreateApplicationSnapshotResponse>(req, "CreateApplicationSnapshot");
        }

        /// <summary>
        /// This API is used to create a cloud application version snapshot.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationSnapshotRequest"/></param>
        /// <returns><see cref="CreateApplicationSnapshotResponse"/></returns>
        public CreateApplicationSnapshotResponse CreateApplicationSnapshotSync(CreateApplicationSnapshotRequest req)
        {
            return InternalRequestAsync<CreateApplicationSnapshotResponse>(req, "CreateApplicationSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a cloud application version.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVersionRequest"/></param>
        /// <returns><see cref="CreateApplicationVersionResponse"/></returns>
        public Task<CreateApplicationVersionResponse> CreateApplicationVersion(CreateApplicationVersionRequest req)
        {
            return InternalRequestAsync<CreateApplicationVersionResponse>(req, "CreateApplicationVersion");
        }

        /// <summary>
        /// This API is used to create a cloud application version.
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVersionRequest"/></param>
        /// <returns><see cref="CreateApplicationVersionResponse"/></returns>
        public CreateApplicationVersionResponse CreateApplicationVersionSync(CreateApplicationVersionRequest req)
        {
            return InternalRequestAsync<CreateApplicationVersionResponse>(req, "CreateApplicationVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a session. The timeout period of the API is 5 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession");
        }

        /// <summary>
        /// This API is used to create a session. The timeout period of the API is 5 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cloud application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// This API is used to delete a cloud application.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete cloud application projects in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProjectsRequest"/></param>
        /// <returns><see cref="DeleteApplicationProjectsResponse"/></returns>
        public Task<DeleteApplicationProjectsResponse> DeleteApplicationProjects(DeleteApplicationProjectsRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProjectsResponse>(req, "DeleteApplicationProjects");
        }

        /// <summary>
        /// This API is used to delete cloud application projects in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationProjectsRequest"/></param>
        /// <returns><see cref="DeleteApplicationProjectsResponse"/></returns>
        public DeleteApplicationProjectsResponse DeleteApplicationProjectsSync(DeleteApplicationProjectsRequest req)
        {
            return InternalRequestAsync<DeleteApplicationProjectsResponse>(req, "DeleteApplicationProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a cloud application version.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationVersionRequest"/></param>
        /// <returns><see cref="DeleteApplicationVersionResponse"/></returns>
        public Task<DeleteApplicationVersionResponse> DeleteApplicationVersion(DeleteApplicationVersionRequest req)
        {
            return InternalRequestAsync<DeleteApplicationVersionResponse>(req, "DeleteApplicationVersion");
        }

        /// <summary>
        /// This API is used to delete a cloud application version.
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationVersionRequest"/></param>
        /// <returns><see cref="DeleteApplicationVersionResponse"/></returns>
        public DeleteApplicationVersionResponse DeleteApplicationVersionSync(DeleteApplicationVersionRequest req)
        {
            return InternalRequestAsync<DeleteApplicationVersionResponse>(req, "DeleteApplicationVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query application file information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationFileInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationFileInfoResponse"/></returns>
        public Task<DescribeApplicationFileInfoResponse> DescribeApplicationFileInfo(DescribeApplicationFileInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationFileInfoResponse>(req, "DescribeApplicationFileInfo");
        }

        /// <summary>
        /// This API is used to query application file information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationFileInfoRequest"/></param>
        /// <returns><see cref="DescribeApplicationFileInfoResponse"/></returns>
        public DescribeApplicationFileInfoResponse DescribeApplicationFileInfoSync(DescribeApplicationFileInfoRequest req)
        {
            return InternalRequestAsync<DescribeApplicationFileInfoResponse>(req, "DescribeApplicationFileInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cloud application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList");
        }

        /// <summary>
        /// This API is used to query the cloud application list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationListResponse>(req, "DescribeApplicationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cloud application startup path list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPathListRequest"/></param>
        /// <returns><see cref="DescribeApplicationPathListResponse"/></returns>
        public Task<DescribeApplicationPathListResponse> DescribeApplicationPathList(DescribeApplicationPathListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPathListResponse>(req, "DescribeApplicationPathList");
        }

        /// <summary>
        /// This API is used to query the cloud application startup path list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationPathListRequest"/></param>
        /// <returns><see cref="DescribeApplicationPathListResponse"/></returns>
        public DescribeApplicationPathListResponse DescribeApplicationPathListSync(DescribeApplicationPathListRequest req)
        {
            return InternalRequestAsync<DescribeApplicationPathListResponse>(req, "DescribeApplicationPathList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the advanced configuration information of a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProjectAdvancedConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationProjectAdvancedConfigResponse"/></returns>
        public Task<DescribeApplicationProjectAdvancedConfigResponse> DescribeApplicationProjectAdvancedConfig(DescribeApplicationProjectAdvancedConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProjectAdvancedConfigResponse>(req, "DescribeApplicationProjectAdvancedConfig");
        }

        /// <summary>
        /// This API is used to obtain the advanced configuration information of a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProjectAdvancedConfigRequest"/></param>
        /// <returns><see cref="DescribeApplicationProjectAdvancedConfigResponse"/></returns>
        public DescribeApplicationProjectAdvancedConfigResponse DescribeApplicationProjectAdvancedConfigSync(DescribeApplicationProjectAdvancedConfigRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProjectAdvancedConfigResponse>(req, "DescribeApplicationProjectAdvancedConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cloud application project list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProjectsRequest"/></param>
        /// <returns><see cref="DescribeApplicationProjectsResponse"/></returns>
        public Task<DescribeApplicationProjectsResponse> DescribeApplicationProjects(DescribeApplicationProjectsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProjectsResponse>(req, "DescribeApplicationProjects");
        }

        /// <summary>
        /// This API is used to obtain the cloud application project list.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationProjectsRequest"/></param>
        /// <returns><see cref="DescribeApplicationProjectsResponse"/></returns>
        public DescribeApplicationProjectsResponse DescribeApplicationProjectsSync(DescribeApplicationProjectsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationProjectsResponse>(req, "DescribeApplicationProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the running status of a cloud application and update status information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationStatusResponse"/></returns>
        public Task<DescribeApplicationStatusResponse> DescribeApplicationStatus(DescribeApplicationStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationStatusResponse>(req, "DescribeApplicationStatus");
        }

        /// <summary>
        /// This API is used to query the running status of a cloud application and update status information.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationStatusRequest"/></param>
        /// <returns><see cref="DescribeApplicationStatusResponse"/></returns>
        public DescribeApplicationStatusResponse DescribeApplicationStatusSync(DescribeApplicationStatusRequest req)
        {
            return InternalRequestAsync<DescribeApplicationStatusResponse>(req, "DescribeApplicationStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the version information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVersionRequest"/></param>
        /// <returns><see cref="DescribeApplicationVersionResponse"/></returns>
        public Task<DescribeApplicationVersionResponse> DescribeApplicationVersion(DescribeApplicationVersionRequest req)
        {
            return InternalRequestAsync<DescribeApplicationVersionResponse>(req, "DescribeApplicationVersion");
        }

        /// <summary>
        /// This API is used to query the version information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVersionRequest"/></param>
        /// <returns><see cref="DescribeApplicationVersionResponse"/></returns>
        public DescribeApplicationVersionResponse DescribeApplicationVersionSync(DescribeApplicationVersionRequest req)
        {
            return InternalRequestAsync<DescribeApplicationVersionResponse>(req, "DescribeApplicationVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the concurrency count.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentCountRequest"/></param>
        /// <returns><see cref="DescribeConcurrentCountResponse"/></returns>
        public Task<DescribeConcurrentCountResponse> DescribeConcurrentCount(DescribeConcurrentCountRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentCountResponse>(req, "DescribeConcurrentCount");
        }

        /// <summary>
        /// This API is used to obtain the concurrency count.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentCountRequest"/></param>
        /// <returns><see cref="DescribeConcurrentCountResponse"/></returns>
        public DescribeConcurrentCountResponse DescribeConcurrentCountSync(DescribeConcurrentCountRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentCountResponse>(req, "DescribeConcurrentCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cloud application concurrency pack list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentPackagesRequest"/></param>
        /// <returns><see cref="DescribeConcurrentPackagesResponse"/></returns>
        public Task<DescribeConcurrentPackagesResponse> DescribeConcurrentPackages(DescribeConcurrentPackagesRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentPackagesResponse>(req, "DescribeConcurrentPackages");
        }

        /// <summary>
        /// This API is used to obtain the cloud application concurrency pack list.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentPackagesRequest"/></param>
        /// <returns><see cref="DescribeConcurrentPackagesResponse"/></returns>
        public DescribeConcurrentPackagesResponse DescribeConcurrentPackagesSync(DescribeConcurrentPackagesRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentPackagesResponse>(req, "DescribeConcurrentPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the concurrency overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentSummaryRequest"/></param>
        /// <returns><see cref="DescribeConcurrentSummaryResponse"/></returns>
        public Task<DescribeConcurrentSummaryResponse> DescribeConcurrentSummary(DescribeConcurrentSummaryRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentSummaryResponse>(req, "DescribeConcurrentSummary");
        }

        /// <summary>
        /// This API is used to query the concurrency overview.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrentSummaryRequest"/></param>
        /// <returns><see cref="DescribeConcurrentSummaryResponse"/></returns>
        public DescribeConcurrentSummaryResponse DescribeConcurrentSummarySync(DescribeConcurrentSummaryRequest req)
        {
            return InternalRequestAsync<DescribeConcurrentSummaryResponse>(req, "DescribeConcurrentSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query COS key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosCredentialRequest"/></param>
        /// <returns><see cref="DescribeCosCredentialResponse"/></returns>
        public Task<DescribeCosCredentialResponse> DescribeCosCredential(DescribeCosCredentialRequest req)
        {
            return InternalRequestAsync<DescribeCosCredentialResponse>(req, "DescribeCosCredential");
        }

        /// <summary>
        /// This API is used to query COS key information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosCredentialRequest"/></param>
        /// <returns><see cref="DescribeCosCredentialResponse"/></returns>
        public DescribeCosCredentialResponse DescribeCosCredentialSync(DescribeCosCredentialRequest req)
        {
            return InternalRequestAsync<DescribeCosCredentialResponse>(req, "DescribeCosCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a session. If cloud-based streaming has been enabled for this session, the cloud-based streaming will end upon session termination.
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public Task<DestroySessionResponse> DestroySession(DestroySessionRequest req)
        {
            return InternalRequestAsync<DestroySessionResponse>(req, "DestroySession");
        }

        /// <summary>
        /// This API is used to terminate a session. If cloud-based streaming has been enabled for this session, the cloud-based streaming will end upon session termination.
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public DestroySessionResponse DestroySessionSync(DestroySessionRequest req)
        {
            return InternalRequestAsync<DestroySessionResponse>(req, "DestroySession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify basic information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBaseInfoResponse"/></returns>
        public Task<ModifyApplicationBaseInfoResponse> ModifyApplicationBaseInfo(ModifyApplicationBaseInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationBaseInfoResponse>(req, "ModifyApplicationBaseInfo");
        }

        /// <summary>
        /// This API is used to modify basic information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBaseInfoResponse"/></returns>
        public ModifyApplicationBaseInfoResponse ModifyApplicationBaseInfoSync(ModifyApplicationBaseInfoRequest req)
        {
            return InternalRequestAsync<ModifyApplicationBaseInfoResponse>(req, "ModifyApplicationBaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProjectRequest"/></param>
        /// <returns><see cref="ModifyApplicationProjectResponse"/></returns>
        public Task<ModifyApplicationProjectResponse> ModifyApplicationProject(ModifyApplicationProjectRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProjectResponse>(req, "ModifyApplicationProject");
        }

        /// <summary>
        /// This API is used to modify a cloud application project.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationProjectRequest"/></param>
        /// <returns><see cref="ModifyApplicationProjectResponse"/></returns>
        public ModifyApplicationProjectResponse ModifyApplicationProjectSync(ModifyApplicationProjectRequest req)
        {
            return InternalRequestAsync<ModifyApplicationProjectResponse>(req, "ModifyApplicationProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the version information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVersionRequest"/></param>
        /// <returns><see cref="ModifyApplicationVersionResponse"/></returns>
        public Task<ModifyApplicationVersionResponse> ModifyApplicationVersion(ModifyApplicationVersionRequest req)
        {
            return InternalRequestAsync<ModifyApplicationVersionResponse>(req, "ModifyApplicationVersion");
        }

        /// <summary>
        /// This API is used to modify the version information of a cloud application.
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVersionRequest"/></param>
        /// <returns><see cref="ModifyApplicationVersionResponse"/></returns>
        public ModifyApplicationVersionResponse ModifyApplicationVersionSync(ModifyApplicationVersionRequest req)
        {
            return InternalRequestAsync<ModifyApplicationVersionResponse>(req, "ModifyApplicationVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a cloud application concurrency pack.
        /// </summary>
        /// <param name="req"><see cref="ModifyConcurrentPackageRequest"/></param>
        /// <returns><see cref="ModifyConcurrentPackageResponse"/></returns>
        public Task<ModifyConcurrentPackageResponse> ModifyConcurrentPackage(ModifyConcurrentPackageRequest req)
        {
            return InternalRequestAsync<ModifyConcurrentPackageResponse>(req, "ModifyConcurrentPackage");
        }

        /// <summary>
        /// This API is used to modify a cloud application concurrency pack.
        /// </summary>
        /// <param name="req"><see cref="ModifyConcurrentPackageRequest"/></param>
        /// <returns><see cref="ModifyConcurrentPackageResponse"/></returns>
        public ModifyConcurrentPackageResponse ModifyConcurrentPackageSync(ModifyConcurrentPackageRequest req)
        {
            return InternalRequestAsync<ModifyConcurrentPackageResponse>(req, "ModifyConcurrentPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the mobile application data.
        /// </summary>
        /// <param name="req"><see cref="ModifyMobileApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyMobileApplicationInfoResponse"/></returns>
        public Task<ModifyMobileApplicationInfoResponse> ModifyMobileApplicationInfo(ModifyMobileApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyMobileApplicationInfoResponse>(req, "ModifyMobileApplicationInfo");
        }

        /// <summary>
        /// This API is used to modify the mobile application data.
        /// </summary>
        /// <param name="req"><see cref="ModifyMobileApplicationInfoRequest"/></param>
        /// <returns><see cref="ModifyMobileApplicationInfoResponse"/></returns>
        public ModifyMobileApplicationInfoResponse ModifyMobileApplicationInfoSync(ModifyMobileApplicationInfoRequest req)
        {
            return InternalRequestAsync<ModifyMobileApplicationInfoResponse>(req, "ModifyMobileApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset a concurrency pack and disconnect all user connections.
        /// </summary>
        /// <param name="req"><see cref="ResetConcurrentPackagesRequest"/></param>
        /// <returns><see cref="ResetConcurrentPackagesResponse"/></returns>
        public Task<ResetConcurrentPackagesResponse> ResetConcurrentPackages(ResetConcurrentPackagesRequest req)
        {
            return InternalRequestAsync<ResetConcurrentPackagesResponse>(req, "ResetConcurrentPackages");
        }

        /// <summary>
        /// This API is used to reset a concurrency pack and disconnect all user connections.
        /// </summary>
        /// <param name="req"><see cref="ResetConcurrentPackagesRequest"/></param>
        /// <returns><see cref="ResetConcurrentPackagesResponse"/></returns>
        public ResetConcurrentPackagesResponse ResetConcurrentPackagesSync(ResetConcurrentPackagesRequest req)
        {
            return InternalRequestAsync<ResetConcurrentPackagesResponse>(req, "ResetConcurrentPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to launch an application version.
        /// </summary>
        /// <param name="req"><see cref="SetApplicationVersionOnlineRequest"/></param>
        /// <returns><see cref="SetApplicationVersionOnlineResponse"/></returns>
        public Task<SetApplicationVersionOnlineResponse> SetApplicationVersionOnline(SetApplicationVersionOnlineRequest req)
        {
            return InternalRequestAsync<SetApplicationVersionOnlineResponse>(req, "SetApplicationVersionOnline");
        }

        /// <summary>
        /// This API is used to launch an application version.
        /// </summary>
        /// <param name="req"><see cref="SetApplicationVersionOnlineRequest"/></param>
        /// <returns><see cref="SetApplicationVersionOnlineResponse"/></returns>
        public SetApplicationVersionOnlineResponse SetApplicationVersionOnlineSync(SetApplicationVersionOnlineRequest req)
        {
            return InternalRequestAsync<SetApplicationVersionOnlineResponse>(req, "SetApplicationVersionOnline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start pushing your cloud application's video streams in real time to CSS. The codec for the streaming is automatically selected based on the client's (SDK) capabilities, with a default order of H.265, H.264, VP8, and VP9.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public Task<StartPublishStreamResponse> StartPublishStream(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream");
        }

        /// <summary>
        /// This API is used to start pushing your cloud application's video streams in real time to CSS. The codec for the streaming is automatically selected based on the client's (SDK) capabilities, with a default order of H.265, H.264, VP8, and VP9.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public StartPublishStreamResponse StartPublishStreamSync(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start pushing your cloud application's video streams to a specified URL. The codec for the streaming is automatically selected based on the client's (SDK) capabilities, with a default order of H.265, H.264, VP8, and VP9. This streaming method will be billed separately. For details about the billing method, see [Charging for Streaming to Specified URL](https://intl.cloud.tencent.com/document/product/1547/72168?from_cn_redirect=1#98ac188a-d122-4caf-88be-05268ecefdf6).
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public Task<StartPublishStreamWithURLResponse> StartPublishStreamWithURL(StartPublishStreamWithURLRequest req)
        {
            return InternalRequestAsync<StartPublishStreamWithURLResponse>(req, "StartPublishStreamWithURL");
        }

        /// <summary>
        /// This API is used to start pushing your cloud application's video streams to a specified URL. The codec for the streaming is automatically selected based on the client's (SDK) capabilities, with a default order of H.265, H.264, VP8, and VP9. This streaming method will be billed separately. For details about the billing method, see [Charging for Streaming to Specified URL](https://intl.cloud.tencent.com/document/product/1547/72168?from_cn_redirect=1#98ac188a-d122-4caf-88be-05268ecefdf6).
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public StartPublishStreamWithURLResponse StartPublishStreamWithURLSync(StartPublishStreamWithURLRequest req)
        {
            return InternalRequestAsync<StartPublishStreamWithURLResponse>(req, "StartPublishStreamWithURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop pushing streams.
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public Task<StopPublishStreamResponse> StopPublishStream(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream");
        }

        /// <summary>
        /// This API is used to stop pushing streams.
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public StopPublishStreamResponse StopPublishStreamSync(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a concurrency pack from a project.
        /// </summary>
        /// <param name="req"><see cref="UnbindConcurrentPackagesFromProjectRequest"/></param>
        /// <returns><see cref="UnbindConcurrentPackagesFromProjectResponse"/></returns>
        public Task<UnbindConcurrentPackagesFromProjectResponse> UnbindConcurrentPackagesFromProject(UnbindConcurrentPackagesFromProjectRequest req)
        {
            return InternalRequestAsync<UnbindConcurrentPackagesFromProjectResponse>(req, "UnbindConcurrentPackagesFromProject");
        }

        /// <summary>
        /// This API is used to unbind a concurrency pack from a project.
        /// </summary>
        /// <param name="req"><see cref="UnbindConcurrentPackagesFromProjectRequest"/></param>
        /// <returns><see cref="UnbindConcurrentPackagesFromProjectResponse"/></returns>
        public UnbindConcurrentPackagesFromProjectResponse UnbindConcurrentPackagesFromProjectSync(UnbindConcurrentPackagesFromProjectRequest req)
        {
            return InternalRequestAsync<UnbindConcurrentPackagesFromProjectResponse>(req, "UnbindConcurrentPackagesFromProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
