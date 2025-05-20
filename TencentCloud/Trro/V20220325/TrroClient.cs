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

namespace TencentCloud.Trro.V20220325
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trro.V20220325.Models;

   public class TrroClient : AbstractClient{

       private const string endpoint = "trro.intl.tencentcloudapi.com";
       private const string version = "2022-03-25";
       private const string sdkVersion = "SDK_NET_3.0.1134";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrroClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrroClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to delete devices in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public Task<BatchDeleteDevicesResponse> BatchDeleteDevices(BatchDeleteDevicesRequest req)
        {
            return InternalRequestAsync<BatchDeleteDevicesResponse>(req, "BatchDeleteDevices");
        }

        /// <summary>
        /// This API is used to delete devices in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteDevicesRequest"/></param>
        /// <returns><see cref="BatchDeleteDevicesResponse"/></returns>
        public BatchDeleteDevicesResponse BatchDeleteDevicesSync(BatchDeleteDevicesRequest req)
        {
            return InternalRequestAsync<BatchDeleteDevicesResponse>(req, "BatchDeleteDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete and modify permission configurations.
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public Task<BatchDeletePolicyResponse> BatchDeletePolicy(BatchDeletePolicyRequest req)
        {
            return InternalRequestAsync<BatchDeletePolicyResponse>(req, "BatchDeletePolicy");
        }

        /// <summary>
        /// This API is used to batch delete and modify permission configurations.
        /// </summary>
        /// <param name="req"><see cref="BatchDeletePolicyRequest"/></param>
        /// <returns><see cref="BatchDeletePolicyResponse"/></returns>
        public BatchDeletePolicyResponse BatchDeletePolicySync(BatchDeletePolicyRequest req)
        {
            return InternalRequestAsync<BatchDeletePolicyResponse>(req, "BatchDeletePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a device.
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// This API is used to create a device.
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
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
        /// This API is used to get specified device information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public Task<DescribeDeviceInfoResponse> DescribeDeviceInfo(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo");
        }

        /// <summary>
        /// This API is used to get specified device information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceInfoResponse"/></returns>
        public DescribeDeviceInfoResponse DescribeDeviceInfoSync(DescribeDeviceInfoRequest req)
        {
            return InternalRequestAsync<DescribeDeviceInfoResponse>(req, "DescribeDeviceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Getting the device session list
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public Task<DescribeDeviceSessionListResponse> DescribeDeviceSessionList(DescribeDeviceSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionListResponse>(req, "DescribeDeviceSessionList");
        }

        /// <summary>
        /// Getting the device session list
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceSessionListRequest"/></param>
        /// <returns><see cref="DescribeDeviceSessionListResponse"/></returns>
        public DescribeDeviceSessionListResponse DescribeDeviceSessionListSync(DescribeDeviceSessionListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceSessionListResponse>(req, "DescribeDeviceSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get project information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public Task<DescribeProjectInfoResponse> DescribeProjectInfo(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo");
        }

        /// <summary>
        /// This API is used to get project information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectInfoRequest"/></param>
        /// <returns><see cref="DescribeProjectInfoResponse"/></returns>
        public DescribeProjectInfoResponse DescribeProjectInfoSync(DescribeProjectInfoRequest req)
        {
            return InternalRequestAsync<DescribeProjectInfoResponse>(req, "DescribeProjectInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get project lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public Task<DescribeProjectListResponse> DescribeProjectList(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList");
        }

        /// <summary>
        /// This API is used to get project lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectListRequest"/></param>
        /// <returns><see cref="DescribeProjectListResponse"/></returns>
        public DescribeProjectListResponse DescribeProjectListSync(DescribeProjectListRequest req)
        {
            return InternalRequestAsync<DescribeProjectListResponse>(req, "DescribeProjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the latest device session list
        /// </summary>
        /// <param name="req"><see cref="DescribeRecentSessionListRequest"/></param>
        /// <returns><see cref="DescribeRecentSessionListResponse"/></returns>
        public Task<DescribeRecentSessionListResponse> DescribeRecentSessionList(DescribeRecentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeRecentSessionListResponse>(req, "DescribeRecentSessionList");
        }

        /// <summary>
        /// Get the latest device session list
        /// </summary>
        /// <param name="req"><see cref="DescribeRecentSessionListRequest"/></param>
        /// <returns><see cref="DescribeRecentSessionListResponse"/></returns>
        public DescribeRecentSessionListResponse DescribeRecentSessionListSync(DescribeRecentSessionListRequest req)
        {
            return InternalRequestAsync<DescribeRecentSessionListResponse>(req, "DescribeRecentSessionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get session statistical values
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public Task<DescribeSessionStatisticsResponse> DescribeSessionStatistics(DescribeSessionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsResponse>(req, "DescribeSessionStatistics");
        }

        /// <summary>
        /// Get session statistical values
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsResponse"/></returns>
        public DescribeSessionStatisticsResponse DescribeSessionStatisticsSync(DescribeSessionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsResponse>(req, "DescribeSessionStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Getting session statistics for each time period
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public Task<DescribeSessionStatisticsByIntervalResponse> DescribeSessionStatisticsByInterval(DescribeSessionStatisticsByIntervalRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsByIntervalResponse>(req, "DescribeSessionStatisticsByInterval");
        }

        /// <summary>
        /// Getting session statistics for each time period
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionStatisticsByIntervalRequest"/></param>
        /// <returns><see cref="DescribeSessionStatisticsByIntervalResponse"/></returns>
        public DescribeSessionStatisticsByIntervalResponse DescribeSessionStatisticsByIntervalSync(DescribeSessionStatisticsByIntervalRequest req)
        {
            return InternalRequestAsync<DescribeSessionStatisticsByIntervalResponse>(req, "DescribeSessionStatisticsByInterval")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain the quantity of available authorizations already bound to the device
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLicenseRequest"/></param>
        /// <returns><see cref="GetDeviceLicenseResponse"/></returns>
        public Task<GetDeviceLicenseResponse> GetDeviceLicense(GetDeviceLicenseRequest req)
        {
            return InternalRequestAsync<GetDeviceLicenseResponse>(req, "GetDeviceLicense");
        }

        /// <summary>
        /// Obtain the quantity of available authorizations already bound to the device
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLicenseRequest"/></param>
        /// <returns><see cref="GetDeviceLicenseResponse"/></returns>
        public GetDeviceLicenseResponse GetDeviceLicenseSync(GetDeviceLicenseRequest req)
        {
            return InternalRequestAsync<GetDeviceLicenseResponse>(req, "GetDeviceLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the authorization binding status of user devices
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices");
        }

        /// <summary>
        /// Query the authorization binding status of user devices
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Statistics of license types and quantities
        /// </summary>
        /// <param name="req"><see cref="GetLicenseStatRequest"/></param>
        /// <returns><see cref="GetLicenseStatResponse"/></returns>
        public Task<GetLicenseStatResponse> GetLicenseStat(GetLicenseStatRequest req)
        {
            return InternalRequestAsync<GetLicenseStatResponse>(req, "GetLicenseStat");
        }

        /// <summary>
        /// Statistics of license types and quantities
        /// </summary>
        /// <param name="req"><see cref="GetLicenseStatRequest"/></param>
        /// <returns><see cref="GetLicenseStatResponse"/></returns>
        public GetLicenseStatResponse GetLicenseStatSync(GetLicenseStatRequest req)
        {
            return InternalRequestAsync<GetLicenseStatResponse>(req, "GetLicenseStat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View the license list by authorization
        /// </summary>
        /// <param name="req"><see cref="GetLicensesRequest"/></param>
        /// <returns><see cref="GetLicensesResponse"/></returns>
        public Task<GetLicensesResponse> GetLicenses(GetLicensesRequest req)
        {
            return InternalRequestAsync<GetLicensesResponse>(req, "GetLicenses");
        }

        /// <summary>
        /// View the license list by authorization
        /// </summary>
        /// <param name="req"><see cref="GetLicensesRequest"/></param>
        /// <returns><see cref="GetLicensesResponse"/></returns>
        public GetLicensesResponse GetLicensesSync(GetLicensesRequest req)
        {
            return InternalRequestAsync<GetLicensesResponse>(req, "GetLicenses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify device information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice");
        }

        /// <summary>
        /// This API is used to modify device information.
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify permission configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public Task<ModifyPolicyResponse> ModifyPolicy(ModifyPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPolicyResponse>(req, "ModifyPolicy");
        }

        /// <summary>
        /// This API is used to modify permission configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyRequest"/></param>
        /// <returns><see cref="ModifyPolicyResponse"/></returns>
        public ModifyPolicyResponse ModifyPolicySync(ModifyPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPolicyResponse>(req, "ModifyPolicy")
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

    }
}
