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

namespace TencentCloud.Lke.V20231130
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lke.V20231130.Models;

   public class LkeClient : AbstractClient{

       private const string endpoint = "lke.intl.tencentcloudapi.com";
       private const string version = "2023-11-30";
       private const string sdkVersion = "SDK_NET_3.0.1164";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to check if the label name under an attribute exist.
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelExistRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelExistResponse"/></returns>
        public Task<CheckAttributeLabelExistResponse> CheckAttributeLabelExist(CheckAttributeLabelExistRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelExistResponse>(req, "CheckAttributeLabelExist");
        }

        /// <summary>
        /// This API is used to check if the label name under an attribute exist.
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelExistRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelExistResponse"/></returns>
        public CheckAttributeLabelExistResponse CheckAttributeLabelExistSync(CheckAttributeLabelExistRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelExistResponse>(req, "CheckAttributeLabelExist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check attribute label references.
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelReferRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelReferResponse"/></returns>
        public Task<CheckAttributeLabelReferResponse> CheckAttributeLabelRefer(CheckAttributeLabelReferRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelReferResponse>(req, "CheckAttributeLabelRefer");
        }

        /// <summary>
        /// This API is used to check attribute label references.
        /// </summary>
        /// <param name="req"><see cref="CheckAttributeLabelReferRequest"/></param>
        /// <returns><see cref="CheckAttributeLabelReferResponse"/></returns>
        public CheckAttributeLabelReferResponse CheckAttributeLabelReferSync(CheckAttributeLabelReferRequest req)
        {
            return InternalRequestAsync<CheckAttributeLabelReferResponse>(req, "CheckAttributeLabelRefer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create knowledge engine applications.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp");
        }

        /// <summary>
        /// This API is used to create knowledge engine applications.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
            return InternalRequestAsync<CreateAppResponse>(req, "CreateApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create attributes.
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public Task<CreateAttributeLabelResponse> CreateAttributeLabel(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel");
        }

        /// <summary>
        /// This API is used to create attributes.
        /// </summary>
        /// <param name="req"><see cref="CreateAttributeLabelRequest"/></param>
        /// <returns><see cref="CreateAttributeLabelResponse"/></returns>
        public CreateAttributeLabelResponse CreateAttributeLabelSync(CreateAttributeLabelRequest req)
        {
            return InternalRequestAsync<CreateAttributeLabelResponse>(req, "CreateAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create enterprises.
        /// </summary>
        /// <param name="req"><see cref="CreateCorpRequest"/></param>
        /// <returns><see cref="CreateCorpResponse"/></returns>
        public Task<CreateCorpResponse> CreateCorp(CreateCorpRequest req)
        {
            return InternalRequestAsync<CreateCorpResponse>(req, "CreateCorp");
        }

        /// <summary>
        /// This API is used to create enterprises.
        /// </summary>
        /// <param name="req"><see cref="CreateCorpRequest"/></param>
        /// <returns><see cref="CreateCorpResponse"/></returns>
        public CreateCorpResponse CreateCorpSync(CreateCorpRequest req)
        {
            return InternalRequestAsync<CreateCorpResponse>(req, "CreateCorp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create doc categories.
        /// </summary>
        /// <param name="req"><see cref="CreateDocCateRequest"/></param>
        /// <returns><see cref="CreateDocCateResponse"/></returns>
        public Task<CreateDocCateResponse> CreateDocCate(CreateDocCateRequest req)
        {
            return InternalRequestAsync<CreateDocCateResponse>(req, "CreateDocCate");
        }

        /// <summary>
        /// This API is used to create doc categories.
        /// </summary>
        /// <param name="req"><see cref="CreateDocCateRequest"/></param>
        /// <returns><see cref="CreateDocCateResponse"/></returns>
        public CreateDocCateResponse CreateDocCateSync(CreateDocCateRequest req)
        {
            return InternalRequestAsync<CreateDocCateResponse>(req, "CreateDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enter Q&As.
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public Task<CreateQAResponse> CreateQA(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA");
        }

        /// <summary>
        /// This API is used to enter Q&As.
        /// </summary>
        /// <param name="req"><see cref="CreateQARequest"/></param>
        /// <returns><see cref="CreateQAResponse"/></returns>
        public CreateQAResponse CreateQASync(CreateQARequest req)
        {
            return InternalRequestAsync<CreateQAResponse>(req, "CreateQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="CreateQACateRequest"/></param>
        /// <returns><see cref="CreateQACateResponse"/></returns>
        public Task<CreateQACateResponse> CreateQACate(CreateQACateRequest req)
        {
            return InternalRequestAsync<CreateQACateResponse>(req, "CreateQACate");
        }

        /// <summary>
        /// This API is used to create Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="CreateQACateRequest"/></param>
        /// <returns><see cref="CreateQACateResponse"/></returns>
        public CreateQACateResponse CreateQACateSync(CreateQACateRequest req)
        {
            return InternalRequestAsync<CreateQACateResponse>(req, "CreateQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initiate requests for this asynchronous API, for initiating document parsing tasks.
        /// Document parsing supports converting images or PDF files into Markdown format files, and can parse content elements including tables, formulas, images, headings, paragraphs, headers, and footers, and intelligently convert the content into reading order.
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
        /// Document parsing supports converting images or PDF files into Markdown format files, and can parse content elements including tables, formulas, images, headings, paragraphs, headers, and footers, and intelligently convert the content into reading order.
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
        /// This API is used to create rejected questions.
        /// </summary>
        /// <param name="req"><see cref="CreateRejectedQuestionRequest"/></param>
        /// <returns><see cref="CreateRejectedQuestionResponse"/></returns>
        public Task<CreateRejectedQuestionResponse> CreateRejectedQuestion(CreateRejectedQuestionRequest req)
        {
            return InternalRequestAsync<CreateRejectedQuestionResponse>(req, "CreateRejectedQuestion");
        }

        /// <summary>
        /// This API is used to create rejected questions.
        /// </summary>
        /// <param name="req"><see cref="CreateRejectedQuestionRequest"/></param>
        /// <returns><see cref="CreateRejectedQuestionResponse"/></returns>
        public CreateRejectedQuestionResponse CreateRejectedQuestionSync(CreateRejectedQuestionRequest req)
        {
            return InternalRequestAsync<CreateRejectedQuestionResponse>(req, "CreateRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a release.
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public Task<CreateReleaseResponse> CreateRelease(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease");
        }

        /// <summary>
        /// This API is used to create a release.
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseRequest"/></param>
        /// <returns><see cref="CreateReleaseResponse"/></returns>
        public CreateReleaseResponse CreateReleaseSync(CreateReleaseRequest req)
        {
            return InternalRequestAsync<CreateReleaseResponse>(req, "CreateRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete applications.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public Task<DeleteAppResponse> DeleteApp(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp");
        }

        /// <summary>
        /// This API is used to delete applications.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public DeleteAppResponse DeleteAppSync(DeleteAppRequest req)
        {
            return InternalRequestAsync<DeleteAppResponse>(req, "DeleteApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete attribute labels.
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelResponse"/></returns>
        public Task<DeleteAttributeLabelResponse> DeleteAttributeLabel(DeleteAttributeLabelRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelResponse>(req, "DeleteAttributeLabel");
        }

        /// <summary>
        /// This API is used to delete attribute labels.
        /// </summary>
        /// <param name="req"><see cref="DeleteAttributeLabelRequest"/></param>
        /// <returns><see cref="DeleteAttributeLabelResponse"/></returns>
        public DeleteAttributeLabelResponse DeleteAttributeLabelSync(DeleteAttributeLabelRequest req)
        {
            return InternalRequestAsync<DeleteAttributeLabelResponse>(req, "DeleteAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete documents.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocRequest"/></param>
        /// <returns><see cref="DeleteDocResponse"/></returns>
        public Task<DeleteDocResponse> DeleteDoc(DeleteDocRequest req)
        {
            return InternalRequestAsync<DeleteDocResponse>(req, "DeleteDoc");
        }

        /// <summary>
        /// This API is used to delete documents.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocRequest"/></param>
        /// <returns><see cref="DeleteDocResponse"/></returns>
        public DeleteDocResponse DeleteDocSync(DeleteDocRequest req)
        {
            return InternalRequestAsync<DeleteDocResponse>(req, "DeleteDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Doc categories.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocCateRequest"/></param>
        /// <returns><see cref="DeleteDocCateResponse"/></returns>
        public Task<DeleteDocCateResponse> DeleteDocCate(DeleteDocCateRequest req)
        {
            return InternalRequestAsync<DeleteDocCateResponse>(req, "DeleteDocCate");
        }

        /// <summary>
        /// This API is used to delete Doc categories.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocCateRequest"/></param>
        /// <returns><see cref="DeleteDocCateResponse"/></returns>
        public DeleteDocCateResponse DeleteDocCateSync(DeleteDocCateRequest req)
        {
            return InternalRequestAsync<DeleteDocCateResponse>(req, "DeleteDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete Q&As.
        /// </summary>
        /// <param name="req"><see cref="DeleteQARequest"/></param>
        /// <returns><see cref="DeleteQAResponse"/></returns>
        public Task<DeleteQAResponse> DeleteQA(DeleteQARequest req)
        {
            return InternalRequestAsync<DeleteQAResponse>(req, "DeleteQA");
        }

        /// <summary>
        /// This API is used to delete Q&As.
        /// </summary>
        /// <param name="req"><see cref="DeleteQARequest"/></param>
        /// <returns><see cref="DeleteQAResponse"/></returns>
        public DeleteQAResponse DeleteQASync(DeleteQARequest req)
        {
            return InternalRequestAsync<DeleteQAResponse>(req, "DeleteQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete categories.
        /// </summary>
        /// <param name="req"><see cref="DeleteQACateRequest"/></param>
        /// <returns><see cref="DeleteQACateResponse"/></returns>
        public Task<DeleteQACateResponse> DeleteQACate(DeleteQACateRequest req)
        {
            return InternalRequestAsync<DeleteQACateResponse>(req, "DeleteQACate");
        }

        /// <summary>
        /// This API is used to delete categories.
        /// </summary>
        /// <param name="req"><see cref="DeleteQACateRequest"/></param>
        /// <returns><see cref="DeleteQACateResponse"/></returns>
        public DeleteQACateResponse DeleteQACateSync(DeleteQACateRequest req)
        {
            return InternalRequestAsync<DeleteQACateResponse>(req, "DeleteQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete rejected questions.
        /// </summary>
        /// <param name="req"><see cref="DeleteRejectedQuestionRequest"/></param>
        /// <returns><see cref="DeleteRejectedQuestionResponse"/></returns>
        public Task<DeleteRejectedQuestionResponse> DeleteRejectedQuestion(DeleteRejectedQuestionRequest req)
        {
            return InternalRequestAsync<DeleteRejectedQuestionResponse>(req, "DeleteRejectedQuestion");
        }

        /// <summary>
        /// This API is used to delete rejected questions.
        /// </summary>
        /// <param name="req"><see cref="DeleteRejectedQuestionRequest"/></param>
        /// <returns><see cref="DeleteRejectedQuestionResponse"/></returns>
        public DeleteRejectedQuestionResponse DeleteRejectedQuestionSync(DeleteRejectedQuestionRequest req)
        {
            return InternalRequestAsync<DeleteRejectedQuestionResponse>(req, "DeleteRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain application details under the corporate.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp");
        }

        /// <summary>
        /// This API is used to obtain application details under the corporate.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query attribute label details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttributeLabelRequest"/></param>
        /// <returns><see cref="DescribeAttributeLabelResponse"/></returns>
        public Task<DescribeAttributeLabelResponse> DescribeAttributeLabel(DescribeAttributeLabelRequest req)
        {
            return InternalRequestAsync<DescribeAttributeLabelResponse>(req, "DescribeAttributeLabel");
        }

        /// <summary>
        /// This API is used to query attribute label details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAttributeLabelRequest"/></param>
        /// <returns><see cref="DescribeAttributeLabelResponse"/></returns>
        public DescribeAttributeLabelResponse DescribeAttributeLabelSync(DescribeAttributeLabelRequest req)
        {
            return InternalRequestAsync<DescribeAttributeLabelResponse>(req, "DescribeAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to show line chart of API calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeCallStatsGraphResponse"/></returns>
        public Task<DescribeCallStatsGraphResponse> DescribeCallStatsGraph(DescribeCallStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeCallStatsGraphResponse>(req, "DescribeCallStatsGraph");
        }

        /// <summary>
        /// This API is used to show line chart of API calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeCallStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeCallStatsGraphResponse"/></returns>
        public DescribeCallStatsGraphResponse DescribeCallStatsGraphSync(DescribeCallStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeCallStatsGraphResponse>(req, "DescribeCallStatsGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to response to concurrent calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageResponse"/></returns>
        public Task<DescribeConcurrencyUsageResponse> DescribeConcurrencyUsage(DescribeConcurrencyUsageRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageResponse>(req, "DescribeConcurrencyUsage");
        }

        /// <summary>
        /// This API is used to response to concurrent calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageResponse"/></returns>
        public DescribeConcurrencyUsageResponse DescribeConcurrencyUsageSync(DescribeConcurrencyUsageRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageResponse>(req, "DescribeConcurrencyUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to show line chart of concurrent calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageGraphResponse"/></returns>
        public Task<DescribeConcurrencyUsageGraphResponse> DescribeConcurrencyUsageGraph(DescribeConcurrencyUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageGraphResponse>(req, "DescribeConcurrencyUsageGraph");
        }

        /// <summary>
        /// This API is used to show line chart of concurrent calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeConcurrencyUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeConcurrencyUsageGraphResponse"/></returns>
        public DescribeConcurrencyUsageGraphResponse DescribeConcurrencyUsageGraphSync(DescribeConcurrencyUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeConcurrencyUsageGraphResponse>(req, "DescribeConcurrencyUsageGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query corporate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpRequest"/></param>
        /// <returns><see cref="DescribeCorpResponse"/></returns>
        public Task<DescribeCorpResponse> DescribeCorp(DescribeCorpRequest req)
        {
            return InternalRequestAsync<DescribeCorpResponse>(req, "DescribeCorp");
        }

        /// <summary>
        /// This API is used to query corporate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpRequest"/></param>
        /// <returns><see cref="DescribeCorpResponse"/></returns>
        public DescribeCorpResponse DescribeCorpSync(DescribeCorpRequest req)
        {
            return InternalRequestAsync<DescribeCorpResponse>(req, "DescribeCorp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query document details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public Task<DescribeDocResponse> DescribeDoc(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc");
        }

        /// <summary>
        /// This API is used to query document details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocRequest"/></param>
        /// <returns><see cref="DescribeDocResponse"/></returns>
        public DescribeDocResponse DescribeDocSync(DescribeDocRequest req)
        {
            return InternalRequestAsync<DescribeDocResponse>(req, "DescribeDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the knowledge library usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsageRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsageResponse"/></returns>
        public Task<DescribeKnowledgeUsageResponse> DescribeKnowledgeUsage(DescribeKnowledgeUsageRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsageResponse>(req, "DescribeKnowledgeUsage");
        }

        /// <summary>
        /// This API is used to query the knowledge library usage.
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsageRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsageResponse"/></returns>
        public DescribeKnowledgeUsageResponse DescribeKnowledgeUsageSync(DescribeKnowledgeUsageRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsageResponse>(req, "DescribeKnowledgeUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query pie chart of the enterprise knowledge base capacity .
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsagePieGraphRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsagePieGraphResponse"/></returns>
        public Task<DescribeKnowledgeUsagePieGraphResponse> DescribeKnowledgeUsagePieGraph(DescribeKnowledgeUsagePieGraphRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsagePieGraphResponse>(req, "DescribeKnowledgeUsagePieGraph");
        }

        /// <summary>
        /// This API is used to query pie chart of the enterprise knowledge base capacity .
        /// </summary>
        /// <param name="req"><see cref="DescribeKnowledgeUsagePieGraphRequest"/></param>
        /// <returns><see cref="DescribeKnowledgeUsagePieGraphResponse"/></returns>
        public DescribeKnowledgeUsagePieGraphResponse DescribeKnowledgeUsagePieGraphSync(DescribeKnowledgeUsagePieGraphRequest req)
        {
            return InternalRequestAsync<DescribeKnowledgeUsagePieGraphResponse>(req, "DescribeKnowledgeUsagePieGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Q&A details.
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public Task<DescribeQAResponse> DescribeQA(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA");
        }

        /// <summary>
        /// This API is used to query Q&A details.
        /// </summary>
        /// <param name="req"><see cref="DescribeQARequest"/></param>
        /// <returns><see cref="DescribeQAResponse"/></returns>
        public DescribeQAResponse DescribeQASync(DescribeQARequest req)
        {
            return InternalRequestAsync<DescribeQAResponse>(req, "DescribeQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the reference source details list.
        /// </summary>
        /// <param name="req"><see cref="DescribeReferRequest"/></param>
        /// <returns><see cref="DescribeReferResponse"/></returns>
        public Task<DescribeReferResponse> DescribeRefer(DescribeReferRequest req)
        {
            return InternalRequestAsync<DescribeReferResponse>(req, "DescribeRefer");
        }

        /// <summary>
        /// This API is used to get the reference source details list.
        /// </summary>
        /// <param name="req"><see cref="DescribeReferRequest"/></param>
        /// <returns><see cref="DescribeReferResponse"/></returns>
        public DescribeReferResponse DescribeReferSync(DescribeReferRequest req)
        {
            return InternalRequestAsync<DescribeReferResponse>(req, "DescribeRefer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query release details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseRequest"/></param>
        /// <returns><see cref="DescribeReleaseResponse"/></returns>
        public Task<DescribeReleaseResponse> DescribeRelease(DescribeReleaseRequest req)
        {
            return InternalRequestAsync<DescribeReleaseResponse>(req, "DescribeRelease");
        }

        /// <summary>
        /// This API is used to query release details.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseRequest"/></param>
        /// <returns><see cref="DescribeReleaseResponse"/></returns>
        public DescribeReleaseResponse DescribeReleaseSync(DescribeReleaseRequest req)
        {
            return InternalRequestAsync<DescribeReleaseResponse>(req, "DescribeRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull the release button status and last release time.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseInfoRequest"/></param>
        /// <returns><see cref="DescribeReleaseInfoResponse"/></returns>
        public Task<DescribeReleaseInfoResponse> DescribeReleaseInfo(DescribeReleaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeReleaseInfoResponse>(req, "DescribeReleaseInfo");
        }

        /// <summary>
        /// This API is used to pull the release button status and last release time.
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseInfoRequest"/></param>
        /// <returns><see cref="DescribeReleaseInfoResponse"/></returns>
        public DescribeReleaseInfoResponse DescribeReleaseInfoSync(DescribeReleaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeReleaseInfoResponse>(req, "DescribeReleaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get application business ID through appKey.
        /// </summary>
        /// <param name="req"><see cref="DescribeRobotBizIDByAppKeyRequest"/></param>
        /// <returns><see cref="DescribeRobotBizIDByAppKeyResponse"/></returns>
        public Task<DescribeRobotBizIDByAppKeyResponse> DescribeRobotBizIDByAppKey(DescribeRobotBizIDByAppKeyRequest req)
        {
            return InternalRequestAsync<DescribeRobotBizIDByAppKeyResponse>(req, "DescribeRobotBizIDByAppKey");
        }

        /// <summary>
        /// This API is used to get application business ID through appKey.
        /// </summary>
        /// <param name="req"><see cref="DescribeRobotBizIDByAppKeyRequest"/></param>
        /// <returns><see cref="DescribeRobotBizIDByAppKeyResponse"/></returns>
        public DescribeRobotBizIDByAppKeyResponse DescribeRobotBizIDByAppKeySync(DescribeRobotBizIDByAppKeyRequest req)
        {
            return InternalRequestAsync<DescribeRobotBizIDByAppKeyResponse>(req, "DescribeRobotBizIDByAppKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query line chart of search service calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeSearchStatsGraphResponse"/></returns>
        public Task<DescribeSearchStatsGraphResponse> DescribeSearchStatsGraph(DescribeSearchStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeSearchStatsGraphResponse>(req, "DescribeSearchStatsGraph");
        }

        /// <summary>
        /// This API is used to query line chart of search service calls.
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchStatsGraphRequest"/></param>
        /// <returns><see cref="DescribeSearchStatsGraphResponse"/></returns>
        public DescribeSearchStatsGraphResponse DescribeSearchStatsGraphSync(DescribeSearchStatsGraphRequest req)
        {
            return InternalRequestAsync<DescribeSearchStatsGraphResponse>(req, "DescribeSearchStatsGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get fragment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentsRequest"/></param>
        /// <returns><see cref="DescribeSegmentsResponse"/></returns>
        public Task<DescribeSegmentsResponse> DescribeSegments(DescribeSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeSegmentsResponse>(req, "DescribeSegments");
        }

        /// <summary>
        /// This API is used to get fragment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeSegmentsRequest"/></param>
        /// <returns><see cref="DescribeSegmentsResponse"/></returns>
        public DescribeSegmentsResponse DescribeSegmentsSync(DescribeSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeSegmentsResponse>(req, "DescribeSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the temporary key for file upload.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageCredentialRequest"/></param>
        /// <returns><see cref="DescribeStorageCredentialResponse"/></returns>
        public Task<DescribeStorageCredentialResponse> DescribeStorageCredential(DescribeStorageCredentialRequest req)
        {
            return InternalRequestAsync<DescribeStorageCredentialResponse>(req, "DescribeStorageCredential");
        }

        /// <summary>
        /// This API is used to get the temporary key for file upload.
        /// </summary>
        /// <param name="req"><see cref="DescribeStorageCredentialRequest"/></param>
        /// <returns><see cref="DescribeStorageCredentialResponse"/></returns>
        public DescribeStorageCredentialResponse DescribeStorageCredentialSync(DescribeStorageCredentialRequest req)
        {
            return InternalRequestAsync<DescribeStorageCredentialResponse>(req, "DescribeStorageCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query API call token details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageResponse"/></returns>
        public Task<DescribeTokenUsageResponse> DescribeTokenUsage(DescribeTokenUsageRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageResponse>(req, "DescribeTokenUsage");
        }

        /// <summary>
        /// This API is used to query API call token details.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageResponse"/></returns>
        public DescribeTokenUsageResponse DescribeTokenUsageSync(DescribeTokenUsageRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageResponse>(req, "DescribeTokenUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to show API call token line chart.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageGraphResponse"/></returns>
        public Task<DescribeTokenUsageGraphResponse> DescribeTokenUsageGraph(DescribeTokenUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageGraphResponse>(req, "DescribeTokenUsageGraph");
        }

        /// <summary>
        /// This API is used to show API call token line chart.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenUsageGraphRequest"/></param>
        /// <returns><see cref="DescribeTokenUsageGraphResponse"/></returns>
        public DescribeTokenUsageGraphResponse DescribeTokenUsageGraphSync(DescribeTokenUsageGraphRequest req)
        {
            return InternalRequestAsync<DescribeTokenUsageGraphResponse>(req, "DescribeTokenUsageGraph")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the context of dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnsatisfiedReplyContextRequest"/></param>
        /// <returns><see cref="DescribeUnsatisfiedReplyContextResponse"/></returns>
        public Task<DescribeUnsatisfiedReplyContextResponse> DescribeUnsatisfiedReplyContext(DescribeUnsatisfiedReplyContextRequest req)
        {
            return InternalRequestAsync<DescribeUnsatisfiedReplyContextResponse>(req, "DescribeUnsatisfiedReplyContext");
        }

        /// <summary>
        /// This API is used to get the context of dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="DescribeUnsatisfiedReplyContextRequest"/></param>
        /// <returns><see cref="DescribeUnsatisfiedReplyContextResponse"/></returns>
        public DescribeUnsatisfiedReplyContextResponse DescribeUnsatisfiedReplyContextSync(DescribeUnsatisfiedReplyContextRequest req)
        {
            return InternalRequestAsync<DescribeUnsatisfiedReplyContextResponse>(req, "DescribeUnsatisfiedReplyContext")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export attribute labels.
        /// </summary>
        /// <param name="req"><see cref="ExportAttributeLabelRequest"/></param>
        /// <returns><see cref="ExportAttributeLabelResponse"/></returns>
        public Task<ExportAttributeLabelResponse> ExportAttributeLabel(ExportAttributeLabelRequest req)
        {
            return InternalRequestAsync<ExportAttributeLabelResponse>(req, "ExportAttributeLabel");
        }

        /// <summary>
        /// This API is used to export attribute labels.
        /// </summary>
        /// <param name="req"><see cref="ExportAttributeLabelRequest"/></param>
        /// <returns><see cref="ExportAttributeLabelResponse"/></returns>
        public ExportAttributeLabelResponse ExportAttributeLabelSync(ExportAttributeLabelRequest req)
        {
            return InternalRequestAsync<ExportAttributeLabelResponse>(req, "ExportAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export Q&A list.
        /// </summary>
        /// <param name="req"><see cref="ExportQAListRequest"/></param>
        /// <returns><see cref="ExportQAListResponse"/></returns>
        public Task<ExportQAListResponse> ExportQAList(ExportQAListRequest req)
        {
            return InternalRequestAsync<ExportQAListResponse>(req, "ExportQAList");
        }

        /// <summary>
        /// This API is used to export Q&A list.
        /// </summary>
        /// <param name="req"><see cref="ExportQAListRequest"/></param>
        /// <returns><see cref="ExportQAListResponse"/></returns>
        public ExportQAListResponse ExportQAListSync(ExportQAListRequest req)
        {
            return InternalRequestAsync<ExportQAListResponse>(req, "ExportQAList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="ExportUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ExportUnsatisfiedReplyResponse"/></returns>
        public Task<ExportUnsatisfiedReplyResponse> ExportUnsatisfiedReply(ExportUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ExportUnsatisfiedReplyResponse>(req, "ExportUnsatisfiedReply");
        }

        /// <summary>
        /// This API is used to export dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="ExportUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ExportUnsatisfiedReplyResponse"/></returns>
        public ExportUnsatisfiedReplyResponse ExportUnsatisfiedReplySync(ExportUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ExportUnsatisfiedReplyResponse>(req, "ExportUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate Q%A from document.
        /// </summary>
        /// <param name="req"><see cref="GenerateQARequest"/></param>
        /// <returns><see cref="GenerateQAResponse"/></returns>
        public Task<GenerateQAResponse> GenerateQA(GenerateQARequest req)
        {
            return InternalRequestAsync<GenerateQAResponse>(req, "GenerateQA");
        }

        /// <summary>
        /// This API is used to generate Q%A from document.
        /// </summary>
        /// <param name="req"><see cref="GenerateQARequest"/></param>
        /// <returns><see cref="GenerateQAResponse"/></returns>
        public GenerateQAResponse GenerateQASync(GenerateQARequest req)
        {
            return InternalRequestAsync<GenerateQAResponse>(req, "GenerateQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get response type data statistics.
        /// </summary>
        /// <param name="req"><see cref="GetAnswerTypeDataCountRequest"/></param>
        /// <returns><see cref="GetAnswerTypeDataCountResponse"/></returns>
        public Task<GetAnswerTypeDataCountResponse> GetAnswerTypeDataCount(GetAnswerTypeDataCountRequest req)
        {
            return InternalRequestAsync<GetAnswerTypeDataCountResponse>(req, "GetAnswerTypeDataCount");
        }

        /// <summary>
        /// This API is used to get response type data statistics.
        /// </summary>
        /// <param name="req"><see cref="GetAnswerTypeDataCountRequest"/></param>
        /// <returns><see cref="GetAnswerTypeDataCountResponse"/></returns>
        public GetAnswerTypeDataCountResponse GetAnswerTypeDataCountSync(GetAnswerTypeDataCountRequest req)
        {
            return InternalRequestAsync<GetAnswerTypeDataCountResponse>(req, "GetAnswerTypeDataCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a model list.
        /// </summary>
        /// <param name="req"><see cref="GetAppKnowledgeCountRequest"/></param>
        /// <returns><see cref="GetAppKnowledgeCountResponse"/></returns>
        public Task<GetAppKnowledgeCountResponse> GetAppKnowledgeCount(GetAppKnowledgeCountRequest req)
        {
            return InternalRequestAsync<GetAppKnowledgeCountResponse>(req, "GetAppKnowledgeCount");
        }

        /// <summary>
        /// This API is used to get a model list.
        /// </summary>
        /// <param name="req"><see cref="GetAppKnowledgeCountRequest"/></param>
        /// <returns><see cref="GetAppKnowledgeCountResponse"/></returns>
        public GetAppKnowledgeCountResponse GetAppKnowledgeCountSync(GetAppKnowledgeCountRequest req)
        {
            return InternalRequestAsync<GetAppKnowledgeCountResponse>(req, "GetAppKnowledgeCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get application secret keys.
        /// </summary>
        /// <param name="req"><see cref="GetAppSecretRequest"/></param>
        /// <returns><see cref="GetAppSecretResponse"/></returns>
        public Task<GetAppSecretResponse> GetAppSecret(GetAppSecretRequest req)
        {
            return InternalRequestAsync<GetAppSecretResponse>(req, "GetAppSecret");
        }

        /// <summary>
        /// This API is used to get application secret keys.
        /// </summary>
        /// <param name="req"><see cref="GetAppSecretRequest"/></param>
        /// <returns><see cref="GetAppSecretResponse"/></returns>
        public GetAppSecretResponse GetAppSecretSync(GetAppSecretRequest req)
        {
            return InternalRequestAsync<GetAppSecretResponse>(req, "GetAppSecret")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get document preview information.
        /// </summary>
        /// <param name="req"><see cref="GetDocPreviewRequest"/></param>
        /// <returns><see cref="GetDocPreviewResponse"/></returns>
        public Task<GetDocPreviewResponse> GetDocPreview(GetDocPreviewRequest req)
        {
            return InternalRequestAsync<GetDocPreviewResponse>(req, "GetDocPreview");
        }

        /// <summary>
        /// This API is used to get document preview information.
        /// </summary>
        /// <param name="req"><see cref="GetDocPreviewRequest"/></param>
        /// <returns><see cref="GetDocPreviewResponse"/></returns>
        public GetDocPreviewResponse GetDocPreviewSync(GetDocPreviewRequest req)
        {
            return InternalRequestAsync<GetDocPreviewResponse>(req, "GetDocPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get likes and dislikes data statistics.
        /// </summary>
        /// <param name="req"><see cref="GetLikeDataCountRequest"/></param>
        /// <returns><see cref="GetLikeDataCountResponse"/></returns>
        public Task<GetLikeDataCountResponse> GetLikeDataCount(GetLikeDataCountRequest req)
        {
            return InternalRequestAsync<GetLikeDataCountResponse>(req, "GetLikeDataCount");
        }

        /// <summary>
        /// This API is used to get likes and dislikes data statistics.
        /// </summary>
        /// <param name="req"><see cref="GetLikeDataCountRequest"/></param>
        /// <returns><see cref="GetLikeDataCountResponse"/></returns>
        public GetLikeDataCountResponse GetLikeDataCountSync(GetLikeDataCountRequest req)
        {
            return InternalRequestAsync<GetLikeDataCountResponse>(req, "GetLikeDataCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain chat history based on the session ID (only historical session data within the past 180 days will be retained).
        /// </summary>
        /// <param name="req"><see cref="GetMsgRecordRequest"/></param>
        /// <returns><see cref="GetMsgRecordResponse"/></returns>
        public Task<GetMsgRecordResponse> GetMsgRecord(GetMsgRecordRequest req)
        {
            return InternalRequestAsync<GetMsgRecordResponse>(req, "GetMsgRecord");
        }

        /// <summary>
        /// This API is used to obtain chat history based on the session ID (only historical session data within the past 180 days will be retained).
        /// </summary>
        /// <param name="req"><see cref="GetMsgRecordRequest"/></param>
        /// <returns><see cref="GetMsgRecordResponse"/></returns>
        public GetMsgRecordResponse GetMsgRecordSync(GetMsgRecordRequest req)
        {
            return InternalRequestAsync<GetMsgRecordResponse>(req, "GetMsgRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This is an asynchronous APIs, used to get document parsing task results.
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public Task<GetReconstructDocumentResultResponse> GetReconstructDocumentResult(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult");
        }

        /// <summary>
        /// This is an asynchronous APIs, used to get document parsing task results.
        /// </summary>
        /// <param name="req"><see cref="GetReconstructDocumentResultRequest"/></param>
        /// <returns><see cref="GetReconstructDocumentResultResponse"/></returns>
        public GetReconstructDocumentResultResponse GetReconstructDocumentResultSync(GetReconstructDocumentResultRequest req)
        {
            return InternalRequestAsync<GetReconstructDocumentResultResponse>(req, "GetReconstructDocumentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the task status.
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public Task<GetTaskStatusResponse> GetTaskStatus(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus");
        }

        /// <summary>
        /// This API is used to get the task status.
        /// </summary>
        /// <param name="req"><see cref="GetTaskStatusRequest"/></param>
        /// <returns><see cref="GetTaskStatusResponse"/></returns>
        public GetTaskStatusResponse GetTaskStatusSync(GetTaskStatusRequest req)
        {
            return InternalRequestAsync<GetTaskStatusResponse>(req, "GetTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get ws token.
        /// </summary>
        /// <param name="req"><see cref="GetWsTokenRequest"/></param>
        /// <returns><see cref="GetWsTokenResponse"/></returns>
        public Task<GetWsTokenResponse> GetWsToken(GetWsTokenRequest req)
        {
            return InternalRequestAsync<GetWsTokenResponse>(req, "GetWsToken");
        }

        /// <summary>
        /// This API is used to get ws token.
        /// </summary>
        /// <param name="req"><see cref="GetWsTokenRequest"/></param>
        /// <returns><see cref="GetWsTokenResponse"/></returns>
        public GetWsTokenResponse GetWsTokenSync(GetWsTokenRequest req)
        {
            return InternalRequestAsync<GetWsTokenResponse>(req, "GetWsToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DocGroup.
        /// </summary>
        /// <param name="req"><see cref="GroupDocRequest"/></param>
        /// <returns><see cref="GroupDocResponse"/></returns>
        public Task<GroupDocResponse> GroupDoc(GroupDocRequest req)
        {
            return InternalRequestAsync<GroupDocResponse>(req, "GroupDoc");
        }

        /// <summary>
        /// DocGroup.
        /// </summary>
        /// <param name="req"><see cref="GroupDocRequest"/></param>
        /// <returns><see cref="GroupDocResponse"/></returns>
        public GroupDocResponse GroupDocSync(GroupDocRequest req)
        {
            return InternalRequestAsync<GroupDocResponse>(req, "GroupDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Q&A Group.
        /// </summary>
        /// <param name="req"><see cref="GroupQARequest"/></param>
        /// <returns><see cref="GroupQAResponse"/></returns>
        public Task<GroupQAResponse> GroupQA(GroupQARequest req)
        {
            return InternalRequestAsync<GroupQAResponse>(req, "GroupQA");
        }

        /// <summary>
        /// Q&A Group.
        /// </summary>
        /// <param name="req"><see cref="GroupQARequest"/></param>
        /// <returns><see cref="GroupQAResponse"/></returns>
        public GroupQAResponse GroupQASync(GroupQARequest req)
        {
            return InternalRequestAsync<GroupQAResponse>(req, "GroupQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="IgnoreUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="IgnoreUnsatisfiedReplyResponse"/></returns>
        public Task<IgnoreUnsatisfiedReplyResponse> IgnoreUnsatisfiedReply(IgnoreUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<IgnoreUnsatisfiedReplyResponse>(req, "IgnoreUnsatisfiedReply");
        }

        /// <summary>
        /// This API is used to ignore dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="IgnoreUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="IgnoreUnsatisfiedReplyResponse"/></returns>
        public IgnoreUnsatisfiedReplyResponse IgnoreUnsatisfiedReplySync(IgnoreUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<IgnoreUnsatisfiedReplyResponse>(req, "IgnoreUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the application list under the corporate.
        /// </summary>
        /// <param name="req"><see cref="ListAppRequest"/></param>
        /// <returns><see cref="ListAppResponse"/></returns>
        public Task<ListAppResponse> ListApp(ListAppRequest req)
        {
            return InternalRequestAsync<ListAppResponse>(req, "ListApp");
        }

        /// <summary>
        /// This API is used to get the application list under the corporate.
        /// </summary>
        /// <param name="req"><see cref="ListAppRequest"/></param>
        /// <returns><see cref="ListAppResponse"/></returns>
        public ListAppResponse ListAppSync(ListAppRequest req)
        {
            return InternalRequestAsync<ListAppResponse>(req, "ListApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get list of application types.
        /// </summary>
        /// <param name="req"><see cref="ListAppCategoryRequest"/></param>
        /// <returns><see cref="ListAppCategoryResponse"/></returns>
        public Task<ListAppCategoryResponse> ListAppCategory(ListAppCategoryRequest req)
        {
            return InternalRequestAsync<ListAppCategoryResponse>(req, "ListAppCategory");
        }

        /// <summary>
        /// This API is used to get list of application types.
        /// </summary>
        /// <param name="req"><see cref="ListAppCategoryRequest"/></param>
        /// <returns><see cref="ListAppCategoryResponse"/></returns>
        public ListAppCategoryResponse ListAppCategorySync(ListAppCategoryRequest req)
        {
            return InternalRequestAsync<ListAppCategoryResponse>(req, "ListAppCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the knowledge base capacity details in a list.
        /// </summary>
        /// <param name="req"><see cref="ListAppKnowledgeDetailRequest"/></param>
        /// <returns><see cref="ListAppKnowledgeDetailResponse"/></returns>
        public Task<ListAppKnowledgeDetailResponse> ListAppKnowledgeDetail(ListAppKnowledgeDetailRequest req)
        {
            return InternalRequestAsync<ListAppKnowledgeDetailResponse>(req, "ListAppKnowledgeDetail");
        }

        /// <summary>
        /// This API is used to query the knowledge base capacity details in a list.
        /// </summary>
        /// <param name="req"><see cref="ListAppKnowledgeDetailRequest"/></param>
        /// <returns><see cref="ListAppKnowledgeDetailResponse"/></returns>
        public ListAppKnowledgeDetailResponse ListAppKnowledgeDetailSync(ListAppKnowledgeDetailRequest req)
        {
            return InternalRequestAsync<ListAppKnowledgeDetailResponse>(req, "ListAppKnowledgeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query attribute label lists.
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelRequest"/></param>
        /// <returns><see cref="ListAttributeLabelResponse"/></returns>
        public Task<ListAttributeLabelResponse> ListAttributeLabel(ListAttributeLabelRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelResponse>(req, "ListAttributeLabel");
        }

        /// <summary>
        /// This API is used to query attribute label lists.
        /// </summary>
        /// <param name="req"><see cref="ListAttributeLabelRequest"/></param>
        /// <returns><see cref="ListAttributeLabelResponse"/></returns>
        public ListAttributeLabelResponse ListAttributeLabelSync(ListAttributeLabelRequest req)
        {
            return InternalRequestAsync<ListAttributeLabelResponse>(req, "ListAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get document list.
        /// </summary>
        /// <param name="req"><see cref="ListDocRequest"/></param>
        /// <returns><see cref="ListDocResponse"/></returns>
        public Task<ListDocResponse> ListDoc(ListDocRequest req)
        {
            return InternalRequestAsync<ListDocResponse>(req, "ListDoc");
        }

        /// <summary>
        /// This API is used to get document list.
        /// </summary>
        /// <param name="req"><see cref="ListDocRequest"/></param>
        /// <returns><see cref="ListDocResponse"/></returns>
        public ListDocResponse ListDocSync(ListDocRequest req)
        {
            return InternalRequestAsync<ListDocResponse>(req, "ListDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get document category.
        /// </summary>
        /// <param name="req"><see cref="ListDocCateRequest"/></param>
        /// <returns><see cref="ListDocCateResponse"/></returns>
        public Task<ListDocCateResponse> ListDocCate(ListDocCateRequest req)
        {
            return InternalRequestAsync<ListDocCateResponse>(req, "ListDocCate");
        }

        /// <summary>
        /// This API is used to get document category.
        /// </summary>
        /// <param name="req"><see cref="ListDocCateRequest"/></param>
        /// <returns><see cref="ListDocCateResponse"/></returns>
        public ListDocCateResponse ListDocCateSync(ListDocCateRequest req)
        {
            return InternalRequestAsync<ListDocCateResponse>(req, "ListDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the model list.
        /// </summary>
        /// <param name="req"><see cref="ListModelRequest"/></param>
        /// <returns><see cref="ListModelResponse"/></returns>
        public Task<ListModelResponse> ListModel(ListModelRequest req)
        {
            return InternalRequestAsync<ListModelResponse>(req, "ListModel");
        }

        /// <summary>
        /// This API is used to get the model list.
        /// </summary>
        /// <param name="req"><see cref="ListModelRequest"/></param>
        /// <returns><see cref="ListModelResponse"/></returns>
        public ListModelResponse ListModelSync(ListModelRequest req)
        {
            return InternalRequestAsync<ListModelResponse>(req, "ListModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query Q&A lists.
        /// </summary>
        /// <param name="req"><see cref="ListQARequest"/></param>
        /// <returns><see cref="ListQAResponse"/></returns>
        public Task<ListQAResponse> ListQA(ListQARequest req)
        {
            return InternalRequestAsync<ListQAResponse>(req, "ListQA");
        }

        /// <summary>
        /// This API is used to query Q&A lists.
        /// </summary>
        /// <param name="req"><see cref="ListQARequest"/></param>
        /// <returns><see cref="ListQAResponse"/></returns>
        public ListQAResponse ListQASync(ListQARequest req)
        {
            return InternalRequestAsync<ListQAResponse>(req, "ListQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="ListQACateRequest"/></param>
        /// <returns><see cref="ListQACateResponse"/></returns>
        public Task<ListQACateResponse> ListQACate(ListQACateRequest req)
        {
            return InternalRequestAsync<ListQACateResponse>(req, "ListQACate");
        }

        /// <summary>
        /// This API is used to get Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="ListQACateRequest"/></param>
        /// <returns><see cref="ListQACateResponse"/></returns>
        public ListQACateResponse ListQACateSync(ListQACateRequest req)
        {
            return InternalRequestAsync<ListQACateResponse>(req, "ListQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionResponse"/></returns>
        public Task<ListRejectedQuestionResponse> ListRejectedQuestion(ListRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionResponse>(req, "ListRejectedQuestion");
        }

        /// <summary>
        /// This API is used to get rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionResponse"/></returns>
        public ListRejectedQuestionResponse ListRejectedQuestionSync(ListRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionResponse>(req, "ListRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to release a preview of rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionPreviewRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionPreviewResponse"/></returns>
        public Task<ListRejectedQuestionPreviewResponse> ListRejectedQuestionPreview(ListRejectedQuestionPreviewRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionPreviewResponse>(req, "ListRejectedQuestionPreview");
        }

        /// <summary>
        /// This API is used to release a preview of rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ListRejectedQuestionPreviewRequest"/></param>
        /// <returns><see cref="ListRejectedQuestionPreviewResponse"/></returns>
        public ListRejectedQuestionPreviewResponse ListRejectedQuestionPreviewSync(ListRejectedQuestionPreviewRequest req)
        {
            return InternalRequestAsync<ListRejectedQuestionPreviewResponse>(req, "ListRejectedQuestionPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the release list.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseRequest"/></param>
        /// <returns><see cref="ListReleaseResponse"/></returns>
        public Task<ListReleaseResponse> ListRelease(ListReleaseRequest req)
        {
            return InternalRequestAsync<ListReleaseResponse>(req, "ListRelease");
        }

        /// <summary>
        /// This API is used to get the release list.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseRequest"/></param>
        /// <returns><see cref="ListReleaseResponse"/></returns>
        public ListReleaseResponse ListReleaseSync(ListReleaseRequest req)
        {
            return InternalRequestAsync<ListReleaseResponse>(req, "ListRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview the release configuration items.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseConfigPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseConfigPreviewResponse"/></returns>
        public Task<ListReleaseConfigPreviewResponse> ListReleaseConfigPreview(ListReleaseConfigPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseConfigPreviewResponse>(req, "ListReleaseConfigPreview");
        }

        /// <summary>
        /// This API is used to preview the release configuration items.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseConfigPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseConfigPreviewResponse"/></returns>
        public ListReleaseConfigPreviewResponse ListReleaseConfigPreviewSync(ListReleaseConfigPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseConfigPreviewResponse>(req, "ListReleaseConfigPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview released documents.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseDocPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseDocPreviewResponse"/></returns>
        public Task<ListReleaseDocPreviewResponse> ListReleaseDocPreview(ListReleaseDocPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseDocPreviewResponse>(req, "ListReleaseDocPreview");
        }

        /// <summary>
        /// This API is used to preview released documents.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseDocPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseDocPreviewResponse"/></returns>
        public ListReleaseDocPreviewResponse ListReleaseDocPreviewSync(ListReleaseDocPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseDocPreviewResponse>(req, "ListReleaseDocPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List of documents.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseQAPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseQAPreviewResponse"/></returns>
        public Task<ListReleaseQAPreviewResponse> ListReleaseQAPreview(ListReleaseQAPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseQAPreviewResponse>(req, "ListReleaseQAPreview");
        }

        /// <summary>
        /// List of documents.
        /// </summary>
        /// <param name="req"><see cref="ListReleaseQAPreviewRequest"/></param>
        /// <returns><see cref="ListReleaseQAPreviewResponse"/></returns>
        public ListReleaseQAPreviewResponse ListReleaseQAPreviewSync(ListReleaseQAPreviewRequest req)
        {
            return InternalRequestAsync<ListReleaseQAPreviewResponse>(req, "ListReleaseQAPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get account information.
        /// </summary>
        /// <param name="req"><see cref="ListSelectDocRequest"/></param>
        /// <returns><see cref="ListSelectDocResponse"/></returns>
        public Task<ListSelectDocResponse> ListSelectDoc(ListSelectDocRequest req)
        {
            return InternalRequestAsync<ListSelectDocResponse>(req, "ListSelectDoc");
        }

        /// <summary>
        /// This API is used to get account information.
        /// </summary>
        /// <param name="req"><see cref="ListSelectDocRequest"/></param>
        /// <returns><see cref="ListSelectDocResponse"/></returns>
        public ListSelectDocResponse ListSelectDocSync(ListSelectDocRequest req)
        {
            return InternalRequestAsync<ListSelectDocResponse>(req, "ListSelectDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a list of dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="ListUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ListUnsatisfiedReplyResponse"/></returns>
        public Task<ListUnsatisfiedReplyResponse> ListUnsatisfiedReply(ListUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ListUnsatisfiedReplyResponse>(req, "ListUnsatisfiedReply");
        }

        /// <summary>
        /// This API is used to query a list of dissatisfied responses.
        /// </summary>
        /// <param name="req"><see cref="ListUnsatisfiedReplyRequest"/></param>
        /// <returns><see cref="ListUnsatisfiedReplyResponse"/></returns>
        public ListUnsatisfiedReplyResponse ListUnsatisfiedReplySync(ListUnsatisfiedReplyRequest req)
        {
            return InternalRequestAsync<ListUnsatisfiedReplyResponse>(req, "ListUnsatisfiedReply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query single call details in a list.
        /// </summary>
        /// <param name="req"><see cref="ListUsageCallDetailRequest"/></param>
        /// <returns><see cref="ListUsageCallDetailResponse"/></returns>
        public Task<ListUsageCallDetailResponse> ListUsageCallDetail(ListUsageCallDetailRequest req)
        {
            return InternalRequestAsync<ListUsageCallDetailResponse>(req, "ListUsageCallDetail");
        }

        /// <summary>
        /// This API is used to query single call details in a list.
        /// </summary>
        /// <param name="req"><see cref="ListUsageCallDetailRequest"/></param>
        /// <returns><see cref="ListUsageCallDetailResponse"/></returns>
        public ListUsageCallDetailResponse ListUsageCallDetailSync(ListUsageCallDetailRequest req)
        {
            return InternalRequestAsync<ListUsageCallDetailResponse>(req, "ListUsageCallDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify application request structure.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// This API is used to modify application request structure.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit attribute labels.
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public Task<ModifyAttributeLabelResponse> ModifyAttributeLabel(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel");
        }

        /// <summary>
        /// This API is used to edit attribute labels.
        /// </summary>
        /// <param name="req"><see cref="ModifyAttributeLabelRequest"/></param>
        /// <returns><see cref="ModifyAttributeLabelResponse"/></returns>
        public ModifyAttributeLabelResponse ModifyAttributeLabelSync(ModifyAttributeLabelRequest req)
        {
            return InternalRequestAsync<ModifyAttributeLabelResponse>(req, "ModifyAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify documents.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocRequest"/></param>
        /// <returns><see cref="ModifyDocResponse"/></returns>
        public Task<ModifyDocResponse> ModifyDoc(ModifyDocRequest req)
        {
            return InternalRequestAsync<ModifyDocResponse>(req, "ModifyDoc");
        }

        /// <summary>
        /// This API is used to modify documents.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocRequest"/></param>
        /// <returns><see cref="ModifyDocResponse"/></returns>
        public ModifyDocResponse ModifyDocSync(ModifyDocRequest req)
        {
            return InternalRequestAsync<ModifyDocResponse>(req, "ModifyDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify applicable scope of the document in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyDocAttrRangeResponse"/></returns>
        public Task<ModifyDocAttrRangeResponse> ModifyDocAttrRange(ModifyDocAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyDocAttrRangeResponse>(req, "ModifyDocAttrRange");
        }

        /// <summary>
        /// This API is used to modify applicable scope of the document in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyDocAttrRangeResponse"/></returns>
        public ModifyDocAttrRangeResponse ModifyDocAttrRangeSync(ModifyDocAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyDocAttrRangeResponse>(req, "ModifyDocAttrRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Doc categories.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocCateRequest"/></param>
        /// <returns><see cref="ModifyDocCateResponse"/></returns>
        public Task<ModifyDocCateResponse> ModifyDocCate(ModifyDocCateRequest req)
        {
            return InternalRequestAsync<ModifyDocCateResponse>(req, "ModifyDocCate");
        }

        /// <summary>
        /// This API is used to modify Doc categories.
        /// </summary>
        /// <param name="req"><see cref="ModifyDocCateRequest"/></param>
        /// <returns><see cref="ModifyDocCateResponse"/></returns>
        public ModifyDocCateResponse ModifyDocCateSync(ModifyDocCateRequest req)
        {
            return InternalRequestAsync<ModifyDocCateResponse>(req, "ModifyDocCate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update Q&As.
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public Task<ModifyQAResponse> ModifyQA(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA");
        }

        /// <summary>
        /// This API is used to update Q&As.
        /// </summary>
        /// <param name="req"><see cref="ModifyQARequest"/></param>
        /// <returns><see cref="ModifyQAResponse"/></returns>
        public ModifyQAResponse ModifyQASync(ModifyQARequest req)
        {
            return InternalRequestAsync<ModifyQAResponse>(req, "ModifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Q&A applicable scope in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyQAAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyQAAttrRangeResponse"/></returns>
        public Task<ModifyQAAttrRangeResponse> ModifyQAAttrRange(ModifyQAAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyQAAttrRangeResponse>(req, "ModifyQAAttrRange");
        }

        /// <summary>
        /// This API is used to modify Q&A applicable scope in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifyQAAttrRangeRequest"/></param>
        /// <returns><see cref="ModifyQAAttrRangeResponse"/></returns>
        public ModifyQAAttrRangeResponse ModifyQAAttrRangeSync(ModifyQAAttrRangeRequest req)
        {
            return InternalRequestAsync<ModifyQAAttrRangeResponse>(req, "ModifyQAAttrRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="ModifyQACateRequest"/></param>
        /// <returns><see cref="ModifyQACateResponse"/></returns>
        public Task<ModifyQACateResponse> ModifyQACate(ModifyQACateRequest req)
        {
            return InternalRequestAsync<ModifyQACateResponse>(req, "ModifyQACate");
        }

        /// <summary>
        /// This API is used to modify Q&A categories.
        /// </summary>
        /// <param name="req"><see cref="ModifyQACateRequest"/></param>
        /// <returns><see cref="ModifyQACateResponse"/></returns>
        public ModifyQACateResponse ModifyQACateSync(ModifyQACateRequest req)
        {
            return InternalRequestAsync<ModifyQACateResponse>(req, "ModifyQACate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ModifyRejectedQuestionRequest"/></param>
        /// <returns><see cref="ModifyRejectedQuestionResponse"/></returns>
        public Task<ModifyRejectedQuestionResponse> ModifyRejectedQuestion(ModifyRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ModifyRejectedQuestionResponse>(req, "ModifyRejectedQuestion");
        }

        /// <summary>
        /// This API is used to modify rejected questions.
        /// </summary>
        /// <param name="req"><see cref="ModifyRejectedQuestionRequest"/></param>
        /// <returns><see cref="ModifyRejectedQuestionResponse"/></returns>
        public ModifyRejectedQuestionResponse ModifyRejectedQuestionSync(ModifyRejectedQuestionRequest req)
        {
            return InternalRequestAsync<ModifyRejectedQuestionResponse>(req, "ModifyRejectedQuestion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to show messages for likes and dislikes.
        /// </summary>
        /// <param name="req"><see cref="RateMsgRecordRequest"/></param>
        /// <returns><see cref="RateMsgRecordResponse"/></returns>
        public Task<RateMsgRecordResponse> RateMsgRecord(RateMsgRecordRequest req)
        {
            return InternalRequestAsync<RateMsgRecordResponse>(req, "RateMsgRecord");
        }

        /// <summary>
        /// This API is used to show messages for likes and dislikes.
        /// </summary>
        /// <param name="req"><see cref="RateMsgRecordRequest"/></param>
        /// <returns><see cref="RateMsgRecordResponse"/></returns>
        public RateMsgRecordResponse RateMsgRecordSync(RateMsgRecordRequest req)
        {
            return InternalRequestAsync<RateMsgRecordResponse>(req, "RateMsgRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to rename a document.
        /// </summary>
        /// <param name="req"><see cref="RenameDocRequest"/></param>
        /// <returns><see cref="RenameDocResponse"/></returns>
        public Task<RenameDocResponse> RenameDoc(RenameDocRequest req)
        {
            return InternalRequestAsync<RenameDocResponse>(req, "RenameDoc");
        }

        /// <summary>
        /// This API is used to rename a document.
        /// </summary>
        /// <param name="req"><see cref="RenameDocRequest"/></param>
        /// <returns><see cref="RenameDocResponse"/></returns>
        public RenameDocResponse RenameDocSync(RenameDocRequest req)
        {
            return InternalRequestAsync<RenameDocResponse>(req, "RenameDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry document parsing.
        /// </summary>
        /// <param name="req"><see cref="RetryDocAuditRequest"/></param>
        /// <returns><see cref="RetryDocAuditResponse"/></returns>
        public Task<RetryDocAuditResponse> RetryDocAudit(RetryDocAuditRequest req)
        {
            return InternalRequestAsync<RetryDocAuditResponse>(req, "RetryDocAudit");
        }

        /// <summary>
        /// This API is used to retry document parsing.
        /// </summary>
        /// <param name="req"><see cref="RetryDocAuditRequest"/></param>
        /// <returns><see cref="RetryDocAuditResponse"/></returns>
        public RetryDocAuditResponse RetryDocAuditSync(RetryDocAuditRequest req)
        {
            return InternalRequestAsync<RetryDocAuditResponse>(req, "RetryDocAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry document parsing.
        /// </summary>
        /// <param name="req"><see cref="RetryDocParseRequest"/></param>
        /// <returns><see cref="RetryDocParseResponse"/></returns>
        public Task<RetryDocParseResponse> RetryDocParse(RetryDocParseRequest req)
        {
            return InternalRequestAsync<RetryDocParseResponse>(req, "RetryDocParse");
        }

        /// <summary>
        /// This API is used to retry document parsing.
        /// </summary>
        /// <param name="req"><see cref="RetryDocParseRequest"/></param>
        /// <returns><see cref="RetryDocParseResponse"/></returns>
        public RetryDocParseResponse RetryDocParseSync(RetryDocParseRequest req)
        {
            return InternalRequestAsync<RetryDocParseResponse>(req, "RetryDocParse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry after release suspension.
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public Task<RetryReleaseResponse> RetryRelease(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease");
        }

        /// <summary>
        /// This API is used to retry after release suspension.
        /// </summary>
        /// <param name="req"><see cref="RetryReleaseRequest"/></param>
        /// <returns><see cref="RetryReleaseResponse"/></returns>
        public RetryReleaseResponse RetryReleaseSync(RetryReleaseRequest req)
        {
            return InternalRequestAsync<RetryReleaseResponse>(req, "RetryRelease")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to save a knowledge base document Q&As.
        /// Three steps to store a file in the knowledge library of the application: 
        /// 1. Obtain a temporary key. For more information, see [API Documentation](https://cloud.tencent.com/document/product/1759/105050). Different parameter combinations of the temporary key have different permissions. For more information, see [Tencent Cloud Agent Development Platform/TCADP COS Guide](https://cloud.tencent.com/document/product/1759/116238). 
        /// 2. Call the COS storage API provided by Tencent Cloud to store the file in the COS of TCADP. For details, see [COS SDK Overview](https://cloud.tencent.com/document/product/436/6474). Note that the temporary key method is used to operate COS. 
        /// 3. Call this API to store the basic information of the file in TCADP. 
        /// For the above steps, see [Documentation](https://cloud.tencent.com/document/product/1759/108903). At the end of the documentation, there is a [code demo](https://cloud.tencent.com/document/product/1759/108903#demo), which can be used as a reference.
        /// </summary>
        /// <param name="req"><see cref="SaveDocRequest"/></param>
        /// <returns><see cref="SaveDocResponse"/></returns>
        public Task<SaveDocResponse> SaveDoc(SaveDocRequest req)
        {
            return InternalRequestAsync<SaveDocResponse>(req, "SaveDoc");
        }

        /// <summary>
        /// This API is used to save a knowledge base document Q&As.
        /// Three steps to store a file in the knowledge library of the application: 
        /// 1. Obtain a temporary key. For more information, see [API Documentation](https://cloud.tencent.com/document/product/1759/105050). Different parameter combinations of the temporary key have different permissions. For more information, see [Tencent Cloud Agent Development Platform/TCADP COS Guide](https://cloud.tencent.com/document/product/1759/116238). 
        /// 2. Call the COS storage API provided by Tencent Cloud to store the file in the COS of TCADP. For details, see [COS SDK Overview](https://cloud.tencent.com/document/product/436/6474). Note that the temporary key method is used to operate COS. 
        /// 3. Call this API to store the basic information of the file in TCADP. 
        /// For the above steps, see [Documentation](https://cloud.tencent.com/document/product/1759/108903). At the end of the documentation, there is a [code demo](https://cloud.tencent.com/document/product/1759/108903#demo), which can be used as a reference.
        /// </summary>
        /// <param name="req"><see cref="SaveDocRequest"/></param>
        /// <returns><see cref="SaveDocResponse"/></returns>
        public SaveDocResponse SaveDocSync(SaveDocRequest req)
        {
            return InternalRequestAsync<SaveDocResponse>(req, "SaveDoc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate document parsing.
        /// </summary>
        /// <param name="req"><see cref="StopDocParseRequest"/></param>
        /// <returns><see cref="StopDocParseResponse"/></returns>
        public Task<StopDocParseResponse> StopDocParse(StopDocParseRequest req)
        {
            return InternalRequestAsync<StopDocParseResponse>(req, "StopDocParse");
        }

        /// <summary>
        /// This API is used to terminate document parsing.
        /// </summary>
        /// <param name="req"><see cref="StopDocParseRequest"/></param>
        /// <returns><see cref="StopDocParseResponse"/></returns>
        public StopDocParseResponse StopDocParseSync(StopDocParseRequest req)
        {
            return InternalRequestAsync<StopDocParseResponse>(req, "StopDocParse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload and import attribute labels.
        /// </summary>
        /// <param name="req"><see cref="UploadAttributeLabelRequest"/></param>
        /// <returns><see cref="UploadAttributeLabelResponse"/></returns>
        public Task<UploadAttributeLabelResponse> UploadAttributeLabel(UploadAttributeLabelRequest req)
        {
            return InternalRequestAsync<UploadAttributeLabelResponse>(req, "UploadAttributeLabel");
        }

        /// <summary>
        /// This API is used to upload and import attribute labels.
        /// </summary>
        /// <param name="req"><see cref="UploadAttributeLabelRequest"/></param>
        /// <returns><see cref="UploadAttributeLabelResponse"/></returns>
        public UploadAttributeLabelResponse UploadAttributeLabelSync(UploadAttributeLabelRequest req)
        {
            return InternalRequestAsync<UploadAttributeLabelResponse>(req, "UploadAttributeLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify Q&A.
        /// </summary>
        /// <param name="req"><see cref="VerifyQARequest"/></param>
        /// <returns><see cref="VerifyQAResponse"/></returns>
        public Task<VerifyQAResponse> VerifyQA(VerifyQARequest req)
        {
            return InternalRequestAsync<VerifyQAResponse>(req, "VerifyQA");
        }

        /// <summary>
        /// This API is used to verify Q&A.
        /// </summary>
        /// <param name="req"><see cref="VerifyQARequest"/></param>
        /// <returns><see cref="VerifyQAResponse"/></returns>
        public VerifyQAResponse VerifyQASync(VerifyQARequest req)
        {
            return InternalRequestAsync<VerifyQAResponse>(req, "VerifyQA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
