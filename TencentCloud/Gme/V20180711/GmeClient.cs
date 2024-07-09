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

namespace TencentCloud.Gme.V20180711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gme.V20180711.Models;

   public class GmeClient : AbstractClient{

       private const string endpoint = "gme.tencentcloudapi.com";
       private const string version = "2018-07-11";
       private const string sdkVersion = "SDK_NET_3.0.936";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp");
        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public Task<DeleteRoomMemberResponse> DeleteRoomMember(DeleteRoomMemberRequest req)
        {
            return InternalRequestAsync<DeleteRoomMemberResponse>(req, "DeleteRoomMember");
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public DeleteRoomMemberResponse DeleteRoomMemberSync(DeleteRoomMemberRequest req)
        {
            return InternalRequestAsync<DeleteRoomMemberResponse>(req, "DeleteRoomMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public Task<DescribeAppStatisticsResponse> DescribeAppStatistics(DescribeAppStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAppStatisticsResponse>(req, "DescribeAppStatistics");
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public DescribeAppStatisticsResponse DescribeAppStatisticsSync(DescribeAppStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAppStatisticsResponse>(req, "DescribeAppStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public Task<DescribeApplicationDataResponse> DescribeApplicationData(DescribeApplicationDataRequest req)
        {
            return InternalRequestAsync<DescribeApplicationDataResponse>(req, "DescribeApplicationData");
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public DescribeApplicationDataResponse DescribeApplicationDataSync(DescribeApplicationDataRequest req)
        {
            return InternalRequestAsync<DescribeApplicationDataResponse>(req, "DescribeApplicationData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordInfoRequest"/></param>
        /// <returns><see cref="DescribeRecordInfoResponse"/></returns>
        public Task<DescribeRecordInfoResponse> DescribeRecordInfo(DescribeRecordInfoRequest req)
        {
            return InternalRequestAsync<DescribeRecordInfoResponse>(req, "DescribeRecordInfo");
        }

        /// <summary>
        /// This API is used to query a recording task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordInfoRequest"/></param>
        /// <returns><see cref="DescribeRecordInfoResponse"/></returns>
        public DescribeRecordInfoResponse DescribeRecordInfoSync(DescribeRecordInfoRequest req)
        {
            return InternalRequestAsync<DescribeRecordInfoResponse>(req, "DescribeRecordInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the recording task in a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo");
        }

        /// <summary>
        /// This API is used to query the recording task in a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public Task<ModifyAppStatusResponse> ModifyAppStatus(ModifyAppStatusRequest req)
        {
            return InternalRequestAsync<ModifyAppStatusResponse>(req, "ModifyAppStatus");
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public ModifyAppStatusResponse ModifyAppStatusSync(ModifyAppStatusRequest req)
        {
            return InternalRequestAsync<ModifyAppStatusResponse>(req, "ModifyAppStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify recording configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordInfoRequest"/></param>
        /// <returns><see cref="ModifyRecordInfoResponse"/></returns>
        public Task<ModifyRecordInfoResponse> ModifyRecordInfo(ModifyRecordInfoRequest req)
        {
            return InternalRequestAsync<ModifyRecordInfoResponse>(req, "ModifyRecordInfo");
        }

        /// <summary>
        /// This API is used to modify recording configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordInfoRequest"/></param>
        /// <returns><see cref="ModifyRecordInfoResponse"/></returns>
        public ModifyRecordInfoResponse ModifyRecordInfoSync(ModifyRecordInfoRequest req)
        {
            return InternalRequestAsync<ModifyRecordInfoResponse>(req, "ModifyRecordInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start recording.
        /// </summary>
        /// <param name="req"><see cref="StartRecordRequest"/></param>
        /// <returns><see cref="StartRecordResponse"/></returns>
        public Task<StartRecordResponse> StartRecord(StartRecordRequest req)
        {
            return InternalRequestAsync<StartRecordResponse>(req, "StartRecord");
        }

        /// <summary>
        /// This API is used to start recording.
        /// </summary>
        /// <param name="req"><see cref="StartRecordRequest"/></param>
        /// <returns><see cref="StartRecordResponse"/></returns>
        public StartRecordResponse StartRecordSync(StartRecordRequest req)
        {
            return InternalRequestAsync<StartRecordResponse>(req, "StartRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop recording.
        /// </summary>
        /// <param name="req"><see cref="StopRecordRequest"/></param>
        /// <returns><see cref="StopRecordResponse"/></returns>
        public Task<StopRecordResponse> StopRecord(StopRecordRequest req)
        {
            return InternalRequestAsync<StopRecordResponse>(req, "StopRecord");
        }

        /// <summary>
        /// This API is used to stop recording.
        /// </summary>
        /// <param name="req"><see cref="StopRecordRequest"/></param>
        /// <returns><see cref="StopRecordResponse"/></returns>
        public StopRecordResponse StopRecordSync(StopRecordRequest req)
        {
            return InternalRequestAsync<StopRecordResponse>(req, "StopRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
