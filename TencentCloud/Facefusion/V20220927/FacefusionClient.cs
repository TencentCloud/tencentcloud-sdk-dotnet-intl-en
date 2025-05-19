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

namespace TencentCloud.Facefusion.V20220927
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Facefusion.V20220927.Models;

   public class FacefusionClient : AbstractClient{

       private const string endpoint = "facefusion.intl.tencentcloudapi.com";
       private const string version = "2022-09-27";
       private const string sdkVersion = "SDK_NET_3.0.1133";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FacefusionClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FacefusionClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to perform the fusion of a single face, multiple faces, and specified faces with the material template by uploading face images. Users can add logos to generated images. See <a href="https://intl.cloud.tencent.com/document/product/670/38247?from_cn_redirect=1" target="_blank">Fusion Access Guide</a>.
        /// 
        /// 
        /// 
        /// - The signature method in the public parameters must be specified as the V3 version. In other words, set the SignatureMethod parameter to TC3-HMAC-SHA256.
        /// </summary>
        /// <param name="req"><see cref="FuseFaceRequest"/></param>
        /// <returns><see cref="FuseFaceResponse"/></returns>
        public Task<FuseFaceResponse> FuseFace(FuseFaceRequest req)
        {
            return InternalRequestAsync<FuseFaceResponse>(req, "FuseFace");
        }

        /// <summary>
        /// This API is used to perform the fusion of a single face, multiple faces, and specified faces with the material template by uploading face images. Users can add logos to generated images. See <a href="https://intl.cloud.tencent.com/document/product/670/38247?from_cn_redirect=1" target="_blank">Fusion Access Guide</a>.
        /// 
        /// 
        /// 
        /// - The signature method in the public parameters must be specified as the V3 version. In other words, set the SignatureMethod parameter to TC3-HMAC-SHA256.
        /// </summary>
        /// <param name="req"><see cref="FuseFaceRequest"/></param>
        /// <returns><see cref="FuseFaceResponse"/></returns>
        public FuseFaceResponse FuseFaceSync(FuseFaceRequest req)
        {
            return InternalRequestAsync<FuseFaceResponse>(req, "FuseFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the progress and status of video face fusion tasks by Job ID.
        /// </summary>
        /// <param name="req"><see cref="QueryVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="QueryVideoFaceFusionJobResponse"/></returns>
        public Task<QueryVideoFaceFusionJobResponse> QueryVideoFaceFusionJob(QueryVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<QueryVideoFaceFusionJobResponse>(req, "QueryVideoFaceFusionJob");
        }

        /// <summary>
        /// This API is used to query the progress and status of video face fusion tasks by Job ID.
        /// </summary>
        /// <param name="req"><see cref="QueryVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="QueryVideoFaceFusionJobResponse"/></returns>
        public QueryVideoFaceFusionJobResponse QueryVideoFaceFusionJobSync(QueryVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<QueryVideoFaceFusionJobResponse>(req, "QueryVideoFaceFusionJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit asynchronous processing tasks of video face fusion. After a task is submitted, the Job ID, estimated completion time, and current queue length will be returned.
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="SubmitVideoFaceFusionJobResponse"/></returns>
        public Task<SubmitVideoFaceFusionJobResponse> SubmitVideoFaceFusionJob(SubmitVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoFaceFusionJobResponse>(req, "SubmitVideoFaceFusionJob");
        }

        /// <summary>
        /// This API is used to submit asynchronous processing tasks of video face fusion. After a task is submitted, the Job ID, estimated completion time, and current queue length will be returned.
        /// </summary>
        /// <param name="req"><see cref="SubmitVideoFaceFusionJobRequest"/></param>
        /// <returns><see cref="SubmitVideoFaceFusionJobResponse"/></returns>
        public SubmitVideoFaceFusionJobResponse SubmitVideoFaceFusionJobSync(SubmitVideoFaceFusionJobRequest req)
        {
            return InternalRequestAsync<SubmitVideoFaceFusionJobResponse>(req, "SubmitVideoFaceFusionJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
