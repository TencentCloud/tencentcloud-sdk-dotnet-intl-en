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

namespace TencentCloud.Hunyuan.V20230901
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hunyuan.V20230901.Models;

   public class HunyuanClient : AbstractClient{

       private const string endpoint = "hunyuan.intl.tencentcloudapi.com";
       private const string version = "2023-09-01";
       private const string sdkVersion = "SDK_NET_3.0.1248";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HunyuanClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HunyuanClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model and input text descriptions/images.
        /// This API is used to provide 3 concurrent tasks by default, which can process 3 submitted tasks simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DProJobResponse"/></returns>
        public Task<QueryHunyuanTo3DProJobResponse> QueryHunyuanTo3DProJob(QueryHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DProJobResponse>(req, "QueryHunyuanTo3DProJob");
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model and input text descriptions/images.
        /// This API is used to provide 3 concurrent tasks by default, which can process 3 submitted tasks simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DProJobResponse"/></returns>
        public QueryHunyuanTo3DProJobResponse QueryHunyuanTo3DProJobSync(QueryHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DProJobResponse>(req, "QueryHunyuanTo3DProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model and input text descriptions/images.
        /// This API is used to provide 3 concurrent tasks by default. Up to 3 submitted tasks can be processed simultaneously. A new task can be processed only after the previous one is completed.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DProJobResponse> SubmitHunyuanTo3DProJob(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob");
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model and input text descriptions/images.
        /// This API is used to provide 3 concurrent tasks by default. Up to 3 submitted tasks can be processed simultaneously. A new task can be processed only after the previous one is completed.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DProJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DProJobResponse"/></returns>
        public SubmitHunyuanTo3DProJobResponse SubmitHunyuanTo3DProJobSync(SubmitHunyuanTo3DProJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DProJobResponse>(req, "SubmitHunyuanTo3DProJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
