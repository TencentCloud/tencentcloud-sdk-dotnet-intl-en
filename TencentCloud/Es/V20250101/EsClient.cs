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

namespace TencentCloud.Es.V20250101
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20250101.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.intl.tencentcloudapi.com";
       private const string version = "2025-01-01";
       private const string sdkVersion = "SDK_NET_3.0.1356";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Text segmentation is a technology that splits long text into short fragments for adapting to model input, improving processing efficiency, or information retrieval. It balances fragment length and semantic consistency, suitable for NLP and data analysis scenarios.
        /// This API is used to slice text based on delimiter rules. It has a single-account call limit. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentRequest"/></param>
        /// <returns><see cref="ChunkDocumentResponse"/></returns>
        public Task<ChunkDocumentResponse> ChunkDocument(ChunkDocumentRequest req)
        {
            return InternalRequestAsync<ChunkDocumentResponse>(req, "ChunkDocument");
        }

        /// <summary>
        /// Text segmentation is a technology that splits long text into short fragments for adapting to model input, improving processing efficiency, or information retrieval. It balances fragment length and semantic consistency, suitable for NLP and data analysis scenarios.
        /// This API is used to slice text based on delimiter rules. It has a single-account call limit. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentRequest"/></param>
        /// <returns><see cref="ChunkDocumentResponse"/></returns>
        public ChunkDocumentResponse ChunkDocumentSync(ChunkDocumentRequest req)
        {
            return InternalRequestAsync<ChunkDocumentResponse>(req, "ChunkDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Text segmentation is a technology that splits long text into short clips for adapting to model input, improving processing efficiency, or information retrieval. It balances clip length and semantic consistency, suitable for NLP and data analysis scenarios.
        /// This API is an async API with a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentAsyncRequest"/></param>
        /// <returns><see cref="ChunkDocumentAsyncResponse"/></returns>
        public Task<ChunkDocumentAsyncResponse> ChunkDocumentAsync(ChunkDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ChunkDocumentAsyncResponse>(req, "ChunkDocumentAsync");
        }

        /// <summary>
        /// Text segmentation is a technology that splits long text into short clips for adapting to model input, improving processing efficiency, or information retrieval. It balances clip length and semantic consistency, suitable for NLP and data analysis scenarios.
        /// This API is an async API with a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ChunkDocumentAsyncRequest"/></param>
        /// <returns><see cref="ChunkDocumentAsyncResponse"/></returns>
        public ChunkDocumentAsyncResponse ChunkDocumentAsyncSync(ChunkDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ChunkDocumentAsyncResponse>(req, "ChunkDocumentAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieve document slices
        /// </summary>
        /// <param name="req"><see cref="GetDocumentChunkResultRequest"/></param>
        /// <returns><see cref="GetDocumentChunkResultResponse"/></returns>
        public Task<GetDocumentChunkResultResponse> GetDocumentChunkResult(GetDocumentChunkResultRequest req)
        {
            return InternalRequestAsync<GetDocumentChunkResultResponse>(req, "GetDocumentChunkResult");
        }

        /// <summary>
        /// Retrieve document slices
        /// </summary>
        /// <param name="req"><see cref="GetDocumentChunkResultRequest"/></param>
        /// <returns><see cref="GetDocumentChunkResultResponse"/></returns>
        public GetDocumentChunkResultResponse GetDocumentChunkResultSync(GetDocumentChunkResultRequest req)
        {
            return InternalRequestAsync<GetDocumentChunkResultResponse>(req, "GetDocumentChunkResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the asynchronous processing result of document parsing.
        /// </summary>
        /// <param name="req"><see cref="GetDocumentParseResultRequest"/></param>
        /// <returns><see cref="GetDocumentParseResultResponse"/></returns>
        public Task<GetDocumentParseResultResponse> GetDocumentParseResult(GetDocumentParseResultRequest req)
        {
            return InternalRequestAsync<GetDocumentParseResultResponse>(req, "GetDocumentParseResult");
        }

        /// <summary>
        /// This API is used to retrieve the asynchronous processing result of document parsing.
        /// </summary>
        /// <param name="req"><see cref="GetDocumentParseResultRequest"/></param>
        /// <returns><see cref="GetDocumentParseResultResponse"/></returns>
        public GetDocumentParseResultResponse GetDocumentParseResultSync(GetDocumentParseResultRequest req)
        {
            return InternalRequestAsync<GetDocumentParseResultResponse>(req, "GetDocumentParseResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Embedding is a technology that maps high-dimensional data to a low-dimensional space, usually used for converting unstructured data such as text, images, or audio into vector representation, making it easier to input into machine models for processing, and the distance between vectors can reflect the similarity between objects. 
        /// This API has a model dimensional call limit. Each model has a qps limit of 10. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetMultiModalEmbeddingRequest"/></param>
        /// <returns><see cref="GetMultiModalEmbeddingResponse"/></returns>
        public Task<GetMultiModalEmbeddingResponse> GetMultiModalEmbedding(GetMultiModalEmbeddingRequest req)
        {
            return InternalRequestAsync<GetMultiModalEmbeddingResponse>(req, "GetMultiModalEmbedding");
        }

        /// <summary>
        /// Embedding is a technology that maps high-dimensional data to a low-dimensional space, usually used for converting unstructured data such as text, images, or audio into vector representation, making it easier to input into machine models for processing, and the distance between vectors can reflect the similarity between objects. 
        /// This API has a model dimensional call limit. Each model has a qps limit of 10. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetMultiModalEmbeddingRequest"/></param>
        /// <returns><see cref="GetMultiModalEmbeddingResponse"/></returns>
        public GetMultiModalEmbeddingResponse GetMultiModalEmbeddingSync(GetMultiModalEmbeddingRequest req)
        {
            return InternalRequestAsync<GetMultiModalEmbeddingResponse>(req, "GetMultiModalEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Embedding is a technology that maps high-dimensional data to a low-dimensional space, usually used for converting unstructured data such as text, images, or audio into vector representation, making it easier to input into machine models for processing, and the distance between vectors can reflect the similarity between objects.
        /// This API has a model dimensional call limit. Each model has a qps limit of 20. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetTextEmbeddingRequest"/></param>
        /// <returns><see cref="GetTextEmbeddingResponse"/></returns>
        public Task<GetTextEmbeddingResponse> GetTextEmbedding(GetTextEmbeddingRequest req)
        {
            return InternalRequestAsync<GetTextEmbeddingResponse>(req, "GetTextEmbedding");
        }

        /// <summary>
        /// Embedding is a technology that maps high-dimensional data to a low-dimensional space, usually used for converting unstructured data such as text, images, or audio into vector representation, making it easier to input into machine models for processing, and the distance between vectors can reflect the similarity between objects.
        /// This API has a model dimensional call limit. Each model has a qps limit of 20. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="GetTextEmbeddingRequest"/></param>
        /// <returns><see cref="GetTextEmbeddingResponse"/></returns>
        public GetTextEmbeddingResponse GetTextEmbeddingSync(GetTextEmbeddingRequest req)
        {
            return InternalRequestAsync<GetTextEmbeddingResponse>(req, "GetTextEmbedding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This service can accurately convert various types of documents into a standard format to meet the requirements for building an enterprise knowledge base, migrating technical documentation, and structured storage for content platforms.
        /// This API has a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentRequest"/></param>
        /// <returns><see cref="ParseDocumentResponse"/></returns>
        public Task<ParseDocumentResponse> ParseDocument(ParseDocumentRequest req)
        {
            return InternalRequestAsync<ParseDocumentResponse>(req, "ParseDocument");
        }

        /// <summary>
        /// This service can accurately convert various types of documents into a standard format to meet the requirements for building an enterprise knowledge base, migrating technical documentation, and structured storage for content platforms.
        /// This API has a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentRequest"/></param>
        /// <returns><see cref="ParseDocumentResponse"/></returns>
        public ParseDocumentResponse ParseDocumentSync(ParseDocumentRequest req)
        {
            return InternalRequestAsync<ParseDocumentResponse>(req, "ParseDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This service accurately converts various format documents into standard format, meeting requirements for Enterprise Knowledge Base construction, technical documentation migration, and structured storage for content platforms.
        /// This API is an async API with a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentAsyncRequest"/></param>
        /// <returns><see cref="ParseDocumentAsyncResponse"/></returns>
        public Task<ParseDocumentAsyncResponse> ParseDocumentAsync(ParseDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ParseDocumentAsyncResponse>(req, "ParseDocumentAsync");
        }

        /// <summary>
        /// This service accurately converts various format documents into standard format, meeting requirements for Enterprise Knowledge Base construction, technical documentation migration, and structured storage for content platforms.
        /// This API is an async API with a model dimensional call limit. Each model has a qps limit of 5. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="ParseDocumentAsyncRequest"/></param>
        /// <returns><see cref="ParseDocumentAsyncResponse"/></returns>
        public ParseDocumentAsyncResponse ParseDocumentAsyncSync(ParseDocumentAsyncRequest req)
        {
            return InternalRequestAsync<ParseDocumentAsyncResponse>(req, "ParseDocumentAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Rearrangement refers to the process in RAG where, by assessing the relevance between documents and queries, the most relevant documents are placed at the front. This ensures that the language model prioritizes high-ranking context when generating responses, improving the accuracy and reliability of generated results. It can also be used for filtering to reduce large model costs.
        /// This API has a single-account call limit. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="RunRerankRequest"/></param>
        /// <returns><see cref="RunRerankResponse"/></returns>
        public Task<RunRerankResponse> RunRerank(RunRerankRequest req)
        {
            return InternalRequestAsync<RunRerankResponse>(req, "RunRerank");
        }

        /// <summary>
        /// Rearrangement refers to the process in RAG where, by assessing the relevance between documents and queries, the most relevant documents are placed at the front. This ensures that the language model prioritizes high-ranking context when generating responses, improving the accuracy and reliability of generated results. It can also be used for filtering to reduce large model costs.
        /// This API has a single-account call limit. If you need to increase the concurrent limit, please contact us (https://www.tencentcloud.com/act/event/Online_service?from_cn_redirect=1).
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
