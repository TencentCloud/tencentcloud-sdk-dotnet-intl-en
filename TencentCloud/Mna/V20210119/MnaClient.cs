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

namespace TencentCloud.Mna.V20210119
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mna.V20210119.Models;

   public class MnaClient : AbstractClient{

       private const string endpoint = "mna.intl.tencentcloudapi.com";
       private const string version = "2021-01-19";
       private const string sdkVersion = "SDK_NET_3.0.1314";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MnaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MnaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Activate hardware device
        /// </summary>
        /// <param name="req"><see cref="ActivateHardwareRequest"/></param>
        /// <returns><see cref="ActivateHardwareResponse"/></returns>
        public Task<ActivateHardwareResponse> ActivateHardware(ActivateHardwareRequest req)
        {
            return InternalRequestAsync<ActivateHardwareResponse>(req, "ActivateHardware");
        }

        /// <summary>
        /// Activate hardware device
        /// </summary>
        /// <param name="req"><see cref="ActivateHardwareRequest"/></param>
        /// <returns><see cref="ActivateHardwareResponse"/></returns>
        public ActivateHardwareResponse ActivateHardwareSync(ActivateHardwareRequest req)
        {
            return InternalRequestAsync<ActivateHardwareResponse>(req, "ActivateHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an application
        /// </summary>
        /// <param name="req"><see cref="AddApplicationRequest"/></param>
        /// <returns><see cref="AddApplicationResponse"/></returns>
        public Task<AddApplicationResponse> AddApplication(AddApplicationRequest req)
        {
            return InternalRequestAsync<AddApplicationResponse>(req, "AddApplication");
        }

        /// <summary>
        /// This API is used to create an application
        /// </summary>
        /// <param name="req"><see cref="AddApplicationRequest"/></param>
        /// <returns><see cref="AddApplicationResponse"/></returns>
        public AddApplicationResponse AddApplicationSync(AddApplicationRequest req)
        {
            return InternalRequestAsync<AddApplicationResponse>(req, "AddApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create new device records
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public Task<AddDeviceResponse> AddDevice(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice");
        }

        /// <summary>
        /// Create new device records
        /// </summary>
        /// <param name="req"><see cref="AddDeviceRequest"/></param>
        /// <returns><see cref="AddDeviceResponse"/></returns>
        public AddDeviceResponse AddDeviceSync(AddDeviceRequest req)
        {
            return InternalRequestAsync<AddDeviceResponse>(req, "AddDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="req"><see cref="AddGroupRequest"/></param>
        /// <returns><see cref="AddGroupResponse"/></returns>
        public Task<AddGroupResponse> AddGroup(AddGroupRequest req)
        {
            return InternalRequestAsync<AddGroupResponse>(req, "AddGroup");
        }

        /// <summary>
        /// Create group
        /// </summary>
        /// <param name="req"><see cref="AddGroupRequest"/></param>
        /// <returns><see cref="AddGroupResponse"/></returns>
        public AddGroupResponse AddGroupSync(AddGroupRequest req)
        {
            return InternalRequestAsync<AddGroupResponse>(req, "AddGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add hardware devices, generate inactive hardware devices, and support batch addition
        /// </summary>
        /// <param name="req"><see cref="AddHardwareRequest"/></param>
        /// <returns><see cref="AddHardwareResponse"/></returns>
        public Task<AddHardwareResponse> AddHardware(AddHardwareRequest req)
        {
            return InternalRequestAsync<AddHardwareResponse>(req, "AddHardware");
        }

        /// <summary>
        /// Add hardware devices, generate inactive hardware devices, and support batch addition
        /// </summary>
        /// <param name="req"><see cref="AddHardwareRequest"/></param>
        /// <returns><see cref="AddHardwareResponse"/></returns>
        public AddHardwareResponse AddHardwareSync(AddHardwareRequest req)
        {
            return InternalRequestAsync<AddHardwareResponse>(req, "AddHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an interconnection rule
        /// </summary>
        /// <param name="req"><see cref="AddL3ConnRequest"/></param>
        /// <returns><see cref="AddL3ConnResponse"/></returns>
        public Task<AddL3ConnResponse> AddL3Conn(AddL3ConnRequest req)
        {
            return InternalRequestAsync<AddL3ConnResponse>(req, "AddL3Conn");
        }

        /// <summary>
        /// Create an interconnection rule
        /// </summary>
        /// <param name="req"><see cref="AddL3ConnRequest"/></param>
        /// <returns><see cref="AddL3ConnResponse"/></returns>
        public AddL3ConnResponse AddL3ConnSync(AddL3ConnRequest req)
        {
            return InternalRequestAsync<AddL3ConnResponse>(req, "AddL3Conn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure and refresh preset keys.
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public Task<CreateEncryptedKeyResponse> CreateEncryptedKey(CreateEncryptedKeyRequest req)
        {
            return InternalRequestAsync<CreateEncryptedKeyResponse>(req, "CreateEncryptedKey");
        }

        /// <summary>
        /// This API is used to configure and refresh preset keys.
        /// </summary>
        /// <param name="req"><see cref="CreateEncryptedKeyRequest"/></param>
        /// <returns><see cref="CreateEncryptedKeyResponse"/></returns>
        public CreateEncryptedKeyResponse CreateEncryptedKeySync(CreateEncryptedKeyRequest req)
        {
            return InternalRequestAsync<CreateEncryptedKeyResponse>(req, "CreateEncryptedKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public Task<DeleteApplicationResponse> DeleteApplication(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication");
        }

        /// <summary>
        /// This API is used to delete applications
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationRequest"/></param>
        /// <returns><see cref="DeleteApplicationResponse"/></returns>
        public DeleteApplicationResponse DeleteApplicationSync(DeleteApplicationRequest req)
        {
            return InternalRequestAsync<DeleteApplicationResponse>(req, "DeleteApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete device info
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// Delete device info
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete group
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// Delete group
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete an interconnection rule
        /// </summary>
        /// <param name="req"><see cref="DeleteL3ConnRequest"/></param>
        /// <returns><see cref="DeleteL3ConnResponse"/></returns>
        public Task<DeleteL3ConnResponse> DeleteL3Conn(DeleteL3ConnRequest req)
        {
            return InternalRequestAsync<DeleteL3ConnResponse>(req, "DeleteL3Conn");
        }

        /// <summary>
        /// Delete an interconnection rule
        /// </summary>
        /// <param name="req"><see cref="DeleteL3ConnRequest"/></param>
        /// <returns><see cref="DeleteL3ConnResponse"/></returns>
        public DeleteL3ConnResponse DeleteL3ConnSync(DeleteL3ConnRequest req)
        {
            return InternalRequestAsync<DeleteL3ConnResponse>(req, "DeleteL3Conn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download the number of active devices statistics
        /// </summary>
        /// <param name="req"><see cref="DownloadActiveDeviceCountRequest"/></param>
        /// <returns><see cref="DownloadActiveDeviceCountResponse"/></returns>
        public Task<DownloadActiveDeviceCountResponse> DownloadActiveDeviceCount(DownloadActiveDeviceCountRequest req)
        {
            return InternalRequestAsync<DownloadActiveDeviceCountResponse>(req, "DownloadActiveDeviceCount");
        }

        /// <summary>
        /// Download the number of active devices statistics
        /// </summary>
        /// <param name="req"><see cref="DownloadActiveDeviceCountRequest"/></param>
        /// <returns><see cref="DownloadActiveDeviceCountResponse"/></returns>
        public DownloadActiveDeviceCountResponse DownloadActiveDeviceCountSync(DownloadActiveDeviceCountRequest req)
        {
            return InternalRequestAsync<DownloadActiveDeviceCountResponse>(req, "DownloadActiveDeviceCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Number of active devices statistics
        /// </summary>
        /// <param name="req"><see cref="GetActiveDeviceCountRequest"/></param>
        /// <returns><see cref="GetActiveDeviceCountResponse"/></returns>
        public Task<GetActiveDeviceCountResponse> GetActiveDeviceCount(GetActiveDeviceCountRequest req)
        {
            return InternalRequestAsync<GetActiveDeviceCountResponse>(req, "GetActiveDeviceCount");
        }

        /// <summary>
        /// Number of active devices statistics
        /// </summary>
        /// <param name="req"><see cref="GetActiveDeviceCountRequest"/></param>
        /// <returns><see cref="GetActiveDeviceCountResponse"/></returns>
        public GetActiveDeviceCountResponse GetActiveDeviceCountSync(GetActiveDeviceCountRequest req)
        {
            return InternalRequestAsync<GetActiveDeviceCountResponse>(req, "GetActiveDeviceCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query applications.
        /// </summary>
        /// <param name="req"><see cref="GetApplicationRequest"/></param>
        /// <returns><see cref="GetApplicationResponse"/></returns>
        public Task<GetApplicationResponse> GetApplication(GetApplicationRequest req)
        {
            return InternalRequestAsync<GetApplicationResponse>(req, "GetApplication");
        }

        /// <summary>
        /// This API is used to query applications.
        /// </summary>
        /// <param name="req"><see cref="GetApplicationRequest"/></param>
        /// <returns><see cref="GetApplicationResponse"/></returns>
        public GetApplicationResponse GetApplicationSync(GetApplicationRequest req)
        {
            return InternalRequestAsync<GetApplicationResponse>(req, "GetApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Statistics of a single device accessing the target IP address
        /// </summary>
        /// <param name="req"><see cref="GetDestIPByNameRequest"/></param>
        /// <returns><see cref="GetDestIPByNameResponse"/></returns>
        public Task<GetDestIPByNameResponse> GetDestIPByName(GetDestIPByNameRequest req)
        {
            return InternalRequestAsync<GetDestIPByNameResponse>(req, "GetDestIPByName");
        }

        /// <summary>
        /// Statistics of a single device accessing the target IP address
        /// </summary>
        /// <param name="req"><see cref="GetDestIPByNameRequest"/></param>
        /// <returns><see cref="GetDestIPByNameResponse"/></returns>
        public GetDestIPByNameResponse GetDestIPByNameSync(GetDestIPByNameRequest req)
        {
            return InternalRequestAsync<GetDestIPByNameResponse>(req, "GetDestIPByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search device details by specified device ID.
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public Task<GetDeviceResponse> GetDevice(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice");
        }

        /// <summary>
        /// This API is used to search device details by specified device ID.
        /// </summary>
        /// <param name="req"><see cref="GetDeviceRequest"/></param>
        /// <returns><see cref="GetDeviceResponse"/></returns>
        public GetDeviceResponse GetDeviceSync(GetDeviceRequest req)
        {
            return InternalRequestAsync<GetDeviceResponse>(req, "GetDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the payment mode of a device.
        /// </summary>
        /// <param name="req"><see cref="GetDevicePayModeRequest"/></param>
        /// <returns><see cref="GetDevicePayModeResponse"/></returns>
        public Task<GetDevicePayModeResponse> GetDevicePayMode(GetDevicePayModeRequest req)
        {
            return InternalRequestAsync<GetDevicePayModeResponse>(req, "GetDevicePayMode");
        }

        /// <summary>
        /// This API is used to obtain the payment mode of a device.
        /// </summary>
        /// <param name="req"><see cref="GetDevicePayModeRequest"/></param>
        /// <returns><see cref="GetDevicePayModeResponse"/></returns>
        public GetDevicePayModeResponse GetDevicePayModeSync(GetDevicePayModeRequest req)
        {
            return InternalRequestAsync<GetDevicePayModeResponse>(req, "GetDevicePayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get device information list.
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public Task<GetDevicesResponse> GetDevices(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices");
        }

        /// <summary>
        /// This API is used to get device information list.
        /// </summary>
        /// <param name="req"><see cref="GetDevicesRequest"/></param>
        /// <returns><see cref="GetDevicesResponse"/></returns>
        public GetDevicesResponse GetDevicesSync(GetDevicesRequest req)
        {
            return InternalRequestAsync<GetDevicesResponse>(req, "GetDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query user traffic alarm settings based on AppId, including threshold, callback url and key.
        /// </summary>
        /// <param name="req"><see cref="GetFlowAlarmInfoRequest"/></param>
        /// <returns><see cref="GetFlowAlarmInfoResponse"/></returns>
        public Task<GetFlowAlarmInfoResponse> GetFlowAlarmInfo(GetFlowAlarmInfoRequest req)
        {
            return InternalRequestAsync<GetFlowAlarmInfoResponse>(req, "GetFlowAlarmInfo");
        }

        /// <summary>
        /// This API is used to query user traffic alarm settings based on AppId, including threshold, callback url and key.
        /// </summary>
        /// <param name="req"><see cref="GetFlowAlarmInfoRequest"/></param>
        /// <returns><see cref="GetFlowAlarmInfoResponse"/></returns>
        public GetFlowAlarmInfoResponse GetFlowAlarmInfoSync(GetFlowAlarmInfoRequest req)
        {
            return InternalRequestAsync<GetFlowAlarmInfoResponse>(req, "GetFlowAlarmInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the data transfer plan list
        /// </summary>
        /// <param name="req"><see cref="GetFlowPackagesRequest"/></param>
        /// <returns><see cref="GetFlowPackagesResponse"/></returns>
        public Task<GetFlowPackagesResponse> GetFlowPackages(GetFlowPackagesRequest req)
        {
            return InternalRequestAsync<GetFlowPackagesResponse>(req, "GetFlowPackages");
        }

        /// <summary>
        /// Retrieve the data transfer plan list
        /// </summary>
        /// <param name="req"><see cref="GetFlowPackagesRequest"/></param>
        /// <returns><see cref="GetFlowPackagesResponse"/></returns>
        public GetFlowPackagesResponse GetFlowPackagesSync(GetFlowPackagesRequest req)
        {
            return InternalRequestAsync<GetFlowPackagesResponse>(req, "GetFlowPackages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve traffic usage data for a specified device Id at a specified time point.
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public Task<GetFlowStatisticResponse> GetFlowStatistic(GetFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticResponse>(req, "GetFlowStatistic");
        }

        /// <summary>
        /// Retrieve traffic usage data for a specified device Id at a specified time point.
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticRequest"/></param>
        /// <returns><see cref="GetFlowStatisticResponse"/></returns>
        public GetFlowStatisticResponse GetFlowStatisticSync(GetFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticResponse>(req, "GetFlowStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve traffic usage data for the specified group and time period
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByGroupRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByGroupResponse"/></returns>
        public Task<GetFlowStatisticByGroupResponse> GetFlowStatisticByGroup(GetFlowStatisticByGroupRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByGroupResponse>(req, "GetFlowStatisticByGroup");
        }

        /// <summary>
        /// Retrieve traffic usage data for the specified group and time period
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByGroupRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByGroupResponse"/></returns>
        public GetFlowStatisticByGroupResponse GetFlowStatisticByGroupSync(GetFlowStatisticByGroupRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByGroupResponse>(req, "GetFlowStatisticByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve traffic usage data for a specified device Id at a specified time point.
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByNameRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByNameResponse"/></returns>
        public Task<GetFlowStatisticByNameResponse> GetFlowStatisticByName(GetFlowStatisticByNameRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByNameResponse>(req, "GetFlowStatisticByName");
        }

        /// <summary>
        /// Retrieve traffic usage data for a specified device Id at a specified time point.
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByNameRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByNameResponse"/></returns>
        public GetFlowStatisticByNameResponse GetFlowStatisticByNameSync(GetFlowStatisticByNameRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByNameResponse>(req, "GetFlowStatisticByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve traffic usage data for the specified region and time point
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByRegionRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByRegionResponse"/></returns>
        public Task<GetFlowStatisticByRegionResponse> GetFlowStatisticByRegion(GetFlowStatisticByRegionRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByRegionResponse>(req, "GetFlowStatisticByRegion");
        }

        /// <summary>
        /// Retrieve traffic usage data for the specified region and time point
        /// </summary>
        /// <param name="req"><see cref="GetFlowStatisticByRegionRequest"/></param>
        /// <returns><see cref="GetFlowStatisticByRegionResponse"/></returns>
        public GetFlowStatisticByRegionResponse GetFlowStatisticByRegionSync(GetFlowStatisticByRegionRequest req)
        {
            return InternalRequestAsync<GetFlowStatisticByRegionResponse>(req, "GetFlowStatisticByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// View group details
        /// </summary>
        /// <param name="req"><see cref="GetGroupDetailRequest"/></param>
        /// <returns><see cref="GetGroupDetailResponse"/></returns>
        public Task<GetGroupDetailResponse> GetGroupDetail(GetGroupDetailRequest req)
        {
            return InternalRequestAsync<GetGroupDetailResponse>(req, "GetGroupDetail");
        }

        /// <summary>
        /// View group details
        /// </summary>
        /// <param name="req"><see cref="GetGroupDetailRequest"/></param>
        /// <returns><see cref="GetGroupDetailResponse"/></returns>
        public GetGroupDetailResponse GetGroupDetailSync(GetGroupDetailRequest req)
        {
            return InternalRequestAsync<GetGroupDetailResponse>(req, "GetGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a group list.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList");
        }

        /// <summary>
        /// This API is used to obtain a group list.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get hardware device information.
        /// </summary>
        /// <param name="req"><see cref="GetHardwareInfoRequest"/></param>
        /// <returns><see cref="GetHardwareInfoResponse"/></returns>
        public Task<GetHardwareInfoResponse> GetHardwareInfo(GetHardwareInfoRequest req)
        {
            return InternalRequestAsync<GetHardwareInfoResponse>(req, "GetHardwareInfo");
        }

        /// <summary>
        /// This API is used to get hardware device information.
        /// </summary>
        /// <param name="req"><see cref="GetHardwareInfoRequest"/></param>
        /// <returns><see cref="GetHardwareInfoResponse"/></returns>
        public GetHardwareInfoResponse GetHardwareInfoSync(GetHardwareInfoRequest req)
        {
            return InternalRequestAsync<GetHardwareInfoResponse>(req, "GetHardwareInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the hardware list of the manufacturer.
        /// </summary>
        /// <param name="req"><see cref="GetHardwareListRequest"/></param>
        /// <returns><see cref="GetHardwareListResponse"/></returns>
        public Task<GetHardwareListResponse> GetHardwareList(GetHardwareListRequest req)
        {
            return InternalRequestAsync<GetHardwareListResponse>(req, "GetHardwareList");
        }

        /// <summary>
        /// This API is used to get the hardware list of the manufacturer.
        /// </summary>
        /// <param name="req"><see cref="GetHardwareListRequest"/></param>
        /// <returns><see cref="GetHardwareListResponse"/></returns>
        public GetHardwareListResponse GetHardwareListSync(GetHardwareListRequest req)
        {
            return InternalRequestAsync<GetHardwareListResponse>(req, "GetHardwareList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve the list of interconnection rules
        /// </summary>
        /// <param name="req"><see cref="GetL3ConnListRequest"/></param>
        /// <returns><see cref="GetL3ConnListResponse"/></returns>
        public Task<GetL3ConnListResponse> GetL3ConnList(GetL3ConnListRequest req)
        {
            return InternalRequestAsync<GetL3ConnListResponse>(req, "GetL3ConnList");
        }

        /// <summary>
        /// Retrieve the list of interconnection rules
        /// </summary>
        /// <param name="req"><see cref="GetL3ConnListRequest"/></param>
        /// <returns><see cref="GetL3ConnListResponse"/></returns>
        public GetL3ConnListResponse GetL3ConnListSync(GetL3ConnListRequest req)
        {
            return InternalRequestAsync<GetL3ConnListResponse>(req, "GetL3ConnList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the download file URL for all monitoring metrics of a single device.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataByNameRequest"/></param>
        /// <returns><see cref="GetMonitorDataByNameResponse"/></returns>
        public Task<GetMonitorDataByNameResponse> GetMonitorDataByName(GetMonitorDataByNameRequest req)
        {
            return InternalRequestAsync<GetMonitorDataByNameResponse>(req, "GetMonitorDataByName");
        }

        /// <summary>
        /// This API is used to obtain the download file URL for all monitoring metrics of a single device.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataByNameRequest"/></param>
        /// <returns><see cref="GetMonitorDataByNameResponse"/></returns>
        public GetMonitorDataByNameResponse GetMonitorDataByNameSync(GetMonitorDataByNameRequest req)
        {
            return InternalRequestAsync<GetMonitorDataByNameResponse>(req, "GetMonitorDataByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtain batch device traffic statistics curves
        /// </summary>
        /// <param name="req"><see cref="GetMultiFlowStatisticRequest"/></param>
        /// <returns><see cref="GetMultiFlowStatisticResponse"/></returns>
        public Task<GetMultiFlowStatisticResponse> GetMultiFlowStatistic(GetMultiFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetMultiFlowStatisticResponse>(req, "GetMultiFlowStatistic");
        }

        /// <summary>
        /// Obtain batch device traffic statistics curves
        /// </summary>
        /// <param name="req"><see cref="GetMultiFlowStatisticRequest"/></param>
        /// <returns><see cref="GetMultiFlowStatisticResponse"/></returns>
        public GetMultiFlowStatisticResponse GetMultiFlowStatisticSync(GetMultiFlowStatisticRequest req)
        {
            return InternalRequestAsync<GetMultiFlowStatisticResponse>(req, "GetMultiFlowStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain real-time traffic statistics per device.
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorRequest"/></param>
        /// <returns><see cref="GetNetMonitorResponse"/></returns>
        public Task<GetNetMonitorResponse> GetNetMonitor(GetNetMonitorRequest req)
        {
            return InternalRequestAsync<GetNetMonitorResponse>(req, "GetNetMonitor");
        }

        /// <summary>
        /// This API is used to obtain real-time traffic statistics per device.
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorRequest"/></param>
        /// <returns><see cref="GetNetMonitorResponse"/></returns>
        public GetNetMonitorResponse GetNetMonitorSync(GetNetMonitorRequest req)
        {
            return InternalRequestAsync<GetNetMonitorResponse>(req, "GetNetMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain real-time traffic statistics per device.
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorByNameRequest"/></param>
        /// <returns><see cref="GetNetMonitorByNameResponse"/></returns>
        public Task<GetNetMonitorByNameResponse> GetNetMonitorByName(GetNetMonitorByNameRequest req)
        {
            return InternalRequestAsync<GetNetMonitorByNameResponse>(req, "GetNetMonitorByName");
        }

        /// <summary>
        /// This API is used to obtain real-time traffic statistics per device.
        /// </summary>
        /// <param name="req"><see cref="GetNetMonitorByNameRequest"/></param>
        /// <returns><see cref="GetNetMonitorByNameResponse"/></returns>
        public GetNetMonitorByNameResponse GetNetMonitorByNameSync(GetNetMonitorByNameRequest req)
        {
            return InternalRequestAsync<GetNetMonitorByNameResponse>(req, "GetNetMonitorByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to access the public key for signature verification.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey");
        }

        /// <summary>
        /// This API is used to access the public key for signature verification.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download traffic data on the usage statistics page
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public Task<GetStatisticDataResponse> GetStatisticData(GetStatisticDataRequest req)
        {
            return InternalRequestAsync<GetStatisticDataResponse>(req, "GetStatisticData");
        }

        /// <summary>
        /// Download traffic data on the usage statistics page
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataRequest"/></param>
        /// <returns><see cref="GetStatisticDataResponse"/></returns>
        public GetStatisticDataResponse GetStatisticDataSync(GetStatisticDataRequest req)
        {
            return InternalRequestAsync<GetStatisticDataResponse>(req, "GetStatisticData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Download traffic data on the usage statistics page
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataByNameRequest"/></param>
        /// <returns><see cref="GetStatisticDataByNameResponse"/></returns>
        public Task<GetStatisticDataByNameResponse> GetStatisticDataByName(GetStatisticDataByNameRequest req)
        {
            return InternalRequestAsync<GetStatisticDataByNameResponse>(req, "GetStatisticDataByName");
        }

        /// <summary>
        /// Download traffic data on the usage statistics page
        /// </summary>
        /// <param name="req"><see cref="GetStatisticDataByNameRequest"/></param>
        /// <returns><see cref="GetStatisticDataByNameResponse"/></returns>
        public GetStatisticDataByNameResponse GetStatisticDataByNameSync(GetStatisticDataByNameRequest req)
        {
            return InternalRequestAsync<GetStatisticDataByNameResponse>(req, "GetStatisticDataByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the hardware device list of the manufacturer.
        /// </summary>
        /// <param name="req"><see cref="GetVendorHardwareRequest"/></param>
        /// <returns><see cref="GetVendorHardwareResponse"/></returns>
        public Task<GetVendorHardwareResponse> GetVendorHardware(GetVendorHardwareRequest req)
        {
            return InternalRequestAsync<GetVendorHardwareResponse>(req, "GetVendorHardware");
        }

        /// <summary>
        /// This API is used to get the hardware device list of the manufacturer.
        /// </summary>
        /// <param name="req"><see cref="GetVendorHardwareRequest"/></param>
        /// <returns><see cref="GetVendorHardwareResponse"/></returns>
        public GetVendorHardwareResponse GetVendorHardwareSync(GetVendorHardwareRequest req)
        {
            return InternalRequestAsync<GetVendorHardwareResponse>(req, "GetVendorHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add device to already exist group
        /// </summary>
        /// <param name="req"><see cref="GroupAddDeviceRequest"/></param>
        /// <returns><see cref="GroupAddDeviceResponse"/></returns>
        public Task<GroupAddDeviceResponse> GroupAddDevice(GroupAddDeviceRequest req)
        {
            return InternalRequestAsync<GroupAddDeviceResponse>(req, "GroupAddDevice");
        }

        /// <summary>
        /// Add device to already exist group
        /// </summary>
        /// <param name="req"><see cref="GroupAddDeviceRequest"/></param>
        /// <returns><see cref="GroupAddDeviceResponse"/></returns>
        public GroupAddDeviceResponse GroupAddDeviceSync(GroupAddDeviceRequest req)
        {
            return InternalRequestAsync<GroupAddDeviceResponse>(req, "GroupAddDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete devices in the group
        /// </summary>
        /// <param name="req"><see cref="GroupDeleteDeviceRequest"/></param>
        /// <returns><see cref="GroupDeleteDeviceResponse"/></returns>
        public Task<GroupDeleteDeviceResponse> GroupDeleteDevice(GroupDeleteDeviceRequest req)
        {
            return InternalRequestAsync<GroupDeleteDeviceResponse>(req, "GroupDeleteDevice");
        }

        /// <summary>
        /// Delete devices in the group
        /// </summary>
        /// <param name="req"><see cref="GroupDeleteDeviceRequest"/></param>
        /// <returns><see cref="GroupDeleteDeviceResponse"/></returns>
        public GroupDeleteDeviceResponse GroupDeleteDeviceSync(GroupDeleteDeviceRequest req)
        {
            return InternalRequestAsync<GroupDeleteDeviceResponse>(req, "GroupDeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Auto renewal of data transfer plans can be enabled or disabled, unaffected by ongoing effective plans in the current cycle.
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyPackageRenewFlagResponse"/></returns>
        public Task<ModifyPackageRenewFlagResponse> ModifyPackageRenewFlag(ModifyPackageRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyPackageRenewFlagResponse>(req, "ModifyPackageRenewFlag");
        }

        /// <summary>
        /// Auto renewal of data transfer plans can be enabled or disabled, unaffected by ongoing effective plans in the current cycle.
        /// </summary>
        /// <param name="req"><see cref="ModifyPackageRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyPackageRenewFlagResponse"/></returns>
        public ModifyPackageRenewFlagResponse ModifyPackageRenewFlagSync(ModifyPackageRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyPackageRenewFlagResponse>(req, "ModifyPackageRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Purchase a Prepaid Traffic Package
        /// </summary>
        /// <param name="req"><see cref="OrderFlowPackageRequest"/></param>
        /// <returns><see cref="OrderFlowPackageResponse"/></returns>
        public Task<OrderFlowPackageResponse> OrderFlowPackage(OrderFlowPackageRequest req)
        {
            return InternalRequestAsync<OrderFlowPackageResponse>(req, "OrderFlowPackage");
        }

        /// <summary>
        /// Purchase a Prepaid Traffic Package
        /// </summary>
        /// <param name="req"><see cref="OrderFlowPackageRequest"/></param>
        /// <returns><see cref="OrderFlowPackageResponse"/></returns>
        public OrderFlowPackageResponse OrderFlowPackageSync(OrderFlowPackageRequest req)
        {
            return InternalRequestAsync<OrderFlowPackageResponse>(req, "OrderFlowPackage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Purchase a single-use License
        /// </summary>
        /// <param name="req"><see cref="OrderPerLicenseRequest"/></param>
        /// <returns><see cref="OrderPerLicenseResponse"/></returns>
        public Task<OrderPerLicenseResponse> OrderPerLicense(OrderPerLicenseRequest req)
        {
            return InternalRequestAsync<OrderPerLicenseResponse>(req, "OrderPerLicense");
        }

        /// <summary>
        /// Purchase a single-use License
        /// </summary>
        /// <param name="req"><see cref="OrderPerLicenseRequest"/></param>
        /// <returns><see cref="OrderPerLicenseResponse"/></returns>
        public OrderPerLicenseResponse OrderPerLicenseSync(OrderPerLicenseRequest req)
        {
            return InternalRequestAsync<OrderPerLicenseResponse>(req, "OrderPerLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Users report custom order information, and the Multiple Network Acceleration service saves the information related to.
        /// </summary>
        /// <param name="req"><see cref="ReportOrderRequest"/></param>
        /// <returns><see cref="ReportOrderResponse"/></returns>
        public Task<ReportOrderResponse> ReportOrder(ReportOrderRequest req)
        {
            return InternalRequestAsync<ReportOrderResponse>(req, "ReportOrder");
        }

        /// <summary>
        /// Users report custom order information, and the Multiple Network Acceleration service saves the information related to.
        /// </summary>
        /// <param name="req"><see cref="ReportOrderRequest"/></param>
        /// <returns><see cref="ReportOrderResponse"/></returns>
        public ReportOrderResponse ReportOrderSync(ReportOrderRequest req)
        {
            return InternalRequestAsync<ReportOrderResponse>(req, "ReportOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set user traffic alarm information. Use this API setting to configure the data transfer plan alarm threshold as well as the callback url and key when an alarm is generated.
        /// </summary>
        /// <param name="req"><see cref="SetNotifyUrlRequest"/></param>
        /// <returns><see cref="SetNotifyUrlResponse"/></returns>
        public Task<SetNotifyUrlResponse> SetNotifyUrl(SetNotifyUrlRequest req)
        {
            return InternalRequestAsync<SetNotifyUrlResponse>(req, "SetNotifyUrl");
        }

        /// <summary>
        /// This API is used to set user traffic alarm information. Use this API setting to configure the data transfer plan alarm threshold as well as the callback url and key when an alarm is generated.
        /// </summary>
        /// <param name="req"><see cref="SetNotifyUrlRequest"/></param>
        /// <returns><see cref="SetNotifyUrlResponse"/></returns>
        public SetNotifyUrlResponse SetNotifyUrlSync(SetNotifyUrlRequest req)
        {
            return InternalRequestAsync<SetNotifyUrlResponse>(req, "SetNotifyUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update application information
        /// </summary>
        /// <param name="req"><see cref="UpdateApplicationInfoRequest"/></param>
        /// <returns><see cref="UpdateApplicationInfoResponse"/></returns>
        public Task<UpdateApplicationInfoResponse> UpdateApplicationInfo(UpdateApplicationInfoRequest req)
        {
            return InternalRequestAsync<UpdateApplicationInfoResponse>(req, "UpdateApplicationInfo");
        }

        /// <summary>
        /// Update application information
        /// </summary>
        /// <param name="req"><see cref="UpdateApplicationInfoRequest"/></param>
        /// <returns><see cref="UpdateApplicationInfoResponse"/></returns>
        public UpdateApplicationInfoResponse UpdateApplicationInfoSync(UpdateApplicationInfoRequest req)
        {
            return InternalRequestAsync<UpdateApplicationInfoResponse>(req, "UpdateApplicationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update application key
        /// </summary>
        /// <param name="req"><see cref="UpdateApplicationKeyRequest"/></param>
        /// <returns><see cref="UpdateApplicationKeyResponse"/></returns>
        public Task<UpdateApplicationKeyResponse> UpdateApplicationKey(UpdateApplicationKeyRequest req)
        {
            return InternalRequestAsync<UpdateApplicationKeyResponse>(req, "UpdateApplicationKey");
        }

        /// <summary>
        /// Update application key
        /// </summary>
        /// <param name="req"><see cref="UpdateApplicationKeyRequest"/></param>
        /// <returns><see cref="UpdateApplicationKeyResponse"/></returns>
        public UpdateApplicationKeyResponse UpdateApplicationKeySync(UpdateApplicationKeyRequest req)
        {
            return InternalRequestAsync<UpdateApplicationKeyResponse>(req, "UpdateApplicationKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update device information
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public Task<UpdateDeviceResponse> UpdateDevice(UpdateDeviceRequest req)
        {
            return InternalRequestAsync<UpdateDeviceResponse>(req, "UpdateDevice");
        }

        /// <summary>
        /// Update device information
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceRequest"/></param>
        /// <returns><see cref="UpdateDeviceResponse"/></returns>
        public UpdateDeviceResponse UpdateDeviceSync(UpdateDeviceRequest req)
        {
            return InternalRequestAsync<UpdateDeviceResponse>(req, "UpdateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update group remark
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public Task<UpdateGroupResponse> UpdateGroup(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup");
        }

        /// <summary>
        /// Update group remark
        /// </summary>
        /// <param name="req"><see cref="UpdateGroupRequest"/></param>
        /// <returns><see cref="UpdateGroupResponse"/></returns>
        public UpdateGroupResponse UpdateGroupSync(UpdateGroupRequest req)
        {
            return InternalRequestAsync<UpdateGroupResponse>(req, "UpdateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refresh hardware info
        /// </summary>
        /// <param name="req"><see cref="UpdateHardwareRequest"/></param>
        /// <returns><see cref="UpdateHardwareResponse"/></returns>
        public Task<UpdateHardwareResponse> UpdateHardware(UpdateHardwareRequest req)
        {
            return InternalRequestAsync<UpdateHardwareResponse>(req, "UpdateHardware");
        }

        /// <summary>
        /// Refresh hardware info
        /// </summary>
        /// <param name="req"><see cref="UpdateHardwareRequest"/></param>
        /// <returns><see cref="UpdateHardwareResponse"/></returns>
        public UpdateHardwareResponse UpdateHardwareSync(UpdateHardwareRequest req)
        {
            return InternalRequestAsync<UpdateHardwareResponse>(req, "UpdateHardware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the interconnection rule CIDR
        /// </summary>
        /// <param name="req"><see cref="UpdateL3CidrRequest"/></param>
        /// <returns><see cref="UpdateL3CidrResponse"/></returns>
        public Task<UpdateL3CidrResponse> UpdateL3Cidr(UpdateL3CidrRequest req)
        {
            return InternalRequestAsync<UpdateL3CidrResponse>(req, "UpdateL3Cidr");
        }

        /// <summary>
        /// Update the interconnection rule CIDR
        /// </summary>
        /// <param name="req"><see cref="UpdateL3CidrRequest"/></param>
        /// <returns><see cref="UpdateL3CidrResponse"/></returns>
        public UpdateL3CidrResponse UpdateL3CidrSync(UpdateL3CidrRequest req)
        {
            return InternalRequestAsync<UpdateL3CidrResponse>(req, "UpdateL3Cidr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the interconnection rule remark
        /// </summary>
        /// <param name="req"><see cref="UpdateL3ConnRequest"/></param>
        /// <returns><see cref="UpdateL3ConnResponse"/></returns>
        public Task<UpdateL3ConnResponse> UpdateL3Conn(UpdateL3ConnRequest req)
        {
            return InternalRequestAsync<UpdateL3ConnResponse>(req, "UpdateL3Conn");
        }

        /// <summary>
        /// Update the interconnection rule remark
        /// </summary>
        /// <param name="req"><see cref="UpdateL3ConnRequest"/></param>
        /// <returns><see cref="UpdateL3ConnResponse"/></returns>
        public UpdateL3ConnResponse UpdateL3ConnSync(UpdateL3ConnRequest req)
        {
            return InternalRequestAsync<UpdateL3ConnResponse>(req, "UpdateL3Conn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the interconnection rule switch
        /// </summary>
        /// <param name="req"><see cref="UpdateL3SwitchRequest"/></param>
        /// <returns><see cref="UpdateL3SwitchResponse"/></returns>
        public Task<UpdateL3SwitchResponse> UpdateL3Switch(UpdateL3SwitchRequest req)
        {
            return InternalRequestAsync<UpdateL3SwitchResponse>(req, "UpdateL3Switch");
        }

        /// <summary>
        /// Update the interconnection rule switch
        /// </summary>
        /// <param name="req"><see cref="UpdateL3SwitchRequest"/></param>
        /// <returns><see cref="UpdateL3SwitchResponse"/></returns>
        public UpdateL3SwitchResponse UpdateL3SwitchSync(UpdateL3SwitchRequest req)
        {
            return InternalRequestAsync<UpdateL3SwitchResponse>(req, "UpdateL3Switch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
