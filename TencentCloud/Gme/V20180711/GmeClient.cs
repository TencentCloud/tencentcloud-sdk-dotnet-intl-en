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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public async Task<DeleteRoomMemberResponse> DeleteRoomMember(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public DeleteRoomMemberResponse DeleteRoomMemberSync(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public async Task<DescribeAppStatisticsResponse> DescribeAppStatistics(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public DescribeAppStatisticsResponse DescribeAppStatisticsSync(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public async Task<DescribeApplicationDataResponse> DescribeApplicationData(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public DescribeApplicationDataResponse DescribeApplicationDataSync(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public async Task<ModifyAppStatusResponse> ModifyAppStatus(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public ModifyAppStatusResponse ModifyAppStatusSync(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
