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

namespace TencentCloud.Cdn.V20180606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdn.V20180606.Models;

   public class CdnClient : AbstractClient{

       private const string endpoint = "cdn.tencentcloudapi.com";
       private const string version = "2018-06-06";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public async Task<CreateScdnFailedLogTaskResponse> CreateScdnFailedLogTask(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public CreateScdnFailedLogTaskResponse CreateScdnFailedLogTaskSync(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public async Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public async Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
