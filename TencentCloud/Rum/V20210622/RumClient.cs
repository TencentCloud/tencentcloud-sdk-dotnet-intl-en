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

namespace TencentCloud.Rum.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rum.V20210622.Models;

   public class RumClient : AbstractClient{

       private const string endpoint = "rum.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1091";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RumClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RumClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to create a log download task.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public Task<CreateLogExportResponse> CreateLogExport(CreateLogExportRequest req)
        {
            return InternalRequestAsync<CreateLogExportResponse>(req, "CreateLogExport");
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to create a log download task.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public CreateLogExportResponse CreateLogExportSync(CreateLogExportRequest req)
        {
            return InternalRequestAsync<CreateLogExportResponse>(req, "CreateLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an offline log listener to report offline logs of particular users.
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineLogConfigRequest"/></param>
        /// <returns><see cref="CreateOfflineLogConfigResponse"/></returns>
        public Task<CreateOfflineLogConfigResponse> CreateOfflineLogConfig(CreateOfflineLogConfigRequest req)
        {
            return InternalRequestAsync<CreateOfflineLogConfigResponse>(req, "CreateOfflineLogConfig");
        }

        /// <summary>
        /// This API is used to create an offline log listener to report offline logs of particular users.
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineLogConfigRequest"/></param>
        /// <returns><see cref="CreateOfflineLogConfigResponse"/></returns>
        public CreateOfflineLogConfigResponse CreateOfflineLogConfigSync(CreateOfflineLogConfigRequest req)
        {
            return InternalRequestAsync<CreateOfflineLogConfigResponse>(req, "CreateOfflineLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RUM application which belongs to a specific team.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// This API is used to create a RUM application which belongs to a specific team.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a file record for the specified project.
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public Task<CreateReleaseFileResponse> CreateReleaseFile(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile");
        }

        /// <summary>
        /// This API is used to create a file record for the specified project.
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public CreateReleaseFileResponse CreateReleaseFileSync(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a starred project.
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public Task<CreateStarProjectResponse> CreateStarProject(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject");
        }

        /// <summary>
        /// This API is used to add a starred project.
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public CreateStarProjectResponse CreateStarProjectSync(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RUM business system.
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public Task<CreateTawInstanceResponse> CreateTawInstance(CreateTawInstanceRequest req)
        {
            return InternalRequestAsync<CreateTawInstanceResponse>(req, "CreateTawInstance");
        }

        /// <summary>
        /// This API is used to create a RUM business system.
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public CreateTawInstanceResponse CreateTawInstanceSync(CreateTawInstanceRequest req)
        {
            return InternalRequestAsync<CreateTawInstanceResponse>(req, "CreateTawInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public Task<CreateWhitelistResponse> CreateWhitelist(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist");
        }

        /// <summary>
        /// This API is used to create an allowlist.
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public CreateWhitelistResponse CreateWhitelistSync(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an instance. The deleted instance cannot be recovered.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// This API is used to delete an instance. The deleted instance cannot be recovered.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to delete a log download task.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public Task<DeleteLogExportResponse> DeleteLogExport(DeleteLogExportRequest req)
        {
            return InternalRequestAsync<DeleteLogExportResponse>(req, "DeleteLogExport");
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to delete a log download task.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public DeleteLogExportResponse DeleteLogExportSync(DeleteLogExportRequest req)
        {
            return InternalRequestAsync<DeleteLogExportResponse>(req, "DeleteLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an offline RUM log listener. Then, offline logs of particular users will not be reported.
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogConfigRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogConfigResponse"/></returns>
        public Task<DeleteOfflineLogConfigResponse> DeleteOfflineLogConfig(DeleteOfflineLogConfigRequest req)
        {
            return InternalRequestAsync<DeleteOfflineLogConfigResponse>(req, "DeleteOfflineLogConfig");
        }

        /// <summary>
        /// This API is used to delete an offline RUM log listener. Then, offline logs of particular users will not be reported.
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogConfigRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogConfigResponse"/></returns>
        public DeleteOfflineLogConfigResponse DeleteOfflineLogConfigSync(DeleteOfflineLogConfigRequest req)
        {
            return InternalRequestAsync<DeleteOfflineLogConfigResponse>(req, "DeleteOfflineLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an offline log record.
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogRecordRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogRecordResponse"/></returns>
        public Task<DeleteOfflineLogRecordResponse> DeleteOfflineLogRecord(DeleteOfflineLogRecordRequest req)
        {
            return InternalRequestAsync<DeleteOfflineLogRecordResponse>(req, "DeleteOfflineLogRecord");
        }

        /// <summary>
        /// This API is used to delete an offline log record.
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogRecordRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogRecordResponse"/></returns>
        public DeleteOfflineLogRecordResponse DeleteOfflineLogRecordSync(DeleteOfflineLogRecordRequest req)
        {
            return InternalRequestAsync<DeleteOfflineLogRecordResponse>(req, "DeleteOfflineLogRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specified RUM project.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// This API is used to delete the specified RUM project.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the specified sourcemap file.
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public Task<DeleteReleaseFileResponse> DeleteReleaseFile(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile");
        }

        /// <summary>
        /// This API is used to delete the specified sourcemap file.
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public DeleteReleaseFileResponse DeleteReleaseFileSync(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a starred project for the specified user.
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public Task<DeleteStarProjectResponse> DeleteStarProject(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject");
        }

        /// <summary>
        /// This API is used to delete a starred project for the specified user.
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public DeleteStarProjectResponse DeleteStarProjectSync(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public Task<DeleteWhitelistResponse> DeleteWhitelist(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist");
        }

        /// <summary>
        /// This API is used to delete an allowlist.
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public DeleteWhitelistResponse DeleteWhitelistSync(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the forwarding monitor.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData");
        }

        /// <summary>
        /// This API is used to query the forwarding monitor.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataCustomUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public Task<DescribeDataCustomUrlResponse> DescribeDataCustomUrl(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl");
        }

        /// <summary>
        /// This API is used to get the DescribeDataCustomUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public DescribeDataCustomUrlResponse DescribeDataCustomUrlSync(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataEventUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public Task<DescribeDataEventUrlResponse> DescribeDataEventUrl(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl");
        }

        /// <summary>
        /// This API is used to get the DescribeDataEventUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public DescribeDataEventUrlResponse DescribeDataEventUrlSync(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the `DescribeDataFetchProject` information and has been deprecated. Use `DescribeDataFetchUrl` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public Task<DescribeDataFetchProjectResponse> DescribeDataFetchProject(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject");
        }

        /// <summary>
        /// This API is used to get the `DescribeDataFetchProject` information and has been deprecated. Use `DescribeDataFetchUrl` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public DescribeDataFetchProjectResponse DescribeDataFetchProjectSync(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataFetchUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public Task<DescribeDataFetchUrlResponse> DescribeDataFetchUrl(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl");
        }

        /// <summary>
        /// This API is used to get the DescribeDataFetchUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public DescribeDataFetchUrlResponse DescribeDataFetchUrlSync(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataFetchUrlInfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public Task<DescribeDataFetchUrlInfoResponse> DescribeDataFetchUrlInfo(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo");
        }

        /// <summary>
        /// This API is used to get the DescribeDataFetchUrlInfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public DescribeDataFetchUrlInfoResponse DescribeDataFetchUrlInfoSync(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the loginfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public Task<DescribeDataLogUrlInfoResponse> DescribeDataLogUrlInfo(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo");
        }

        /// <summary>
        /// This API is used to get the loginfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public DescribeDataLogUrlInfoResponse DescribeDataLogUrlInfoSync(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the LogUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public Task<DescribeDataLogUrlStatisticsResponse> DescribeDataLogUrlStatistics(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics");
        }

        /// <summary>
        /// This API is used to get the LogUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public DescribeDataLogUrlStatisticsResponse DescribeDataLogUrlStatisticsSync(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the PerformancePage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public Task<DescribeDataPerformancePageResponse> DescribeDataPerformancePage(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage");
        }

        /// <summary>
        /// This API is used to get the PerformancePage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public DescribeDataPerformancePageResponse DescribeDataPerformancePageSync(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the PerformanceProject information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformanceProjectRequest"/></param>
        /// <returns><see cref="DescribeDataPerformanceProjectResponse"/></returns>
        public Task<DescribeDataPerformanceProjectResponse> DescribeDataPerformanceProject(DescribeDataPerformanceProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformanceProjectResponse>(req, "DescribeDataPerformanceProject");
        }

        /// <summary>
        /// This API is used to get the PerformanceProject information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformanceProjectRequest"/></param>
        /// <returns><see cref="DescribeDataPerformanceProjectResponse"/></returns>
        public DescribeDataPerformanceProjectResponse DescribeDataPerformanceProjectSync(DescribeDataPerformanceProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformanceProjectResponse>(req, "DescribeDataPerformanceProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the PvUrlInfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public Task<DescribeDataPvUrlInfoResponse> DescribeDataPvUrlInfo(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo");
        }

        /// <summary>
        /// This API is used to get the PvUrlInfo information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public DescribeDataPvUrlInfoResponse DescribeDataPvUrlInfoSync(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataPvUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public Task<DescribeDataPvUrlStatisticsResponse> DescribeDataPvUrlStatistics(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics");
        }

        /// <summary>
        /// This API is used to get the DescribeDataPvUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public DescribeDataPvUrlStatisticsResponse DescribeDataPvUrlStatisticsSync(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of reported data entries for a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public Task<DescribeDataReportCountResponse> DescribeDataReportCount(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount");
        }

        /// <summary>
        /// This API is used to get the number of reported data entries for a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public DescribeDataReportCountResponse DescribeDataReportCountSync(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataSetUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public Task<DescribeDataSetUrlStatisticsResponse> DescribeDataSetUrlStatistics(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics");
        }

        /// <summary>
        /// This API is used to get the DescribeDataSetUrlStatistics information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public DescribeDataSetUrlStatisticsResponse DescribeDataSetUrlStatisticsSync(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticProject information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public Task<DescribeDataStaticProjectResponse> DescribeDataStaticProject(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject");
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticProject information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public DescribeDataStaticProjectResponse DescribeDataStaticProjectSync(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticResource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public Task<DescribeDataStaticResourceResponse> DescribeDataStaticResource(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource");
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticResource information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public DescribeDataStaticResourceResponse DescribeDataStaticResourceSync(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public Task<DescribeDataStaticUrlResponse> DescribeDataStaticUrl(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl");
        }

        /// <summary>
        /// This API is used to get the DescribeDataStaticUrl information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public DescribeDataStaticUrlResponse DescribeDataStaticUrlSync(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the DescribeDataWebVitalsPage information, which is about core user activities.
        /// It includes the Web Vitals metric for the page loading performance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public Task<DescribeDataWebVitalsPageResponse> DescribeDataWebVitalsPage(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage");
        }

        /// <summary>
        /// This API is used to get the DescribeDataWebVitalsPage information, which is about core user activities.
        /// It includes the Web Vitals metric for the page loading performance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public DescribeDataWebVitalsPageResponse DescribeDataWebVitalsPageSync(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the homepage error information.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public Task<DescribeErrorResponse> DescribeError(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError");
        }

        /// <summary>
        /// This API is used to get the homepage error information.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public DescribeErrorResponse DescribeErrorSync(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to get the list of log download tasks.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public Task<DescribeLogExportsResponse> DescribeLogExports(DescribeLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeLogExportsResponse>(req, "DescribeLogExports");
        }

        /// <summary>
        /// API domain name: `rum.tencentcloudapi.com`.
        /// 
        /// This API is used to get the list of log download tasks.
        /// 
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public DescribeLogExportsResponse DescribeLogExportsSync(DescribeLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeLogExportsResponse>(req, "DescribeLogExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the log list. It has been deprecated. Use `DescribeRumLogList` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public Task<DescribeLogListResponse> DescribeLogList(DescribeLogListRequest req)
        {
            return InternalRequestAsync<DescribeLogListResponse>(req, "DescribeLogList");
        }

        /// <summary>
        /// This API is used to get the log list. It has been deprecated. Use `DescribeRumLogList` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public DescribeLogListResponse DescribeLogListSync(DescribeLogListRequest req)
        {
            return InternalRequestAsync<DescribeLogListResponse>(req, "DescribeLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the configuration of the set offline log listener and return the unique user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogConfigsResponse"/></returns>
        public Task<DescribeOfflineLogConfigsResponse> DescribeOfflineLogConfigs(DescribeOfflineLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogConfigsResponse>(req, "DescribeOfflineLogConfigs");
        }

        /// <summary>
        /// This API is used to get the configuration of the set offline log listener and return the unique user ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogConfigsResponse"/></returns>
        public DescribeOfflineLogConfigsResponse DescribeOfflineLogConfigsSync(DescribeOfflineLogConfigsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogConfigsResponse>(req, "DescribeOfflineLogConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get all (up to 100) offline log records.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogRecordsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogRecordsResponse"/></returns>
        public Task<DescribeOfflineLogRecordsResponse> DescribeOfflineLogRecords(DescribeOfflineLogRecordsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogRecordsResponse>(req, "DescribeOfflineLogRecords");
        }

        /// <summary>
        /// This API is used to get all (up to 100) offline log records.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogRecordsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogRecordsResponse"/></returns>
        public DescribeOfflineLogRecordsResponse DescribeOfflineLogRecordsSync(DescribeOfflineLogRecordsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogRecordsResponse>(req, "DescribeOfflineLogRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the specified offline log.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogsResponse"/></returns>
        public Task<DescribeOfflineLogsResponse> DescribeOfflineLogs(DescribeOfflineLogsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogsResponse>(req, "DescribeOfflineLogs");
        }

        /// <summary>
        /// This API is used to get the specified offline log.
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogsResponse"/></returns>
        public DescribeOfflineLogsResponse DescribeOfflineLogsSync(DescribeOfflineLogsRequest req)
        {
            return InternalRequestAsync<DescribeOfflineLogsResponse>(req, "DescribeOfflineLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the sampling information of an application’s reporting APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public Task<DescribeProjectLimitsResponse> DescribeProjectLimits(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits");
        }

        /// <summary>
        /// This API is used to get the sampling information of an application’s reporting APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public DescribeProjectLimitsResponse DescribeProjectLimitsSync(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of projects (under teams created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// This API is used to get the list of projects (under teams created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of PVs under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public Task<DescribePvListResponse> DescribePvList(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList");
        }

        /// <summary>
        /// This API is used to get the list of PVs under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public DescribePvListResponse DescribePvListSync(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the temporary key for uploaded file storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public Task<DescribeReleaseFileSignResponse> DescribeReleaseFileSign(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign");
        }

        /// <summary>
        /// This API is used to get the temporary key for uploaded file storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public DescribeReleaseFileSignResponse DescribeReleaseFileSignSync(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of source maps of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public Task<DescribeReleaseFilesResponse> DescribeReleaseFiles(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles");
        }

        /// <summary>
        /// This API is used to get the list of source maps of an application.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public DescribeReleaseFilesResponse DescribeReleaseFilesSync(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the log aggregation information under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public Task<DescribeRumGroupLogResponse> DescribeRumGroupLog(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog");
        }

        /// <summary>
        /// This API is used to get the log aggregation information under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public DescribeRumGroupLogResponse DescribeRumGroupLogSync(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of logs in a project (created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public Task<DescribeRumLogExportResponse> DescribeRumLogExport(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport");
        }

        /// <summary>
        /// This API is used to get the list of logs in a project (created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public DescribeRumLogExportResponse DescribeRumLogExportSync(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of exported logs in a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public Task<DescribeRumLogExportsResponse> DescribeRumLogExports(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports");
        }

        /// <summary>
        /// This API is used to get the list of exported logs in a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public DescribeRumLogExportsResponse DescribeRumLogExportsSync(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of logs in a project (created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public Task<DescribeRumLogListResponse> DescribeRumLogList(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList");
        }

        /// <summary>
        /// This API is used to get the list of logs in a project (created by an instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public DescribeRumLogListResponse DescribeRumLogListSync(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of logs in a project every minute.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public Task<DescribeRumStatsLogListResponse> DescribeRumStatsLogList(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList");
        }

        /// <summary>
        /// This API is used to get the list of logs in a project every minute.
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public DescribeRumStatsLogListResponse DescribeRumStatsLogListSync(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of homepage scores.
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public Task<DescribeScoresResponse> DescribeScores(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores");
        }

        /// <summary>
        /// This API is used to get the list of homepage scores.
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public DescribeScoresResponse DescribeScoresSync(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query region information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public Task<DescribeTawAreasResponse> DescribeTawAreas(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas");
        }

        /// <summary>
        /// This API is used to query region information.
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public DescribeTawAreasResponse DescribeTawAreasSync(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of UVs under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public Task<DescribeUvListResponse> DescribeUvList(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList");
        }

        /// <summary>
        /// This API is used to get the list of UVs under a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public DescribeUvListResponse DescribeUvListSync(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public Task<DescribeWhitelistsResponse> DescribeWhitelists(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists");
        }

        /// <summary>
        /// This API is used to get the list of allowlists.
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public DescribeWhitelistsResponse DescribeWhitelistsSync(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a RUM business system.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify a RUM business system.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the RUM application information.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// This API is used to modify the RUM application information.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or modify data reporting limit.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public Task<ModifyProjectLimitResponse> ModifyProjectLimit(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit");
        }

        /// <summary>
        /// This API is used to add or modify data reporting limit.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public ModifyProjectLimitResponse ModifyProjectLimitSync(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover a RUM business system so that you can use the application to report data normally.
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public Task<ResumeInstanceResponse> ResumeInstance(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance");
        }

        /// <summary>
        /// This API is used to recover a RUM business system so that you can use the application to report data normally.
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public ResumeInstanceResponse ResumeInstanceSync(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover an application and resume data reporting.
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public Task<ResumeProjectResponse> ResumeProject(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject");
        }

        /// <summary>
        /// This API is used to recover an application and resume data reporting.
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public ResumeProjectResponse ResumeProjectSync(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop an instance.
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public Task<StopInstanceResponse> StopInstance(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance");
        }

        /// <summary>
        /// This API is used to stop an instance.
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public StopInstanceResponse StopInstanceSync(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop a project from reporting data.
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public Task<StopProjectResponse> StopProject(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject");
        }

        /// <summary>
        /// This API is used to stop a project from reporting data.
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public StopProjectResponse StopProjectSync(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
