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

namespace TencentCloud.Iss.V20230517
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iss.V20230517.Models;

   public class IssClient : AbstractClient{

       private const string endpoint = "iss.intl.tencentcloudapi.com";
       private const string version = "2023-05-17";
       private const string sdkVersion = "SDK_NET_3.0.1415";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Used to add an organization.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public Task<AddOrganizationResponse> AddOrganization(AddOrganizationRequest req)
        {
            return InternalRequestAsync<AddOrganizationResponse>(req, "AddOrganization");
        }

        /// <summary>
        /// Used to add an organization.
        /// </summary>
        /// <param name="req"><see cref="AddOrganizationRequest"/></param>
        /// <returns><see cref="AddOrganizationResponse"/></returns>
        public AddOrganizationResponse AddOrganizationSync(AddOrganizationRequest req)
        {
            return InternalRequestAsync<AddOrganizationResponse>(req, "AddOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to add a recording cloud migration plan (currently applicable only to devices/video channels connected via the GB28181 protocol and gateway).
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public Task<AddRecordBackupPlanResponse> AddRecordBackupPlan(AddRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<AddRecordBackupPlanResponse>(req, "AddRecordBackupPlan");
        }

        /// <summary>
        /// Used to add a recording cloud migration plan (currently applicable only to devices/video channels connected via the GB28181 protocol and gateway).
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupPlanRequest"/></param>
        /// <returns><see cref="AddRecordBackupPlanResponse"/></returns>
        public AddRecordBackupPlanResponse AddRecordBackupPlanSync(AddRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<AddRecordBackupPlanResponse>(req, "AddRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a video recording cloud template.
        /// > The feature essentially pulls local device recording data to the cloud (i.e., recordings stored in the IPC camera memory card or NVR hard disk). When operating, first set the recording time period (i.e., the local device recording you want to upload to the cloud), then set the Cloud Upload Time Period and upload speed. The platform will pull the previous day's Time Period Data from the device at the specified speed during the Cloud Upload Time Period.
        /// 
        /// > Set the Cloud Upload Time Period to at least meet (Cloud Upload Time Period = previous day's recording time period / cloud upload speed multiplication). It is advisable to set about 10% more time for the Cloud Upload Time Period to avoid incomplete data retrieval due to network fluctuations.
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="AddRecordBackupTemplateResponse"/></returns>
        public Task<AddRecordBackupTemplateResponse> AddRecordBackupTemplate(AddRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordBackupTemplateResponse>(req, "AddRecordBackupTemplate");
        }

        /// <summary>
        /// This API is used to create a video recording cloud template.
        /// > The feature essentially pulls local device recording data to the cloud (i.e., recordings stored in the IPC camera memory card or NVR hard disk). When operating, first set the recording time period (i.e., the local device recording you want to upload to the cloud), then set the Cloud Upload Time Period and upload speed. The platform will pull the previous day's Time Period Data from the device at the specified speed during the Cloud Upload Time Period.
        /// 
        /// > Set the Cloud Upload Time Period to at least meet (Cloud Upload Time Period = previous day's recording time period / cloud upload speed multiplication). It is advisable to set about 10% more time for the Cloud Upload Time Period to avoid incomplete data retrieval due to network fluctuations.
        /// </summary>
        /// <param name="req"><see cref="AddRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="AddRecordBackupTemplateResponse"/></returns>
        public AddRecordBackupTemplateResponse AddRecordBackupTemplateSync(AddRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordBackupTemplateResponse>(req, "AddRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public Task<AddRecordPlanResponse> AddRecordPlan(AddRecordPlanRequest req)
        {
            return InternalRequestAsync<AddRecordPlanResponse>(req, "AddRecordPlan");
        }

        /// <summary>
        /// This API is used to create a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="AddRecordPlanRequest"/></param>
        /// <returns><see cref="AddRecordPlanResponse"/></returns>
        public AddRecordPlanResponse AddRecordPlanSync(AddRecordPlanRequest req)
        {
            return InternalRequestAsync<AddRecordPlanResponse>(req, "AddRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a retrieval task.
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public Task<AddRecordRetrieveTaskResponse> AddRecordRetrieveTask(AddRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<AddRecordRetrieveTaskResponse>(req, "AddRecordRetrieveTask");
        }

        /// <summary>
        /// This API is used to create a retrieval task.
        /// </summary>
        /// <param name="req"><see cref="AddRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="AddRecordRetrieveTaskResponse"/></returns>
        public AddRecordRetrieveTaskResponse AddRecordRetrieveTaskSync(AddRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<AddRecordRetrieveTaskResponse>(req, "AddRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to add a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public Task<AddRecordTemplateResponse> AddRecordTemplate(AddRecordTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordTemplateResponse>(req, "AddRecordTemplate");
        }

        /// <summary>
        /// Used to add a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="AddRecordTemplateRequest"/></param>
        /// <returns><see cref="AddRecordTemplateResponse"/></returns>
        public AddRecordTemplateResponse AddRecordTemplateSync(AddRecordTemplateRequest req)
        {
            return InternalRequestAsync<AddRecordTemplateResponse>(req, "AddRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to set push/pull stream authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public Task<AddStreamAuthResponse> AddStreamAuth(AddStreamAuthRequest req)
        {
            return InternalRequestAsync<AddStreamAuthResponse>(req, "AddStreamAuth");
        }

        /// <summary>
        /// Used to set push/pull stream authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="AddStreamAuthRequest"/></param>
        /// <returns><see cref="AddStreamAuthResponse"/></returns>
        public AddStreamAuthResponse AddStreamAuthSync(AddStreamAuthRequest req)
        {
            return InternalRequestAsync<AddStreamAuthResponse>(req, "AddStreamAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a single device. After the device is added, configure it based on the returned results, then wait for device registration or stream pushing.
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public Task<AddUserDeviceResponse> AddUserDevice(AddUserDeviceRequest req)
        {
            return InternalRequestAsync<AddUserDeviceResponse>(req, "AddUserDevice");
        }

        /// <summary>
        /// This API is used to add a single device. After the device is added, configure it based on the returned results, then wait for device registration or stream pushing.
        /// </summary>
        /// <param name="req"><see cref="AddUserDeviceRequest"/></param>
        /// <returns><see cref="AddUserDeviceResponse"/></returns>
        public AddUserDeviceResponse AddUserDeviceSync(AddUserDeviceRequest req)
        {
            return InternalRequestAsync<AddUserDeviceResponse>(req, "AddUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Add channels for screenshot configuration in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchAddVideoSnapshotConfigChannelRequest"/></param>
        /// <returns><see cref="BatchAddVideoSnapshotConfigChannelResponse"/></returns>
        public Task<BatchAddVideoSnapshotConfigChannelResponse> BatchAddVideoSnapshotConfigChannel(BatchAddVideoSnapshotConfigChannelRequest req)
        {
            return InternalRequestAsync<BatchAddVideoSnapshotConfigChannelResponse>(req, "BatchAddVideoSnapshotConfigChannel");
        }

        /// <summary>
        /// Add channels for screenshot configuration in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchAddVideoSnapshotConfigChannelRequest"/></param>
        /// <returns><see cref="BatchAddVideoSnapshotConfigChannelResponse"/></returns>
        public BatchAddVideoSnapshotConfigChannelResponse BatchAddVideoSnapshotConfigChannelSync(BatchAddVideoSnapshotConfigChannelRequest req)
        {
            return InternalRequestAsync<BatchAddVideoSnapshotConfigChannelResponse>(req, "BatchAddVideoSnapshotConfigChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch associate visual understanding plan channels
        /// </summary>
        /// <param name="req"><see cref="BatchAssignVLPlanChannelsRequest"/></param>
        /// <returns><see cref="BatchAssignVLPlanChannelsResponse"/></returns>
        public Task<BatchAssignVLPlanChannelsResponse> BatchAssignVLPlanChannels(BatchAssignVLPlanChannelsRequest req)
        {
            return InternalRequestAsync<BatchAssignVLPlanChannelsResponse>(req, "BatchAssignVLPlanChannels");
        }

        /// <summary>
        /// Batch associate visual understanding plan channels
        /// </summary>
        /// <param name="req"><see cref="BatchAssignVLPlanChannelsRequest"/></param>
        /// <returns><see cref="BatchAssignVLPlanChannelsResponse"/></returns>
        public BatchAssignVLPlanChannelsResponse BatchAssignVLPlanChannelsSync(BatchAssignVLPlanChannelsRequest req)
        {
            return InternalRequestAsync<BatchAssignVLPlanChannelsResponse>(req, "BatchAssignVLPlanChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete failed local recording download tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="BatchDeleteVideoDownloadTaskResponse"/></returns>
        public Task<BatchDeleteVideoDownloadTaskResponse> BatchDeleteVideoDownloadTask(BatchDeleteVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<BatchDeleteVideoDownloadTaskResponse>(req, "BatchDeleteVideoDownloadTask");
        }

        /// <summary>
        /// This API is used to delete failed local recording download tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="BatchDeleteVideoDownloadTaskResponse"/></returns>
        public BatchDeleteVideoDownloadTaskResponse BatchDeleteVideoDownloadTaskSync(BatchDeleteVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<BatchDeleteVideoDownloadTaskResponse>(req, "BatchDeleteVideoDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch obtain source material URLs for visual understanding plans.
        /// </summary>
        /// <param name="req"><see cref="BatchGetVLPlanSourceFileURLRequest"/></param>
        /// <returns><see cref="BatchGetVLPlanSourceFileURLResponse"/></returns>
        public Task<BatchGetVLPlanSourceFileURLResponse> BatchGetVLPlanSourceFileURL(BatchGetVLPlanSourceFileURLRequest req)
        {
            return InternalRequestAsync<BatchGetVLPlanSourceFileURLResponse>(req, "BatchGetVLPlanSourceFileURL");
        }

        /// <summary>
        /// This API is used to batch obtain source material URLs for visual understanding plans.
        /// </summary>
        /// <param name="req"><see cref="BatchGetVLPlanSourceFileURLRequest"/></param>
        /// <returns><see cref="BatchGetVLPlanSourceFileURLResponse"/></returns>
        public BatchGetVLPlanSourceFileURLResponse BatchGetVLPlanSourceFileURLSync(BatchGetVLPlanSourceFileURLRequest req)
        {
            return InternalRequestAsync<BatchGetVLPlanSourceFileURLResponse>(req, "BatchGetVLPlanSourceFileURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bulk gets screenshot image URLs
        /// </summary>
        /// <param name="req"><see cref="BatchGetVideoSnapshotImageUrlRequest"/></param>
        /// <returns><see cref="BatchGetVideoSnapshotImageUrlResponse"/></returns>
        public Task<BatchGetVideoSnapshotImageUrlResponse> BatchGetVideoSnapshotImageUrl(BatchGetVideoSnapshotImageUrlRequest req)
        {
            return InternalRequestAsync<BatchGetVideoSnapshotImageUrlResponse>(req, "BatchGetVideoSnapshotImageUrl");
        }

        /// <summary>
        /// Bulk gets screenshot image URLs
        /// </summary>
        /// <param name="req"><see cref="BatchGetVideoSnapshotImageUrlRequest"/></param>
        /// <returns><see cref="BatchGetVideoSnapshotImageUrlResponse"/></returns>
        public BatchGetVideoSnapshotImageUrlResponse BatchGetVideoSnapshotImageUrlSync(BatchGetVideoSnapshotImageUrlRequest req)
        {
            return InternalRequestAsync<BatchGetVideoSnapshotImageUrlResponse>(req, "BatchGetVideoSnapshotImageUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used for batch operations (enable, disable, delete) on devices.
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public Task<BatchOperateDeviceResponse> BatchOperateDevice(BatchOperateDeviceRequest req)
        {
            return InternalRequestAsync<BatchOperateDeviceResponse>(req, "BatchOperateDevice");
        }

        /// <summary>
        /// Used for batch operations (enable, disable, delete) on devices.
        /// </summary>
        /// <param name="req"><see cref="BatchOperateDeviceRequest"/></param>
        /// <returns><see cref="BatchOperateDeviceResponse"/></returns>
        public BatchOperateDeviceResponse BatchOperateDeviceSync(BatchOperateDeviceRequest req)
        {
            return InternalRequestAsync<BatchOperateDeviceResponse>(req, "BatchOperateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API can be based on the Hikvision ISUP 5.0 protocol to pass through ISAPI request data. Before calling the API, ensure the device has successfully registered to this platform using the ISUP protocol.
        /// </summary>
        /// <param name="req"><see cref="CallISAPIRequest"/></param>
        /// <returns><see cref="CallISAPIResponse"/></returns>
        public Task<CallISAPIResponse> CallISAPI(CallISAPIRequest req)
        {
            return InternalRequestAsync<CallISAPIResponse>(req, "CallISAPI");
        }

        /// <summary>
        /// This API can be based on the Hikvision ISUP 5.0 protocol to pass through ISAPI request data. Before calling the API, ensure the device has successfully registered to this platform using the ISUP protocol.
        /// </summary>
        /// <param name="req"><see cref="CallISAPIRequest"/></param>
        /// <returns><see cref="CallISAPIResponse"/></returns>
        public CallISAPIResponse CallISAPISync(CallISAPIRequest req)
        {
            return InternalRequestAsync<CallISAPIResponse>(req, "CallISAPI")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used for device channel panning control, including turn, zoom scale, zoom, and aperture.
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public Task<ControlDevicePTZResponse> ControlDevicePTZ(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ");
        }

        /// <summary>
        /// Used for device channel panning control, including turn, zoom scale, zoom, and aperture.
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePTZRequest"/></param>
        /// <returns><see cref="ControlDevicePTZResponse"/></returns>
        public ControlDevicePTZResponse ControlDevicePTZSync(ControlDevicePTZRequest req)
        {
            return InternalRequestAsync<ControlDevicePTZResponse>(req, "ControlDevicePTZ")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to operate device preset positions, including settings, deletion, and calls.
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public Task<ControlDevicePresetResponse> ControlDevicePreset(ControlDevicePresetRequest req)
        {
            return InternalRequestAsync<ControlDevicePresetResponse>(req, "ControlDevicePreset");
        }

        /// <summary>
        /// Used to operate device preset positions, including settings, deletion, and calls.
        /// </summary>
        /// <param name="req"><see cref="ControlDevicePresetRequest"/></param>
        /// <returns><see cref="ControlDevicePresetResponse"/></returns>
        public ControlDevicePresetResponse ControlDevicePresetSync(ControlDevicePresetRequest req)
        {
            return InternalRequestAsync<ControlDevicePresetResponse>(req, "ControlDevicePreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Control device capture (single). Currently only support national standard devices.
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceSnapshotRequest"/></param>
        /// <returns><see cref="ControlDeviceSnapshotResponse"/></returns>
        public Task<ControlDeviceSnapshotResponse> ControlDeviceSnapshot(ControlDeviceSnapshotRequest req)
        {
            return InternalRequestAsync<ControlDeviceSnapshotResponse>(req, "ControlDeviceSnapshot");
        }

        /// <summary>
        /// Control device capture (single). Currently only support national standard devices.
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceSnapshotRequest"/></param>
        /// <returns><see cref="ControlDeviceSnapshotResponse"/></returns>
        public ControlDeviceSnapshotResponse ControlDeviceSnapshotSync(ControlDeviceSnapshotRequest req)
        {
            return InternalRequestAsync<ControlDeviceSnapshotResponse>(req, "ControlDeviceSnapshot")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the real-time streaming address of a device.
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public Task<ControlDeviceStreamResponse> ControlDeviceStream(ControlDeviceStreamRequest req)
        {
            return InternalRequestAsync<ControlDeviceStreamResponse>(req, "ControlDeviceStream");
        }

        /// <summary>
        /// This API is used to obtain the real-time streaming address of a device.
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceStreamRequest"/></param>
        /// <returns><see cref="ControlDeviceStreamResponse"/></returns>
        public ControlDeviceStreamResponse ControlDeviceStreamSync(ControlDeviceStreamRequest req)
        {
            return InternalRequestAsync<ControlDeviceStreamResponse>(req, "ControlDeviceStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the local recording timeline info of a device, which is stored locally on the NVR/IPC.
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public Task<ControlRecordTimelineResponse> ControlRecordTimeline(ControlRecordTimelineRequest req)
        {
            return InternalRequestAsync<ControlRecordTimelineResponse>(req, "ControlRecordTimeline");
        }

        /// <summary>
        /// This API is used to query the local recording timeline info of a device, which is stored locally on the NVR/IPC.
        /// </summary>
        /// <param name="req"><see cref="ControlRecordTimelineRequest"/></param>
        /// <returns><see cref="ControlRecordTimelineResponse"/></returns>
        public ControlRecordTimelineResponse ControlRecordTimelineSync(ControlRecordTimelineRequest req)
        {
            return InternalRequestAsync<ControlRecordTimelineResponse>(req, "ControlRecordTimeline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="CreateVLPlanRequest"/></param>
        /// <returns><see cref="CreateVLPlanResponse"/></returns>
        public Task<CreateVLPlanResponse> CreateVLPlan(CreateVLPlanRequest req)
        {
            return InternalRequestAsync<CreateVLPlanResponse>(req, "CreateVLPlan");
        }

        /// <summary>
        /// Creates a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="CreateVLPlanRequest"/></param>
        /// <returns><see cref="CreateVLPlanResponse"/></returns>
        public CreateVLPlanResponse CreateVLPlanSync(CreateVLPlanRequest req)
        {
            return InternalRequestAsync<CreateVLPlanResponse>(req, "CreateVLPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="CreateVLTemplateRequest"/></param>
        /// <returns><see cref="CreateVLTemplateResponse"/></returns>
        public Task<CreateVLTemplateResponse> CreateVLTemplate(CreateVLTemplateRequest req)
        {
            return InternalRequestAsync<CreateVLTemplateResponse>(req, "CreateVLTemplate");
        }

        /// <summary>
        /// Create a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="CreateVLTemplateRequest"/></param>
        /// <returns><see cref="CreateVLTemplateResponse"/></returns>
        public CreateVLTemplateResponse CreateVLTemplateSync(CreateVLTemplateRequest req)
        {
            return InternalRequestAsync<CreateVLTemplateResponse>(req, "CreateVLTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a local recording download task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateVideoDownloadTaskResponse"/></returns>
        public Task<CreateVideoDownloadTaskResponse> CreateVideoDownloadTask(CreateVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoDownloadTaskResponse>(req, "CreateVideoDownloadTask");
        }

        /// <summary>
        /// This API is used to create a local recording download task.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateVideoDownloadTaskResponse"/></returns>
        public CreateVideoDownloadTaskResponse CreateVideoDownloadTaskSync(CreateVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<CreateVideoDownloadTaskResponse>(req, "CreateVideoDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a screenshot configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="CreateVideoSnapshotConfigResponse"/></returns>
        public Task<CreateVideoSnapshotConfigResponse> CreateVideoSnapshotConfig(CreateVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<CreateVideoSnapshotConfigResponse>(req, "CreateVideoSnapshotConfig");
        }

        /// <summary>
        /// This API is used to create a screenshot configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="CreateVideoSnapshotConfigResponse"/></returns>
        public CreateVideoSnapshotConfigResponse CreateVideoSnapshotConfigSync(CreateVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<CreateVideoSnapshotConfigResponse>(req, "CreateVideoSnapshotConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a screenshot template.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateVideoSnapshotTemplateResponse"/></returns>
        public Task<CreateVideoSnapshotTemplateResponse> CreateVideoSnapshotTemplate(CreateVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateVideoSnapshotTemplateResponse>(req, "CreateVideoSnapshotTemplate");
        }

        /// <summary>
        /// Create a screenshot template.
        /// </summary>
        /// <param name="req"><see cref="CreateVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateVideoSnapshotTemplateResponse"/></returns>
        public CreateVideoSnapshotTemplateResponse CreateVideoSnapshotTemplateSync(CreateVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<CreateVideoSnapshotTemplateResponse>(req, "CreateVideoSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete domain names.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain");
        }

        /// <summary>
        /// This API is used to delete domain names.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
            return InternalRequestAsync<DeleteDomainResponse>(req, "DeleteDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an organization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public Task<DeleteOrganizationResponse> DeleteOrganization(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization");
        }

        /// <summary>
        /// This API is used to delete an organization.
        /// </summary>
        /// <param name="req"><see cref="DeleteOrganizationRequest"/></param>
        /// <returns><see cref="DeleteOrganizationResponse"/></returns>
        public DeleteOrganizationResponse DeleteOrganizationSync(DeleteOrganizationRequest req)
        {
            return InternalRequestAsync<DeleteOrganizationResponse>(req, "DeleteOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public Task<DeleteRecordBackupPlanResponse> DeleteRecordBackupPlan(DeleteRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupPlanResponse>(req, "DeleteRecordBackupPlan");
        }

        /// <summary>
        /// Used to delete a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupPlanResponse"/></returns>
        public DeleteRecordBackupPlanResponse DeleteRecordBackupPlanSync(DeleteRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupPlanResponse>(req, "DeleteRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public Task<DeleteRecordBackupTemplateResponse> DeleteRecordBackupTemplate(DeleteRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupTemplateResponse>(req, "DeleteRecordBackupTemplate");
        }

        /// <summary>
        /// This API is used to delete a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordBackupTemplateResponse"/></returns>
        public DeleteRecordBackupTemplateResponse DeleteRecordBackupTemplateSync(DeleteRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordBackupTemplateResponse>(req, "DeleteRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public Task<DeleteRecordPlanResponse> DeleteRecordPlan(DeleteRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan");
        }

        /// <summary>
        /// This API is used to delete a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordPlanRequest"/></param>
        /// <returns><see cref="DeleteRecordPlanResponse"/></returns>
        public DeleteRecordPlanResponse DeleteRecordPlanSync(DeleteRecordPlanRequest req)
        {
            return InternalRequestAsync<DeleteRecordPlanResponse>(req, "DeleteRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a retrieval task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public Task<DeleteRecordRetrieveTaskResponse> DeleteRecordRetrieveTask(DeleteRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordRetrieveTaskResponse>(req, "DeleteRecordRetrieveTask");
        }

        /// <summary>
        /// This API is used to delete a retrieval task.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DeleteRecordRetrieveTaskResponse"/></returns>
        public DeleteRecordRetrieveTaskResponse DeleteRecordRetrieveTaskSync(DeleteRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DeleteRecordRetrieveTaskResponse>(req, "DeleteRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public Task<DeleteRecordTemplateResponse> DeleteRecordTemplate(DeleteRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordTemplateResponse>(req, "DeleteRecordTemplate");
        }

        /// <summary>
        /// Used to delete a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordTemplateRequest"/></param>
        /// <returns><see cref="DeleteRecordTemplateResponse"/></returns>
        public DeleteRecordTemplateResponse DeleteRecordTemplateSync(DeleteRecordTemplateRequest req)
        {
            return InternalRequestAsync<DeleteRecordTemplateResponse>(req, "DeleteRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to delete completed tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public Task<DeleteTaskResponse> DeleteTask(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask");
        }

        /// <summary>
        /// Used to delete completed tasks.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskRequest"/></param>
        /// <returns><see cref="DeleteTaskResponse"/></returns>
        public DeleteTaskResponse DeleteTaskSync(DeleteTaskRequest req)
        {
            return InternalRequestAsync<DeleteTaskResponse>(req, "DeleteTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete added devices.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public Task<DeleteUserDeviceResponse> DeleteUserDevice(DeleteUserDeviceRequest req)
        {
            return InternalRequestAsync<DeleteUserDeviceResponse>(req, "DeleteUserDevice");
        }

        /// <summary>
        /// This API is used to delete added devices.
        /// </summary>
        /// <param name="req"><see cref="DeleteUserDeviceRequest"/></param>
        /// <returns><see cref="DeleteUserDeviceResponse"/></returns>
        public DeleteUserDeviceResponse DeleteUserDeviceSync(DeleteUserDeviceRequest req)
        {
            return InternalRequestAsync<DeleteUserDeviceResponse>(req, "DeleteUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="DeleteVLPlanRequest"/></param>
        /// <returns><see cref="DeleteVLPlanResponse"/></returns>
        public Task<DeleteVLPlanResponse> DeleteVLPlan(DeleteVLPlanRequest req)
        {
            return InternalRequestAsync<DeleteVLPlanResponse>(req, "DeleteVLPlan");
        }

        /// <summary>
        /// Delete a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="DeleteVLPlanRequest"/></param>
        /// <returns><see cref="DeleteVLPlanResponse"/></returns>
        public DeleteVLPlanResponse DeleteVLPlanSync(DeleteVLPlanRequest req)
        {
            return InternalRequestAsync<DeleteVLPlanResponse>(req, "DeleteVLPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteVLTemplateRequest"/></param>
        /// <returns><see cref="DeleteVLTemplateResponse"/></returns>
        public Task<DeleteVLTemplateResponse> DeleteVLTemplate(DeleteVLTemplateRequest req)
        {
            return InternalRequestAsync<DeleteVLTemplateResponse>(req, "DeleteVLTemplate");
        }

        /// <summary>
        /// Delete a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="DeleteVLTemplateRequest"/></param>
        /// <returns><see cref="DeleteVLTemplateResponse"/></returns>
        public DeleteVLTemplateResponse DeleteVLTemplateSync(DeleteVLTemplateRequest req)
        {
            return InternalRequestAsync<DeleteVLTemplateResponse>(req, "DeleteVLTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes screenshot configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="DeleteVideoSnapshotConfigResponse"/></returns>
        public Task<DeleteVideoSnapshotConfigResponse> DeleteVideoSnapshotConfig(DeleteVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<DeleteVideoSnapshotConfigResponse>(req, "DeleteVideoSnapshotConfig");
        }

        /// <summary>
        /// Deletes screenshot configuration
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="DeleteVideoSnapshotConfigResponse"/></returns>
        public DeleteVideoSnapshotConfigResponse DeleteVideoSnapshotConfigSync(DeleteVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<DeleteVideoSnapshotConfigResponse>(req, "DeleteVideoSnapshotConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteVideoSnapshotTemplateResponse"/></returns>
        public Task<DeleteVideoSnapshotTemplateResponse> DeleteVideoSnapshotTemplate(DeleteVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteVideoSnapshotTemplateResponse>(req, "DeleteVideoSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to delete a screenshot template.
        /// </summary>
        /// <param name="req"><see cref="DeleteVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteVideoSnapshotTemplateResponse"/></returns>
        public DeleteVideoSnapshotTemplateResponse DeleteVideoSnapshotTemplateSync(DeleteVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DeleteVideoSnapshotTemplateResponse>(req, "DeleteVideoSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CNAME value based on the service node.
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public Task<DescribeCNAMEResponse> DescribeCNAME(DescribeCNAMERequest req)
        {
            return InternalRequestAsync<DescribeCNAMEResponse>(req, "DescribeCNAME");
        }

        /// <summary>
        /// This API is used to get the CNAME value based on the service node.
        /// </summary>
        /// <param name="req"><see cref="DescribeCNAMERequest"/></param>
        /// <returns><see cref="DescribeCNAMEResponse"/></returns>
        public DescribeCNAMEResponse DescribeCNAMESync(DescribeCNAMERequest req)
        {
            return InternalRequestAsync<DescribeCNAMEResponse>(req, "DescribeCNAME")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the channels of a device.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public Task<DescribeDeviceChannelResponse> DescribeDeviceChannel(DescribeDeviceChannelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChannelResponse>(req, "DescribeDeviceChannel");
        }

        /// <summary>
        /// This API is used to query the channels of a device.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceChannelRequest"/></param>
        /// <returns><see cref="DescribeDeviceChannelResponse"/></returns>
        public DescribeDeviceChannelResponse DescribeDeviceChannelSync(DescribeDeviceChannelRequest req)
        {
            return InternalRequestAsync<DescribeDeviceChannelResponse>(req, "DescribeDeviceChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query preset position information of device channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public Task<DescribeDevicePresetResponse> DescribeDevicePreset(DescribeDevicePresetRequest req)
        {
            return InternalRequestAsync<DescribeDevicePresetResponse>(req, "DescribeDevicePreset");
        }

        /// <summary>
        /// This API is used to query preset position information of device channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePresetRequest"/></param>
        /// <returns><see cref="DescribeDevicePresetResponse"/></returns>
        public DescribeDevicePresetResponse DescribeDevicePresetSync(DescribeDevicePresetRequest req)
        {
            return InternalRequestAsync<DescribeDevicePresetResponse>(req, "DescribeDevicePreset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of added domains.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain");
        }

        /// <summary>
        /// This API is used to query the list of added domains.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
            return InternalRequestAsync<DescribeDomainResponse>(req, "DescribeDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the service nodes that can be bound when a user adds a domain name. The result is all service nodes supported by the platform. Each service node can only be bound to one domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public Task<DescribeDomainRegionResponse> DescribeDomainRegion(DescribeDomainRegionRequest req)
        {
            return InternalRequestAsync<DescribeDomainRegionResponse>(req, "DescribeDomainRegion");
        }

        /// <summary>
        /// This API is used to query the service nodes that can be bound when a user adds a domain name. The result is all service nodes supported by the platform. Each service node can only be bound to one domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRegionRequest"/></param>
        /// <returns><see cref="DescribeDomainRegionResponse"/></returns>
        public DescribeDomainRegionResponse DescribeDomainRegionSync(DescribeDomainRegionRequest req)
        {
            return InternalRequestAsync<DescribeDomainRegionResponse>(req, "DescribeDomainRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the public network address of a national standard device.
        /// </summary>
        /// <param name="req"><see cref="DescribeGBDeviceAddrRequest"/></param>
        /// <returns><see cref="DescribeGBDeviceAddrResponse"/></returns>
        public Task<DescribeGBDeviceAddrResponse> DescribeGBDeviceAddr(DescribeGBDeviceAddrRequest req)
        {
            return InternalRequestAsync<DescribeGBDeviceAddrResponse>(req, "DescribeGBDeviceAddr");
        }

        /// <summary>
        /// This API is used to obtain the public network address of a national standard device.
        /// </summary>
        /// <param name="req"><see cref="DescribeGBDeviceAddrRequest"/></param>
        /// <returns><see cref="DescribeGBDeviceAddrResponse"/></returns>
        public DescribeGBDeviceAddrResponse DescribeGBDeviceAddrSync(DescribeGBDeviceAddrRequest req)
        {
            return InternalRequestAsync<DescribeGBDeviceAddrResponse>(req, "DescribeGBDeviceAddr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used for querying organizations.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public Task<DescribeOrganizationResponse> DescribeOrganization(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization");
        }

        /// <summary>
        /// Used for querying organizations.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationRequest"/></param>
        /// <returns><see cref="DescribeOrganizationResponse"/></returns>
        public DescribeOrganizationResponse DescribeOrganizationSync(DescribeOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationResponse>(req, "DescribeOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query recording cloud migration plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public Task<DescribeRecordBackupPlanResponse> DescribeRecordBackupPlan(DescribeRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupPlanResponse>(req, "DescribeRecordBackupPlan");
        }

        /// <summary>
        /// This API is used to query recording cloud migration plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupPlanResponse"/></returns>
        public DescribeRecordBackupPlanResponse DescribeRecordBackupPlanSync(DescribeRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupPlanResponse>(req, "DescribeRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query video recording cloud template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public Task<DescribeRecordBackupTemplateResponse> DescribeRecordBackupTemplate(DescribeRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupTemplateResponse>(req, "DescribeRecordBackupTemplate");
        }

        /// <summary>
        /// This API is used to query video recording cloud template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordBackupTemplateResponse"/></returns>
        public DescribeRecordBackupTemplateResponse DescribeRecordBackupTemplateSync(DescribeRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordBackupTemplateResponse>(req, "DescribeRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the device cloud recording timeline information, which is the cloud storage video recording after setting a recording schedule for video upload to cloud.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public Task<DescribeRecordFileResponse> DescribeRecordFile(DescribeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeRecordFileResponse>(req, "DescribeRecordFile");
        }

        /// <summary>
        /// This API is used to query the device cloud recording timeline information, which is the cloud storage video recording after setting a recording schedule for video upload to cloud.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeRecordFileResponse"/></returns>
        public DescribeRecordFileResponse DescribeRecordFileSync(DescribeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeRecordFileResponse>(req, "DescribeRecordFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time cloud migration plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public Task<DescribeRecordPlanResponse> DescribeRecordPlan(DescribeRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlanResponse>(req, "DescribeRecordPlan");
        }

        /// <summary>
        /// This API is used to query real-time cloud migration plan details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlanRequest"/></param>
        /// <returns><see cref="DescribeRecordPlanResponse"/></returns>
        public DescribeRecordPlanResponse DescribeRecordPlanSync(DescribeRecordPlanRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlanResponse>(req, "DescribeRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the cloud recording playback url address.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public Task<DescribeRecordPlaybackUrlResponse> DescribeRecordPlaybackUrl(DescribeRecordPlaybackUrlRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlaybackUrlResponse>(req, "DescribeRecordPlaybackUrl");
        }

        /// <summary>
        /// This API is used to obtain the cloud recording playback url address.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordPlaybackUrlRequest"/></param>
        /// <returns><see cref="DescribeRecordPlaybackUrlResponse"/></returns>
        public DescribeRecordPlaybackUrlResponse DescribeRecordPlaybackUrlSync(DescribeRecordPlaybackUrlRequest req)
        {
            return InternalRequestAsync<DescribeRecordPlaybackUrlResponse>(req, "DescribeRecordPlaybackUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to query the details of a cloud recording retrieval task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public Task<DescribeRecordRetrieveTaskResponse> DescribeRecordRetrieveTask(DescribeRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordRetrieveTaskResponse>(req, "DescribeRecordRetrieveTask");
        }

        /// <summary>
        /// Used to query the details of a cloud recording retrieval task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRetrieveTaskRequest"/></param>
        /// <returns><see cref="DescribeRecordRetrieveTaskResponse"/></returns>
        public DescribeRecordRetrieveTaskResponse DescribeRecordRetrieveTaskSync(DescribeRecordRetrieveTaskRequest req)
        {
            return InternalRequestAsync<DescribeRecordRetrieveTaskResponse>(req, "DescribeRecordRetrieveTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time cloud migration template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public Task<DescribeRecordTemplateResponse> DescribeRecordTemplate(DescribeRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordTemplateResponse>(req, "DescribeRecordTemplate");
        }

        /// <summary>
        /// This API is used to query real-time cloud migration template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordTemplateRequest"/></param>
        /// <returns><see cref="DescribeRecordTemplateResponse"/></returns>
        public DescribeRecordTemplateResponse DescribeRecordTemplateSync(DescribeRecordTemplateRequest req)
        {
            return InternalRequestAsync<DescribeRecordTemplateResponse>(req, "DescribeRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to query push/pull stream authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public Task<DescribeStreamAuthResponse> DescribeStreamAuth(DescribeStreamAuthRequest req)
        {
            return InternalRequestAsync<DescribeStreamAuthResponse>(req, "DescribeStreamAuth");
        }

        /// <summary>
        /// Used to query push/pull stream authentication configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamAuthRequest"/></param>
        /// <returns><see cref="DescribeStreamAuthResponse"/></returns>
        public DescribeStreamAuthResponse DescribeStreamAuthSync(DescribeStreamAuthRequest req)
        {
            return InternalRequestAsync<DescribeStreamAuthResponse>(req, "DescribeStreamAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// This API is used to query task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query detailed information of a device.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public Task<DescribeUserDeviceResponse> DescribeUserDevice(DescribeUserDeviceRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceResponse>(req, "DescribeUserDevice");
        }

        /// <summary>
        /// This API is used to query detailed information of a device.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceResponse"/></returns>
        public DescribeUserDeviceResponse DescribeUserDeviceSync(DescribeUserDeviceRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceResponse>(req, "DescribeUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query device details in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceListRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceListResponse"/></returns>
        public Task<DescribeUserDeviceListResponse> DescribeUserDeviceList(DescribeUserDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceListResponse>(req, "DescribeUserDeviceList");
        }

        /// <summary>
        /// This API is used to query device details in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDeviceListRequest"/></param>
        /// <returns><see cref="DescribeUserDeviceListResponse"/></returns>
        public DescribeUserDeviceListResponse DescribeUserDeviceListSync(DescribeUserDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeUserDeviceListResponse>(req, "DescribeUserDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the plan details of visual understanding.
        /// </summary>
        /// <param name="req"><see cref="DescribeVLPlanRequest"/></param>
        /// <returns><see cref="DescribeVLPlanResponse"/></returns>
        public Task<DescribeVLPlanResponse> DescribeVLPlan(DescribeVLPlanRequest req)
        {
            return InternalRequestAsync<DescribeVLPlanResponse>(req, "DescribeVLPlan");
        }

        /// <summary>
        /// Query the plan details of visual understanding.
        /// </summary>
        /// <param name="req"><see cref="DescribeVLPlanRequest"/></param>
        /// <returns><see cref="DescribeVLPlanResponse"/></returns>
        public DescribeVLPlanResponse DescribeVLPlanSync(DescribeVLPlanRequest req)
        {
            return InternalRequestAsync<DescribeVLPlanResponse>(req, "DescribeVLPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the result details of a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="DescribeVLPlanResultRequest"/></param>
        /// <returns><see cref="DescribeVLPlanResultResponse"/></returns>
        public Task<DescribeVLPlanResultResponse> DescribeVLPlanResult(DescribeVLPlanResultRequest req)
        {
            return InternalRequestAsync<DescribeVLPlanResultResponse>(req, "DescribeVLPlanResult");
        }

        /// <summary>
        /// Query the result details of a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="DescribeVLPlanResultRequest"/></param>
        /// <returns><see cref="DescribeVLPlanResultResponse"/></returns>
        public DescribeVLPlanResultResponse DescribeVLPlanResultSync(DescribeVLPlanResultRequest req)
        {
            return InternalRequestAsync<DescribeVLPlanResultResponse>(req, "DescribeVLPlanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the details of a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeVLTemplateRequest"/></param>
        /// <returns><see cref="DescribeVLTemplateResponse"/></returns>
        public Task<DescribeVLTemplateResponse> DescribeVLTemplate(DescribeVLTemplateRequest req)
        {
            return InternalRequestAsync<DescribeVLTemplateResponse>(req, "DescribeVLTemplate");
        }

        /// <summary>
        /// Query the details of a visual understanding template.
        /// </summary>
        /// <param name="req"><see cref="DescribeVLTemplateRequest"/></param>
        /// <returns><see cref="DescribeVLTemplateResponse"/></returns>
        public DescribeVLTemplateResponse DescribeVLTemplateSync(DescribeVLTemplateRequest req)
        {
            return InternalRequestAsync<DescribeVLTemplateResponse>(req, "DescribeVLTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the bitrate info of a video channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public Task<DescribeVideoBitRateResponse> DescribeVideoBitRate(DescribeVideoBitRateRequest req)
        {
            return InternalRequestAsync<DescribeVideoBitRateResponse>(req, "DescribeVideoBitRate");
        }

        /// <summary>
        /// This API is used to obtain the bitrate info of a video channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoBitRateRequest"/></param>
        /// <returns><see cref="DescribeVideoBitRateResponse"/></returns>
        public DescribeVideoBitRateResponse DescribeVideoBitRateSync(DescribeVideoBitRateRequest req)
        {
            return InternalRequestAsync<DescribeVideoBitRateResponse>(req, "DescribeVideoBitRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the download url of cloud recordings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public Task<DescribeVideoDownloadUrlResponse> DescribeVideoDownloadUrl(DescribeVideoDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVideoDownloadUrlResponse>(req, "DescribeVideoDownloadUrl");
        }

        /// <summary>
        /// This API is used to obtain the download url of cloud recordings.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVideoDownloadUrlResponse"/></returns>
        public DescribeVideoDownloadUrlResponse DescribeVideoDownloadUrlSync(DescribeVideoDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeVideoDownloadUrlResponse>(req, "DescribeVideoDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries screenshot configuration details
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="DescribeVideoSnapshotConfigResponse"/></returns>
        public Task<DescribeVideoSnapshotConfigResponse> DescribeVideoSnapshotConfig(DescribeVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<DescribeVideoSnapshotConfigResponse>(req, "DescribeVideoSnapshotConfig");
        }

        /// <summary>
        /// Queries screenshot configuration details
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="DescribeVideoSnapshotConfigResponse"/></returns>
        public DescribeVideoSnapshotConfigResponse DescribeVideoSnapshotConfigSync(DescribeVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<DescribeVideoSnapshotConfigResponse>(req, "DescribeVideoSnapshotConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get screenshot template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeVideoSnapshotTemplateResponse"/></returns>
        public Task<DescribeVideoSnapshotTemplateResponse> DescribeVideoSnapshotTemplate(DescribeVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeVideoSnapshotTemplateResponse>(req, "DescribeVideoSnapshotTemplate");
        }

        /// <summary>
        /// Get screenshot template details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DescribeVideoSnapshotTemplateResponse"/></returns>
        public DescribeVideoSnapshotTemplateResponse DescribeVideoSnapshotTemplateSync(DescribeVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<DescribeVideoSnapshotTemplateResponse>(req, "DescribeVideoSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get device capture result list
        /// </summary>
        /// <param name="req"><see cref="ListDeviceSnapshotsRequest"/></param>
        /// <returns><see cref="ListDeviceSnapshotsResponse"/></returns>
        public Task<ListDeviceSnapshotsResponse> ListDeviceSnapshots(ListDeviceSnapshotsRequest req)
        {
            return InternalRequestAsync<ListDeviceSnapshotsResponse>(req, "ListDeviceSnapshots");
        }

        /// <summary>
        /// Get device capture result list
        /// </summary>
        /// <param name="req"><see cref="ListDeviceSnapshotsRequest"/></param>
        /// <returns><see cref="ListDeviceSnapshotsResponse"/></returns>
        public ListDeviceSnapshotsResponse ListDeviceSnapshotsSync(ListDeviceSnapshotsRequest req)
        {
            return InternalRequestAsync<ListDeviceSnapshotsResponse>(req, "ListDeviceSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the device list under the corresponding organization.
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public Task<ListDevicesResponse> ListDevices(ListDevicesRequest req)
        {
            return InternalRequestAsync<ListDevicesResponse>(req, "ListDevices");
        }

        /// <summary>
        /// This API is used to obtain the device list under the corresponding organization.
        /// </summary>
        /// <param name="req"><see cref="ListDevicesRequest"/></param>
        /// <returns><see cref="ListDevicesResponse"/></returns>
        public ListDevicesResponse ListDevicesSync(ListDevicesRequest req)
        {
            return InternalRequestAsync<ListDevicesResponse>(req, "ListDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the channel list under the organizational unit directory.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public Task<ListOrganizationChannelsResponse> ListOrganizationChannels(ListOrganizationChannelsRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelsResponse>(req, "ListOrganizationChannels");
        }

        /// <summary>
        /// This API is used to query the channel list under the organizational unit directory.
        /// </summary>
        /// <param name="req"><see cref="ListOrganizationChannelsRequest"/></param>
        /// <returns><see cref="ListOrganizationChannelsResponse"/></returns>
        public ListOrganizationChannelsResponse ListOrganizationChannelsSync(ListOrganizationChannelsRequest req)
        {
            return InternalRequestAsync<ListOrganizationChannelsResponse>(req, "ListOrganizationChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the device channel list under a recording cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public Task<ListRecordBackupPlanDevicesResponse> ListRecordBackupPlanDevices(ListRecordBackupPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlanDevicesResponse>(req, "ListRecordBackupPlanDevices");
        }

        /// <summary>
        /// This API is used to query the device channel list under a recording cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlanDevicesResponse"/></returns>
        public ListRecordBackupPlanDevicesResponse ListRecordBackupPlanDevicesSync(ListRecordBackupPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlanDevicesResponse>(req, "ListRecordBackupPlanDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the recording cloud migration plan list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public Task<ListRecordBackupPlansResponse> ListRecordBackupPlans(ListRecordBackupPlansRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlansResponse>(req, "ListRecordBackupPlans");
        }

        /// <summary>
        /// This API is used to query the recording cloud migration plan list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupPlansRequest"/></param>
        /// <returns><see cref="ListRecordBackupPlansResponse"/></returns>
        public ListRecordBackupPlansResponse ListRecordBackupPlansSync(ListRecordBackupPlansRequest req)
        {
            return InternalRequestAsync<ListRecordBackupPlansResponse>(req, "ListRecordBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the video recording cloud template list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public Task<ListRecordBackupTemplatesResponse> ListRecordBackupTemplates(ListRecordBackupTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupTemplatesResponse>(req, "ListRecordBackupTemplates");
        }

        /// <summary>
        /// This API is used to query the video recording cloud template list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordBackupTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordBackupTemplatesResponse"/></returns>
        public ListRecordBackupTemplatesResponse ListRecordBackupTemplatesSync(ListRecordBackupTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordBackupTemplatesResponse>(req, "ListRecordBackupTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the device channel list under a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public Task<ListRecordPlanDevicesResponse> ListRecordPlanDevices(ListRecordPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordPlanDevicesResponse>(req, "ListRecordPlanDevices");
        }

        /// <summary>
        /// This API is used to query the device channel list under a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlanDevicesRequest"/></param>
        /// <returns><see cref="ListRecordPlanDevicesResponse"/></returns>
        public ListRecordPlanDevicesResponse ListRecordPlanDevicesSync(ListRecordPlanDevicesRequest req)
        {
            return InternalRequestAsync<ListRecordPlanDevicesResponse>(req, "ListRecordPlanDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time cloud migration plan list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public Task<ListRecordPlansResponse> ListRecordPlans(ListRecordPlansRequest req)
        {
            return InternalRequestAsync<ListRecordPlansResponse>(req, "ListRecordPlans");
        }

        /// <summary>
        /// This API is used to query the real-time cloud migration plan list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordPlansRequest"/></param>
        /// <returns><see cref="ListRecordPlansResponse"/></returns>
        public ListRecordPlansResponse ListRecordPlansSync(ListRecordPlansRequest req)
        {
            return InternalRequestAsync<ListRecordPlansResponse>(req, "ListRecordPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the retrieval task list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public Task<ListRecordRetrieveTasksResponse> ListRecordRetrieveTasks(ListRecordRetrieveTasksRequest req)
        {
            return InternalRequestAsync<ListRecordRetrieveTasksResponse>(req, "ListRecordRetrieveTasks");
        }

        /// <summary>
        /// This API is used to query the retrieval task list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordRetrieveTasksRequest"/></param>
        /// <returns><see cref="ListRecordRetrieveTasksResponse"/></returns>
        public ListRecordRetrieveTasksResponse ListRecordRetrieveTasksSync(ListRecordRetrieveTasksRequest req)
        {
            return InternalRequestAsync<ListRecordRetrieveTasksResponse>(req, "ListRecordRetrieveTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time cloud migration template list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public Task<ListRecordTemplatesResponse> ListRecordTemplates(ListRecordTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordTemplatesResponse>(req, "ListRecordTemplates");
        }

        /// <summary>
        /// This API is used to query the real-time cloud migration template list.
        /// </summary>
        /// <param name="req"><see cref="ListRecordTemplatesRequest"/></param>
        /// <returns><see cref="ListRecordTemplatesResponse"/></returns>
        public ListRecordTemplatesResponse ListRecordTemplatesSync(ListRecordTemplatesRequest req)
        {
            return InternalRequestAsync<ListRecordTemplatesResponse>(req, "ListRecordTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the subtask list of a query task.
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public Task<ListSubTasksResponse> ListSubTasks(ListSubTasksRequest req)
        {
            return InternalRequestAsync<ListSubTasksResponse>(req, "ListSubTasks");
        }

        /// <summary>
        /// This API is used to query the subtask list of a query task.
        /// </summary>
        /// <param name="req"><see cref="ListSubTasksRequest"/></param>
        /// <returns><see cref="ListSubTasksResponse"/></returns>
        public ListSubTasksResponse ListSubTasksSync(ListSubTasksRequest req)
        {
            return InternalRequestAsync<ListSubTasksResponse>(req, "ListSubTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the batch task and simple task list.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public Task<ListTasksResponse> ListTasks(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks");
        }

        /// <summary>
        /// This API is used to query the batch task and simple task list.
        /// </summary>
        /// <param name="req"><see cref="ListTasksRequest"/></param>
        /// <returns><see cref="ListTasksResponse"/></returns>
        public ListTasksResponse ListTasksSync(ListTasksRequest req)
        {
            return InternalRequestAsync<ListTasksResponse>(req, "ListTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the visual understanding plan list.
        /// </summary>
        /// <param name="req"><see cref="ListVLPlansRequest"/></param>
        /// <returns><see cref="ListVLPlansResponse"/></returns>
        public Task<ListVLPlansResponse> ListVLPlans(ListVLPlansRequest req)
        {
            return InternalRequestAsync<ListVLPlansResponse>(req, "ListVLPlans");
        }

        /// <summary>
        /// Get the visual understanding plan list.
        /// </summary>
        /// <param name="req"><see cref="ListVLPlansRequest"/></param>
        /// <returns><see cref="ListVLPlansResponse"/></returns>
        public ListVLPlansResponse ListVLPlansSync(ListVLPlansRequest req)
        {
            return InternalRequestAsync<ListVLPlansResponse>(req, "ListVLPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of visual understanding templates.
        /// </summary>
        /// <param name="req"><see cref="ListVLTemplatesRequest"/></param>
        /// <returns><see cref="ListVLTemplatesResponse"/></returns>
        public Task<ListVLTemplatesResponse> ListVLTemplates(ListVLTemplatesRequest req)
        {
            return InternalRequestAsync<ListVLTemplatesResponse>(req, "ListVLTemplates");
        }

        /// <summary>
        /// Get a list of visual understanding templates.
        /// </summary>
        /// <param name="req"><see cref="ListVLTemplatesRequest"/></param>
        /// <returns><see cref="ListVLTemplatesResponse"/></returns>
        public ListVLTemplatesResponse ListVLTemplatesSync(ListVLTemplatesRequest req)
        {
            return InternalRequestAsync<ListVLTemplatesResponse>(req, "ListVLTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the recording download task list in this store.
        /// </summary>
        /// <param name="req"><see cref="ListVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="ListVideoDownloadTaskResponse"/></returns>
        public Task<ListVideoDownloadTaskResponse> ListVideoDownloadTask(ListVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<ListVideoDownloadTaskResponse>(req, "ListVideoDownloadTask");
        }

        /// <summary>
        /// This API is used to query the recording download task list in this store.
        /// </summary>
        /// <param name="req"><see cref="ListVideoDownloadTaskRequest"/></param>
        /// <returns><see cref="ListVideoDownloadTaskResponse"/></returns>
        public ListVideoDownloadTaskResponse ListVideoDownloadTaskSync(ListVideoDownloadTaskRequest req)
        {
            return InternalRequestAsync<ListVideoDownloadTaskResponse>(req, "ListVideoDownloadTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search the screenshot template details list.
        /// </summary>
        /// <param name="req"><see cref="ListVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ListVideoSnapshotTemplateResponse"/></returns>
        public Task<ListVideoSnapshotTemplateResponse> ListVideoSnapshotTemplate(ListVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ListVideoSnapshotTemplateResponse>(req, "ListVideoSnapshotTemplate");
        }

        /// <summary>
        /// This API is used to search the screenshot template details list.
        /// </summary>
        /// <param name="req"><see cref="ListVideoSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ListVideoSnapshotTemplateResponse"/></returns>
        public ListVideoSnapshotTemplateResponse ListVideoSnapshotTemplateSync(ListVideoSnapshotTemplateRequest req)
        {
            return InternalRequestAsync<ListVideoSnapshotTemplateResponse>(req, "ListVideoSnapshotTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="ModifyVLPlanRequest"/></param>
        /// <returns><see cref="ModifyVLPlanResponse"/></returns>
        public Task<ModifyVLPlanResponse> ModifyVLPlan(ModifyVLPlanRequest req)
        {
            return InternalRequestAsync<ModifyVLPlanResponse>(req, "ModifyVLPlan");
        }

        /// <summary>
        /// Modify a vision understanding plan
        /// </summary>
        /// <param name="req"><see cref="ModifyVLPlanRequest"/></param>
        /// <returns><see cref="ModifyVLPlanResponse"/></returns>
        public ModifyVLPlanResponse ModifyVLPlanSync(ModifyVLPlanRequest req)
        {
            return InternalRequestAsync<ModifyVLPlanResponse>(req, "ModifyVLPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update screenshot configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="ModifyVideoSnapshotConfigResponse"/></returns>
        public Task<ModifyVideoSnapshotConfigResponse> ModifyVideoSnapshotConfig(ModifyVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<ModifyVideoSnapshotConfigResponse>(req, "ModifyVideoSnapshotConfig");
        }

        /// <summary>
        /// Update screenshot configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyVideoSnapshotConfigRequest"/></param>
        /// <returns><see cref="ModifyVideoSnapshotConfigResponse"/></returns>
        public ModifyVideoSnapshotConfigResponse ModifyVideoSnapshotConfigSync(ModifyVideoSnapshotConfigRequest req)
        {
            return InternalRequestAsync<ModifyVideoSnapshotConfigResponse>(req, "ModifyVideoSnapshotConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the local device recording URL address.
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public Task<PlayRecordResponse> PlayRecord(PlayRecordRequest req)
        {
            return InternalRequestAsync<PlayRecordResponse>(req, "PlayRecord");
        }

        /// <summary>
        /// This API is used to obtain the local device recording URL address.
        /// </summary>
        /// <param name="req"><see cref="PlayRecordRequest"/></param>
        /// <returns><see cref="PlayRecordResponse"/></returns>
        public PlayRecordResponse PlayRecordSync(PlayRecordRequest req)
        {
            return InternalRequestAsync<PlayRecordResponse>(req, "PlayRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the disabled channel list
        /// </summary>
        /// <param name="req"><see cref="QueryForbidPlayChannelListRequest"/></param>
        /// <returns><see cref="QueryForbidPlayChannelListResponse"/></returns>
        public Task<QueryForbidPlayChannelListResponse> QueryForbidPlayChannelList(QueryForbidPlayChannelListRequest req)
        {
            return InternalRequestAsync<QueryForbidPlayChannelListResponse>(req, "QueryForbidPlayChannelList");
        }

        /// <summary>
        /// Query the disabled channel list
        /// </summary>
        /// <param name="req"><see cref="QueryForbidPlayChannelListRequest"/></param>
        /// <returns><see cref="QueryForbidPlayChannelListResponse"/></returns>
        public QueryForbidPlayChannelListResponse QueryForbidPlayChannelListSync(QueryForbidPlayChannelListRequest req)
        {
            return InternalRequestAsync<QueryForbidPlayChannelListResponse>(req, "QueryForbidPlayChannelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to synchronize channels of national standard devices. After the API is called, a request is triggered to get the channel list from devices. Newly-added channels are stored, and channels deleted on devices need to be deleted manually and are not automatically deleted in the backend.
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public Task<RefreshDeviceChannelResponse> RefreshDeviceChannel(RefreshDeviceChannelRequest req)
        {
            return InternalRequestAsync<RefreshDeviceChannelResponse>(req, "RefreshDeviceChannel");
        }

        /// <summary>
        /// This API is used to synchronize channels of national standard devices. After the API is called, a request is triggered to get the channel list from devices. Newly-added channels are stored, and channels deleted on devices need to be deleted manually and are not automatically deleted in the backend.
        /// </summary>
        /// <param name="req"><see cref="RefreshDeviceChannelRequest"/></param>
        /// <returns><see cref="RefreshDeviceChannelResponse"/></returns>
        public RefreshDeviceChannelResponse RefreshDeviceChannelSync(RefreshDeviceChannelRequest req)
        {
            return InternalRequestAsync<RefreshDeviceChannelResponse>(req, "RefreshDeviceChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Forbid the live preview of video channels for root accounts and sub-accounts.
        /// </summary>
        /// <param name="req"><see cref="SetForbidPlayChannelsRequest"/></param>
        /// <returns><see cref="SetForbidPlayChannelsResponse"/></returns>
        public Task<SetForbidPlayChannelsResponse> SetForbidPlayChannels(SetForbidPlayChannelsRequest req)
        {
            return InternalRequestAsync<SetForbidPlayChannelsResponse>(req, "SetForbidPlayChannels");
        }

        /// <summary>
        /// Forbid the live preview of video channels for root accounts and sub-accounts.
        /// </summary>
        /// <param name="req"><see cref="SetForbidPlayChannelsRequest"/></param>
        /// <returns><see cref="SetForbidPlayChannelsResponse"/></returns>
        public SetForbidPlayChannelsResponse SetForbidPlayChannelsSync(SetForbidPlayChannelsRequest req)
        {
            return InternalRequestAsync<SetForbidPlayChannelsResponse>(req, "SetForbidPlayChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to change the organization of devices in batches.
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public Task<UpdateDeviceOrganizationResponse> UpdateDeviceOrganization(UpdateDeviceOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateDeviceOrganizationResponse>(req, "UpdateDeviceOrganization");
        }

        /// <summary>
        /// Used to change the organization of devices in batches.
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceOrganizationRequest"/></param>
        /// <returns><see cref="UpdateDeviceOrganizationResponse"/></returns>
        public UpdateDeviceOrganizationResponse UpdateDeviceOrganizationSync(UpdateDeviceOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateDeviceOrganizationResponse>(req, "UpdateDeviceOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to enable or disable a device. After it is disabled, device registration is denied.
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public Task<UpdateDeviceStatusResponse> UpdateDeviceStatus(UpdateDeviceStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceStatusResponse>(req, "UpdateDeviceStatus");
        }

        /// <summary>
        /// Used to enable or disable a device. After it is disabled, device registration is denied.
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceStatusRequest"/></param>
        /// <returns><see cref="UpdateDeviceStatusResponse"/></returns>
        public UpdateDeviceStatusResponse UpdateDeviceStatusSync(UpdateDeviceStatusRequest req)
        {
            return InternalRequestAsync<UpdateDeviceStatusResponse>(req, "UpdateDeviceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to modify an organization.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public Task<UpdateOrganizationResponse> UpdateOrganization(UpdateOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationResponse>(req, "UpdateOrganization");
        }

        /// <summary>
        /// Used to modify an organization.
        /// </summary>
        /// <param name="req"><see cref="UpdateOrganizationRequest"/></param>
        /// <returns><see cref="UpdateOrganizationResponse"/></returns>
        public UpdateOrganizationResponse UpdateOrganizationSync(UpdateOrganizationRequest req)
        {
            return InternalRequestAsync<UpdateOrganizationResponse>(req, "UpdateOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to modify the recording cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public Task<UpdateRecordBackupPlanResponse> UpdateRecordBackupPlan(UpdateRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupPlanResponse>(req, "UpdateRecordBackupPlan");
        }

        /// <summary>
        /// Used to modify the recording cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupPlanResponse"/></returns>
        public UpdateRecordBackupPlanResponse UpdateRecordBackupPlanSync(UpdateRecordBackupPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupPlanResponse>(req, "UpdateRecordBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to modify a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public Task<UpdateRecordBackupTemplateResponse> UpdateRecordBackupTemplate(UpdateRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupTemplateResponse>(req, "UpdateRecordBackupTemplate");
        }

        /// <summary>
        /// Used to modify a video recording cloud template.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordBackupTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordBackupTemplateResponse"/></returns>
        public UpdateRecordBackupTemplateResponse UpdateRecordBackupTemplateSync(UpdateRecordBackupTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordBackupTemplateResponse>(req, "UpdateRecordBackupTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public Task<UpdateRecordPlanResponse> UpdateRecordPlan(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan");
        }

        /// <summary>
        /// This API is used to modify a real-time cloud migration plan.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordPlanRequest"/></param>
        /// <returns><see cref="UpdateRecordPlanResponse"/></returns>
        public UpdateRecordPlanResponse UpdateRecordPlanSync(UpdateRecordPlanRequest req)
        {
            return InternalRequestAsync<UpdateRecordPlanResponse>(req, "UpdateRecordPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to modify a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public Task<UpdateRecordTemplateResponse> UpdateRecordTemplate(UpdateRecordTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordTemplateResponse>(req, "UpdateRecordTemplate");
        }

        /// <summary>
        /// Used to modify a real-time cloud template.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordTemplateRequest"/></param>
        /// <returns><see cref="UpdateRecordTemplateResponse"/></returns>
        public UpdateRecordTemplateResponse UpdateRecordTemplateSync(UpdateRecordTemplateRequest req)
        {
            return InternalRequestAsync<UpdateRecordTemplateResponse>(req, "UpdateRecordTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify device configuration information.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public Task<UpdateUserDeviceResponse> UpdateUserDevice(UpdateUserDeviceRequest req)
        {
            return InternalRequestAsync<UpdateUserDeviceResponse>(req, "UpdateUserDevice");
        }

        /// <summary>
        /// This API is used to modify device configuration information.
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDeviceRequest"/></param>
        /// <returns><see cref="UpdateUserDeviceResponse"/></returns>
        public UpdateUserDeviceResponse UpdateUserDeviceSync(UpdateUserDeviceRequest req)
        {
            return InternalRequestAsync<UpdateUserDeviceResponse>(req, "UpdateUserDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
