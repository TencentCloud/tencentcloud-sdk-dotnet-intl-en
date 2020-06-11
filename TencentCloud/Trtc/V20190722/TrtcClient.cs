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

namespace TencentCloud.Trtc.V20190722
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trtc.V20190722.Models;

   public class TrtcClient : AbstractClient{

       private const string endpoint = "trtc.tencentcloudapi.com";
       private const string version = "2019-07-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrtcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrtcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to query the user list and user call quality data in a specified time period. It can query data of up to 6 users for the last 5 days, and the query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailRequest"/></param>
        /// <returns><see cref="DescribeCallDetailResponse"/></returns>
        public async Task<DescribeCallDetailResponse> DescribeCallDetail(DescribeCallDetailRequest req)
        {
             JsonResponseModel<DescribeCallDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the user list and user call quality data in a specified time period. It can query data of up to 6 users for the last 5 days, and the query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallDetailRequest"/></param>
        /// <returns><see cref="DescribeCallDetailResponse"/></returns>
        public DescribeCallDetailResponse DescribeCallDetailSync(DescribeCallDetailRequest req)
        {
             JsonResponseModel<DescribeCallDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of historical rooms and users for the last 5 days. It can query once per minute.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryScaleRequest"/></param>
        /// <returns><see cref="DescribeHistoryScaleResponse"/></returns>
        public async Task<DescribeHistoryScaleResponse> DescribeHistoryScale(DescribeHistoryScaleRequest req)
        {
             JsonResponseModel<DescribeHistoryScaleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHistoryScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the number of historical rooms and users for the last 5 days. It can query once per minute.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryScaleRequest"/></param>
        /// <returns><see cref="DescribeHistoryScaleResponse"/></returns>
        public DescribeHistoryScaleResponse DescribeHistoryScaleSync(DescribeHistoryScaleRequest req)
        {
             JsonResponseModel<DescribeHistoryScaleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHistoryScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHistoryScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time network status for the last 24 hours according to `sdkappid`, including upstream and downstream packet losses. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeNetworkRequest"/></param>
        /// <returns><see cref="DescribeRealtimeNetworkResponse"/></returns>
        public async Task<DescribeRealtimeNetworkResponse> DescribeRealtimeNetwork(DescribeRealtimeNetworkRequest req)
        {
             JsonResponseModel<DescribeRealtimeNetworkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time network status for the last 24 hours according to `sdkappid`, including upstream and downstream packet losses. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeNetworkRequest"/></param>
        /// <returns><see cref="DescribeRealtimeNetworkResponse"/></returns>
        public DescribeRealtimeNetworkResponse DescribeRealtimeNetworkSync(DescribeRealtimeNetworkRequest req)
        {
             JsonResponseModel<DescribeRealtimeNetworkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeNetwork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeNetworkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time quality data for the last 24 hours according to `sdkappid`, including the room entry success rate, instant playback rate of the first frame, audio lag rate, and video lag rate. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeQualityRequest"/></param>
        /// <returns><see cref="DescribeRealtimeQualityResponse"/></returns>
        public async Task<DescribeRealtimeQualityResponse> DescribeRealtimeQuality(DescribeRealtimeQualityRequest req)
        {
             JsonResponseModel<DescribeRealtimeQualityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeQuality");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeQualityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query real-time quality data for the last 24 hours according to `sdkappid`, including the room entry success rate, instant playback rate of the first frame, audio lag rate, and video lag rate. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeQualityRequest"/></param>
        /// <returns><see cref="DescribeRealtimeQualityResponse"/></returns>
        public DescribeRealtimeQualityResponse DescribeRealtimeQualitySync(DescribeRealtimeQualityRequest req)
        {
             JsonResponseModel<DescribeRealtimeQualityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeQuality");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeQualityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time scale for the last 24 hours according to `sdkappid`. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScaleRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScaleResponse"/></returns>
        public async Task<DescribeRealtimeScaleResponse> DescribeRealtimeScale(DescribeRealtimeScaleRequest req)
        {
             JsonResponseModel<DescribeRealtimeScaleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time scale for the last 24 hours according to `sdkappid`. The query time range cannot exceed 1 hour.
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScaleRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScaleResponse"/></returns>
        public DescribeRealtimeScaleResponse DescribeRealtimeScaleSync(DescribeRealtimeScaleRequest req)
        {
             JsonResponseModel<DescribeRealtimeScaleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the room list for the last 5 days according to `sdkappid`. It returns 10 calls by default and up to 100 calls at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInformationRequest"/></param>
        /// <returns><see cref="DescribeRoomInformationResponse"/></returns>
        public async Task<DescribeRoomInformationResponse> DescribeRoomInformation(DescribeRoomInformationRequest req)
        {
             JsonResponseModel<DescribeRoomInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the room list for the last 5 days according to `sdkappid`. It returns 10 calls by default and up to 100 calls at a time.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInformationRequest"/></param>
        /// <returns><see cref="DescribeRoomInformationResponse"/></returns>
        public DescribeRoomInformationResponse DescribeRoomInformationSync(DescribeRoomInformationRequest req)
        {
             JsonResponseModel<DescribeRoomInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove all users from a room and dismiss the room. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public async Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove all users from a room and dismiss the room. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
             JsonResponseModel<DismissRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DismissRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DismissRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a user from a room. It is applicable to scenarios where the anchor, room owner, or admin wants to kick out a user. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public async Task<RemoveUserResponse> RemoveUser(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a user from a room. It is applicable to scenarios where the anchor, room owner, or admin wants to kick out a user. It supports all platforms. For Android, iOS, Windows, and macOS, the TRTC SDK needs to be upgraded to v6.6 or above.
        /// </summary>
        /// <param name="req"><see cref="RemoveUserRequest"/></param>
        /// <returns><see cref="RemoveUserResponse"/></returns>
        public RemoveUserResponse RemoveUserSync(RemoveUserRequest req)
        {
             JsonResponseModel<RemoveUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
