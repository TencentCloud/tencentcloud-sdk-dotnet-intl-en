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

namespace TencentCloud.Gpm.V20200820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gpm.V20200820.Models;

   public class GpmClient : AbstractClient{

       private const string endpoint = "gpm.tencentcloudapi.com";
       private const string version = "2020-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GpmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GpmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to cancel matching.
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public async Task<CancelMatchingResponse> CancelMatching(CancelMatchingRequest req)
        {
             JsonResponseModel<CancelMatchingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel matching.
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public CancelMatchingResponse CancelMatchingSync(CancelMatchingRequest req)
        {
             JsonResponseModel<CancelMatchingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the matching progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public async Task<DescribeMatchingProgressResponse> DescribeMatchingProgress(DescribeMatchingProgressRequest req)
        {
             JsonResponseModel<DescribeMatchingProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMatchingProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchingProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the matching progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public DescribeMatchingProgressResponse DescribeMatchingProgressSync(DescribeMatchingProgressRequest req)
        {
             JsonResponseModel<DescribeMatchingProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMatchingProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchingProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the token of a Matchcode, which is used for verified the pushed message.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public async Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
             JsonResponseModel<DescribeTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the token of a Matchcode, which is used for verified the pushed message.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
             JsonResponseModel<DescribeTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the token of a Matchcode.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public async Task<ModifyTokenResponse> ModifyToken(ModifyTokenRequest req)
        {
             JsonResponseModel<ModifyTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the token of a Matchcode.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public ModifyTokenResponse ModifyTokenSync(ModifyTokenRequest req)
        {
             JsonResponseModel<ModifyTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in one player or multiple players to initiate match. Players within the same request will be assigned to the same game session.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public async Task<StartMatchingResponse> StartMatching(StartMatchingRequest req)
        {
             JsonResponseModel<StartMatchingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in one player or multiple players to initiate match. Players within the same request will be assigned to the same game session.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public StartMatchingResponse StartMatchingSync(StartMatchingRequest req)
        {
             JsonResponseModel<StartMatchingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
