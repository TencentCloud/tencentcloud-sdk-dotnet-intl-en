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
       private const string sdkVersion = "SDK_NET_3.0.1265";

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
        /// Tencent Hunyuan is a large language model (LLM) developed by Tencent R&D. It possesses powerful Chinese creation capacity, logical reasoning in complex context, and reliable task execution power. This API supports streaming or non-streaming calls. When using streaming calls, it follows the SSE protocol.
        /// 
        /// 1. This API does not currently support returning Image Content.
        /// 2. By default, this API has account restrictions with a number of concurrencies of 5. 
        /// 3. Please use the SDK to call this API. examples are provided in the Git repository examples/hunyuan/v20230901/ directory for each development language. The SDK link is provided in the "**Developer Resources - SDK**" part under the document.
        /// 4. We recommend you use API Explorer for quick online debugging interface and download example code in languages, [click to open](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions).
        /// </summary>
        /// <param name="req"><see cref="ChatTranslationsRequest"/></param>
        /// <returns><see cref="ChatTranslationsResponse"/></returns>
        public Task<ChatTranslationsResponse> ChatTranslations(ChatTranslationsRequest req)
        {
            return InternalRequestAsync<ChatTranslationsResponse>(req, "ChatTranslations");
        }

        /// <summary>
        /// Tencent Hunyuan is a large language model (LLM) developed by Tencent R&D. It possesses powerful Chinese creation capacity, logical reasoning in complex context, and reliable task execution power. This API supports streaming or non-streaming calls. When using streaming calls, it follows the SSE protocol.
        /// 
        /// 1. This API does not currently support returning Image Content.
        /// 2. By default, this API has account restrictions with a number of concurrencies of 5. 
        /// 3. Please use the SDK to call this API. examples are provided in the Git repository examples/hunyuan/v20230901/ directory for each development language. The SDK link is provided in the "**Developer Resources - SDK**" part under the document.
        /// 4. We recommend you use API Explorer for quick online debugging interface and download example code in languages, [click to open](https://console.cloud.tencent.com/api/explorer?Product=hunyuan&Version=2023-09-01&Action=ChatCompletions).
        /// </summary>
        /// <param name="req"><see cref="ChatTranslationsRequest"/></param>
        /// <returns><see cref="ChatTranslationsResponse"/></returns>
        public ChatTranslationsResponse ChatTranslationsSync(ChatTranslationsRequest req)
        {
            return InternalRequestAsync<ChatTranslationsResponse>(req, "ChatTranslations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After inputting a 3D model file, the 3D model file format can be switched.
        /// </summary>
        /// <param name="req"><see cref="Convert3DFormatRequest"/></param>
        /// <returns><see cref="Convert3DFormatResponse"/></returns>
        public Task<Convert3DFormatResponse> Convert3DFormat(Convert3DFormatRequest req)
        {
            return InternalRequestAsync<Convert3DFormatResponse>(req, "Convert3DFormat");
        }

        /// <summary>
        /// After inputting a 3D model file, the 3D model file format can be switched.
        /// </summary>
        /// <param name="req"><see cref="Convert3DFormatRequest"/></param>
        /// <returns><see cref="Convert3DFormatResponse"/></returns>
        public Convert3DFormatResponse Convert3DFormatSync(Convert3DFormatRequest req)
        {
            return InternalRequestAsync<Convert3DFormatResponse>(req, "Convert3DFormat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The SmartTopoly API uses the Polygon 1.5 model. After manually inputting a 3D high-poly model, it can generate a neat 3D model with lower polygon count.
        /// 1 concurrent is provided by default, which means 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="Describe3DSmartTopologyJobRequest"/></param>
        /// <returns><see cref="Describe3DSmartTopologyJobResponse"/></returns>
        public Task<Describe3DSmartTopologyJobResponse> Describe3DSmartTopologyJob(Describe3DSmartTopologyJobRequest req)
        {
            return InternalRequestAsync<Describe3DSmartTopologyJobResponse>(req, "Describe3DSmartTopologyJob");
        }

        /// <summary>
        /// The SmartTopoly API uses the Polygon 1.5 model. After manually inputting a 3D high-poly model, it can generate a neat 3D model with lower polygon count.
        /// 1 concurrent is provided by default, which means 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="Describe3DSmartTopologyJobRequest"/></param>
        /// <returns><see cref="Describe3DSmartTopologyJobResponse"/></returns>
        public Describe3DSmartTopologyJobResponse Describe3DSmartTopologyJobSync(Describe3DSmartTopologyJobRequest req)
        {
            return InternalRequestAsync<Describe3DSmartTopologyJobResponse>(req, "Describe3DSmartTopologyJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query component splitting tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanTo3DUVJobResponse"/></returns>
        public Task<DescribeHunyuanTo3DUVJobResponse> DescribeHunyuanTo3DUVJob(DescribeHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanTo3DUVJobResponse>(req, "DescribeHunyuanTo3DUVJob");
        }

        /// <summary>
        /// Query component splitting tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="DescribeHunyuanTo3DUVJobResponse"/></returns>
        public DescribeHunyuanTo3DUVJobResponse DescribeHunyuanTo3DUVJobSync(DescribeHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<DescribeHunyuanTo3DUVJobResponse>(req, "DescribeHunyuanTo3DUVJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the generation task of a component.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="QueryHunyuan3DPartJobResponse"/></returns>
        public Task<QueryHunyuan3DPartJobResponse> QueryHunyuan3DPartJob(QueryHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuan3DPartJobResponse>(req, "QueryHunyuan3DPartJob");
        }

        /// <summary>
        /// This API is used to query the generation task of a component.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="QueryHunyuan3DPartJobResponse"/></returns>
        public QueryHunyuan3DPartJobResponse QueryHunyuan3DPartJobSync(QueryHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuan3DPartJobResponse>(req, "QueryHunyuan3DPartJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model with input text descriptions or images.
        /// This API is used to provide 1 concurrent task by default, which means only 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DRapidJobResponse"/></returns>
        public Task<QueryHunyuanTo3DRapidJobResponse> QueryHunyuanTo3DRapidJob(QueryHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DRapidJobResponse>(req, "QueryHunyuanTo3DRapidJob");
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model with input text descriptions or images.
        /// This API is used to provide 1 concurrent task by default, which means only 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DRapidJobResponse"/></returns>
        public QueryHunyuanTo3DRapidJobResponse QueryHunyuanTo3DRapidJobSync(QueryHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DRapidJobResponse>(req, "QueryHunyuanTo3DRapidJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query 3D texture edit tasks, redraw the texture of the 3D model based on semantics or images, and output a redrawn texture image.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DTextureEditJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DTextureEditJobResponse"/></returns>
        public Task<QueryHunyuanTo3DTextureEditJobResponse> QueryHunyuanTo3DTextureEditJob(QueryHunyuanTo3DTextureEditJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DTextureEditJobResponse>(req, "QueryHunyuanTo3DTextureEditJob");
        }

        /// <summary>
        /// Query 3D texture edit tasks, redraw the texture of the 3D model based on semantics or images, and output a redrawn texture image.
        /// </summary>
        /// <param name="req"><see cref="QueryHunyuanTo3DTextureEditJobRequest"/></param>
        /// <returns><see cref="QueryHunyuanTo3DTextureEditJobResponse"/></returns>
        public QueryHunyuanTo3DTextureEditJobResponse QueryHunyuanTo3DTextureEditJobSync(QueryHunyuanTo3DTextureEditJobRequest req)
        {
            return InternalRequestAsync<QueryHunyuanTo3DTextureEditJobResponse>(req, "QueryHunyuanTo3DTextureEditJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The SmartTopoly API uses the Polygen 1.5 model. After manually inputting a 3D high-poly model, it can generate a neat 3D model with lower polygon count.
        /// 1 concurrent is provided by default, which means 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="Submit3DSmartTopologyJobRequest"/></param>
        /// <returns><see cref="Submit3DSmartTopologyJobResponse"/></returns>
        public Task<Submit3DSmartTopologyJobResponse> Submit3DSmartTopologyJob(Submit3DSmartTopologyJobRequest req)
        {
            return InternalRequestAsync<Submit3DSmartTopologyJobResponse>(req, "Submit3DSmartTopologyJob");
        }

        /// <summary>
        /// The SmartTopoly API uses the Polygen 1.5 model. After manually inputting a 3D high-poly model, it can generate a neat 3D model with lower polygon count.
        /// 1 concurrent is provided by default, which means 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="Submit3DSmartTopologyJobRequest"/></param>
        /// <returns><see cref="Submit3DSmartTopologyJobResponse"/></returns>
        public Submit3DSmartTopologyJobResponse Submit3DSmartTopologyJobSync(Submit3DSmartTopologyJobRequest req)
        {
            return InternalRequestAsync<Submit3DSmartTopologyJobResponse>(req, "Submit3DSmartTopologyJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to automatically perform component identification and generation based on the model structure after inputting a 3D model file.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuan3DPartJobResponse"/></returns>
        public Task<SubmitHunyuan3DPartJobResponse> SubmitHunyuan3DPartJob(SubmitHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuan3DPartJobResponse>(req, "SubmitHunyuan3DPartJob");
        }

        /// <summary>
        /// This API is used to automatically perform component identification and generation based on the model structure after inputting a 3D model file.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuan3DPartJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuan3DPartJobResponse"/></returns>
        public SubmitHunyuan3DPartJobResponse SubmitHunyuan3DPartJobSync(SubmitHunyuan3DPartJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuan3DPartJobResponse>(req, "SubmitHunyuan3DPartJob")
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

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model with input text descriptions or images.
        /// This API is used to provide 1 concurrent task by default, which means only 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DRapidJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DRapidJobResponse> SubmitHunyuanTo3DRapidJob(SubmitHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DRapidJobResponse>(req, "SubmitHunyuanTo3DRapidJob");
        }

        /// <summary>
        /// This API is used to intelligently generate 3D content based on the HunYuan Large Model with input text descriptions or images.
        /// This API is used to provide 1 concurrent task by default, which means only 1 submitted task can be processed simultaneously. The next task can be processed only after the previous task is completed.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DRapidJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DRapidJobResponse"/></returns>
        public SubmitHunyuanTo3DRapidJobResponse SubmitHunyuanTo3DRapidJobSync(SubmitHunyuanTo3DRapidJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DRapidJobResponse>(req, "SubmitHunyuanTo3DRapidJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After inputting the 3D model, redraw the texture of the 3D model based on semantics or images, and output a redrawn texture image.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DTextureEditJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DTextureEditJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DTextureEditJobResponse> SubmitHunyuanTo3DTextureEditJob(SubmitHunyuanTo3DTextureEditJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DTextureEditJobResponse>(req, "SubmitHunyuanTo3DTextureEditJob");
        }

        /// <summary>
        /// After inputting the 3D model, redraw the texture of the 3D model based on semantics or images, and output a redrawn texture image.
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DTextureEditJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DTextureEditJobResponse"/></returns>
        public SubmitHunyuanTo3DTextureEditJobResponse SubmitHunyuanTo3DTextureEditJobSync(SubmitHunyuanTo3DTextureEditJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DTextureEditJobResponse>(req, "SubmitHunyuanTo3DTextureEditJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After inputting the model, UV unfolding can be performed based on the model texture to output the corresponding UV texture
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DUVJobResponse"/></returns>
        public Task<SubmitHunyuanTo3DUVJobResponse> SubmitHunyuanTo3DUVJob(SubmitHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DUVJobResponse>(req, "SubmitHunyuanTo3DUVJob");
        }

        /// <summary>
        /// After inputting the model, UV unfolding can be performed based on the model texture to output the corresponding UV texture
        /// </summary>
        /// <param name="req"><see cref="SubmitHunyuanTo3DUVJobRequest"/></param>
        /// <returns><see cref="SubmitHunyuanTo3DUVJobResponse"/></returns>
        public SubmitHunyuanTo3DUVJobResponse SubmitHunyuanTo3DUVJobSync(SubmitHunyuanTo3DUVJobRequest req)
        {
            return InternalRequestAsync<SubmitHunyuanTo3DUVJobResponse>(req, "SubmitHunyuanTo3DUVJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
