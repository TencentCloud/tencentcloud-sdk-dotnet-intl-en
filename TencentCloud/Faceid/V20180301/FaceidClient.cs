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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public async Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
