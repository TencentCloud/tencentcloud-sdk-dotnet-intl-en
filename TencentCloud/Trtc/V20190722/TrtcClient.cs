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
