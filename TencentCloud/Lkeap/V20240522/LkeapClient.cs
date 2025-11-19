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

namespace TencentCloud.Lkeap.V20240522
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lkeap.V20240522.Models;

   public class LkeapClient : AbstractClient{

       private const string endpoint = "lkeap.intl.tencentcloudapi.com";
       private const string version = "2024-05-22";
       private const string sdkVersion = "SDK_NET_3.0.1239";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LkeapClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LkeapClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to initiate requests for this asynchronous API, for initiating document parsing tasks.
        /// Document parsing supports converting images or PDF files into Markdown format files, and can parse content elements including tables, formulas, images, headings, paragraphs, headers, and footers, and intelligently convert the content into reading order. Please refer to the input parameter list below for specific supported file types.
        /// During the trial period, the QPS limit for a single account is only 1. If you need to access officially, please contact our R&D team.
        /// </summary>
        /// <param name="req"><see cref="CreateReconstructDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateReconstructDocumentFlowResponse"/></returns>
        public Task<CreateReconstructDocumentFlowResponse> CreateReconstructDocumentFlow(CreateReconstructDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateReconstructDocumentFlowResponse>(req, "CreateReconstructDocumentFlow");
        }

        /// <summary>
        /// This API is used to initiate requests for this asynchronous API, for initiating document parsing tasks.
        /// Document parsing supports converting images or PDF files into Markdown format files, and can parse content elements including tables, formulas, images, headings, paragraphs, headers, and footers, and intelligently convert the content into reading order. Please refer to the input parameter list below for specific supported file types.
        /// During the trial period, the QPS limit for a single account is only 1. If you need to access officially, please contact our R&D team.
        /// </summary>
        /// <param name="req"><see cref="CreateReconstructDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateReconstructDocumentFlowResponse"/></returns>
        public CreateReconstructDocumentFlowResponse CreateReconstructDocumentFlowSync(CreateReconstructDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateReconstructDocumentFlowResponse>(req, "CreateReconstructDocumentFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create document segmentation tasks, support various file types, possess mllm capacity, and can analyze and deeply understand the information in charts.
        /// </summary>
        /// <param name="req"><see cref="CreateSplitDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateSplitDocumentFlowResponse"/></returns>
        public Task<CreateSplitDocumentFlowResponse> CreateSplitDocumentFlow(CreateSplitDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateSplitDocumentFlowResponse>(req, "CreateSplitDocumentFlow");
        }

        /// <summary>
        /// This API is used to create document segmentation tasks, support various file types, possess mllm capacity, and can analyze and deeply understand the information in charts.
        /// </summary>
        /// <param name="req"><see cref="CreateSplitDocumentFlowRequest"/></param>
        /// <returns><see cref="CreateSplitDocumentFlowResponse"/></returns>
        public CreateSplitDocumentFlowResponse CreateSplitDocumentFlowSync(CreateSplitDocumentFlowRequest req)
        {
            return InternalRequestAsync<CreateSplitDocumentFlowResponse>(req, "CreateSplitDocumentFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to call the text representation model to convert text into a vector represented by numbers, which can be used in scenarios such as text retrieval, information recommendation, and knowledge mining. There is a single-account call limit control for this API. If you need to increase the concurrency limit, please contact us (https://cloud.tencent.com/act/event/Online_service).
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public Task<GetEmbeddingResponse> GetEmbedding(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding");
        }

        /// <summary>
        /// This API is used to call the text representation model to convert text into a vector represented by numbers, which can be used in scenarios such as text retrieval, information recommendation, and knowledge mining. There is a single-account call limit control for this API. If you need to increase the concurrency limit, please contact us (https://cloud.tencent.com/act/event/Online_service).
        /// </summary>
        /// <param name="req"><see cref="GetEmbeddingRequest"/></param>
        /// <returns><see cref="GetEmbeddingResponse"/></returns>
        public GetEmbeddingResponse GetEmbeddingSync(GetEmbeddingRequest req)
        {
            return InternalRequestAsync<GetEmbeddingResponse>(req, "GetEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This is an asynchronous API for querying results, which is used to obtain the result of document parsing.
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public Task<GetReconstructDocumentResultResponse> GetReconstructDocumentResult(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult");
        }

        /// <summary>
        /// This is an asynchronous API for querying results, which is used to obtain the result of document parsing.
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public GetReconstructDocumentResultResponse GetReconstructDocumentResultSync(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the results of document splitting tasks.
        /// </summary>
        /// <param name="req"><see cref="GetSplitDocumentResultRequest"/></param>
        /// <returns><see cref="GetSplitDocumentResultResponse"/></returns>
        public Task<GetSplitDocumentResultResponse> GetSplitDocumentResult(GetSplitDocumentResultRequest req)
        {
            return InternalRequestAsync<GetSplitDocumentResultResponse>(req, "GetSplitDocumentResult");
        }

        /// <summary>
        /// This API is used to query the results of document splitting tasks.
        /// </summary>
        /// <param name="req"><see cref="GetSplitDocumentResultRequest"/></param>
        /// <returns><see cref="GetSplitDocumentResultResponse"/></returns>
        public GetSplitDocumentResultResponse GetSplitDocumentResultSync(GetSplitDocumentResultRequest req)
        {
            return InternalRequestAsync<GetSplitDocumentResultResponse>(req, "GetSplitDocumentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// QueryRewrite is mainly used in multi-round conversations for reference resolution and ellipsis completion. Using this API, you don't need to input prompt descriptions. A more accurate user query can be generated based on the conversation history. In terms of application scenarios, this API can be applied to various scenarios such as intelligent Q&A and conversational search.
        /// There is a call limit for single-account for this API. If you need to increase the concurrency limit, please contact us (https://cloud.tencent.com/act/event/Online_service).
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public Task<QueryRewriteResponse> QueryRewrite(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite");
        }

        /// <summary>
        /// QueryRewrite is mainly used in multi-round conversations for reference resolution and ellipsis completion. Using this API, you don't need to input prompt descriptions. A more accurate user query can be generated based on the conversation history. In terms of application scenarios, this API can be applied to various scenarios such as intelligent Q&A and conversational search.
        /// There is a call limit for single-account for this API. If you need to increase the concurrency limit, please contact us (https://cloud.tencent.com/act/event/Online_service).
        /// </summary>
        /// <param name="req"><see cref="QueryRewriteRequest"/></param>
        /// <returns><see cref="QueryRewriteResponse"/></returns>
        public QueryRewriteResponse QueryRewriteSync(QueryRewriteRequest req)
        {
            return InternalRequestAsync<QueryRewriteResponse>(req, "QueryRewrite")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used for quasi-real-time document parsing, using HTTP SSE protocol for communication.
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentSSERequest"/></param>
        /// <returns><see cref="ReconstructDocumentSSEResponse"/></returns>
        public Task<ReconstructDocumentSSEResponse> ReconstructDocumentSSE(ReconstructDocumentSSERequest req)
        {
            return InternalRequestAsync<ReconstructDocumentSSEResponse>(req, "ReconstructDocumentSSE");
        }

        /// <summary>
        /// This API is used for quasi-real-time document parsing, using HTTP SSE protocol for communication.
        /// </summary>
        /// <param name="req"><see cref="ReconstructDocumentSSERequest"/></param>
        /// <returns><see cref="ReconstructDocumentSSEResponse"/></returns>
        public ReconstructDocumentSSEResponse ReconstructDocumentSSESync(ReconstructDocumentSSERequest req)
        {
            return InternalRequestAsync<ReconstructDocumentSSEResponse>(req, "ReconstructDocumentSSE")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reorder the results of multi-channel recall based on the rerank model of knowledge engine fine-tuning model technology, sort the segments according to the relevance between the query and the segment content from high to low score, and output the corresponding scoring results.
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public Task<RunRerankResponse> RunRerank(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank");
        }

        /// <summary>
        /// This API is used to reorder the results of multi-channel recall based on the rerank model of knowledge engine fine-tuning model technology, sort the segments according to the relevance between the query and the segment content from high to low score, and output the corresponding scoring results.
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public RunRerankResponse RunRerankSync(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
