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

namespace TencentCloud.Car.V20220110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Car.V20220110.Models;

   public class CarClient : AbstractClient{

       private const string endpoint = "car.tencentcloudapi.com";
       private const string version = "2022-01-10";
       private const string sdkVersion = "SDK_NET_3.0.843";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CarClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CarClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to request a concurrency. The timeout period of the API is 20 seconds.
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public Task<ApplyConcurrentResponse> ApplyConcurrent(ApplyConcurrentRequest req)
        {
            return InternalRequestAsync<ApplyConcurrentResponse>(req, "ApplyConcurrent");
        }

        /// <summary>
        /// This API is used to request a concurrency. The timeout period of the API is 20 seconds.
        /// </summary>
        /// <param name="req"><see cref="ApplyConcurrentRequest"/></param>
        /// <returns><see cref="ApplyConcurrentResponse"/></returns>
        public ApplyConcurrentResponse ApplyConcurrentSync(ApplyConcurrentRequest req)
        {
            return InternalRequestAsync<ApplyConcurrentResponse>(req, "ApplyConcurrent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a session. The timeout period of the API is 5 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public Task<CreateSessionResponse> CreateSession(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession");
        }

        /// <summary>
        /// This API is used to create a session. The timeout period of the API is 5 seconds.
        /// </summary>
        /// <param name="req"><see cref="CreateSessionRequest"/></param>
        /// <returns><see cref="CreateSessionResponse"/></returns>
        public CreateSessionResponse CreateSessionSync(CreateSessionRequest req)
        {
            return InternalRequestAsync<CreateSessionResponse>(req, "CreateSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a session.
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public Task<DestroySessionResponse> DestroySession(DestroySessionRequest req)
        {
            return InternalRequestAsync<DestroySessionResponse>(req, "DestroySession");
        }

        /// <summary>
        /// This API is used to terminate a session.
        /// </summary>
        /// <param name="req"><see cref="DestroySessionRequest"/></param>
        /// <returns><see cref="DestroySessionResponse"/></returns>
        public DestroySessionResponse DestroySessionSync(DestroySessionRequest req)
        {
            return InternalRequestAsync<DestroySessionResponse>(req, "DestroySession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start stream push.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public Task<StartPublishStreamResponse> StartPublishStream(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream");
        }

        /// <summary>
        /// This API is used to start stream push.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamRequest"/></param>
        /// <returns><see cref="StartPublishStreamResponse"/></returns>
        public StartPublishStreamResponse StartPublishStreamSync(StartPublishStreamRequest req)
        {
            return InternalRequestAsync<StartPublishStreamResponse>(req, "StartPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start stream push to the specified URL. It is billed separately. For billing details, see the [Push to third-party address](https://intl.cloud.tencent.com/document/product/1547/72168?from_cn_redirect=1#98ac188a-d122-4caf-88be-05268ecefdf6) section.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public Task<StartPublishStreamWithURLResponse> StartPublishStreamWithURL(StartPublishStreamWithURLRequest req)
        {
            return InternalRequestAsync<StartPublishStreamWithURLResponse>(req, "StartPublishStreamWithURL");
        }

        /// <summary>
        /// This API is used to start stream push to the specified URL. It is billed separately. For billing details, see the [Push to third-party address](https://intl.cloud.tencent.com/document/product/1547/72168?from_cn_redirect=1#98ac188a-d122-4caf-88be-05268ecefdf6) section.
        /// </summary>
        /// <param name="req"><see cref="StartPublishStreamWithURLRequest"/></param>
        /// <returns><see cref="StartPublishStreamWithURLResponse"/></returns>
        public StartPublishStreamWithURLResponse StartPublishStreamWithURLSync(StartPublishStreamWithURLRequest req)
        {
            return InternalRequestAsync<StartPublishStreamWithURLResponse>(req, "StartPublishStreamWithURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop stream push.
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public Task<StopPublishStreamResponse> StopPublishStream(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream");
        }

        /// <summary>
        /// This API is used to stop stream push.
        /// </summary>
        /// <param name="req"><see cref="StopPublishStreamRequest"/></param>
        /// <returns><see cref="StopPublishStreamResponse"/></returns>
        public StopPublishStreamResponse StopPublishStreamSync(StopPublishStreamRequest req)
        {
            return InternalRequestAsync<StopPublishStreamResponse>(req, "StopPublishStream")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
