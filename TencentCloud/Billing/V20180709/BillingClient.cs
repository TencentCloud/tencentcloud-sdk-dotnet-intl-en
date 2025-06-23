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

namespace TencentCloud.Billing.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Billing.V20180709.Models;

   public class BillingClient : AbstractClient{

       private const string endpoint = "billing.intl.tencentcloudapi.com";
       private const string version = "2018-07-09";
       private const string sdkVersion = "SDK_NET_3.0.1157";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BillingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BillingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Create a sharing rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationRuleRequest"/></param>
        /// <returns><see cref="CreateAllocationRuleResponse"/></returns>
        public Task<CreateAllocationRuleResponse> CreateAllocationRule(CreateAllocationRuleRequest req)
        {
            return InternalRequestAsync<CreateAllocationRuleResponse>(req, "CreateAllocationRule");
        }

        /// <summary>
        /// Create a sharing rule.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationRuleRequest"/></param>
        /// <returns><see cref="CreateAllocationRuleResponse"/></returns>
        public CreateAllocationRuleResponse CreateAllocationRuleSync(CreateAllocationRuleRequest req)
        {
            return InternalRequestAsync<CreateAllocationRuleResponse>(req, "CreateAllocationRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch set cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public Task<CreateAllocationTagResponse> CreateAllocationTag(CreateAllocationTagRequest req)
        {
            return InternalRequestAsync<CreateAllocationTagResponse>(req, "CreateAllocationTag");
        }

        /// <summary>
        /// This API is used to batch set cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public CreateAllocationTagResponse CreateAllocationTagSync(CreateAllocationTagRequest req)
        {
            return InternalRequestAsync<CreateAllocationTagResponse>(req, "CreateAllocationTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create allocation units.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationUnitRequest"/></param>
        /// <returns><see cref="CreateAllocationUnitResponse"/></returns>
        public Task<CreateAllocationUnitResponse> CreateAllocationUnit(CreateAllocationUnitRequest req)
        {
            return InternalRequestAsync<CreateAllocationUnitResponse>(req, "CreateAllocationUnit");
        }

        /// <summary>
        /// This API is used to create allocation units.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationUnitRequest"/></param>
        /// <returns><see cref="CreateAllocationUnitResponse"/></returns>
        public CreateAllocationUnitResponse CreateAllocationUnitSync(CreateAllocationUnitRequest req)
        {
            return InternalRequestAsync<CreateAllocationUnitResponse>(req, "CreateAllocationUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a collection rule.
        /// </summary>
        /// <param name="req"><see cref="CreateGatherRuleRequest"/></param>
        /// <returns><see cref="CreateGatherRuleResponse"/></returns>
        public Task<CreateGatherRuleResponse> CreateGatherRule(CreateGatherRuleRequest req)
        {
            return InternalRequestAsync<CreateGatherRuleResponse>(req, "CreateGatherRule");
        }

        /// <summary>
        /// Create a collection rule.
        /// </summary>
        /// <param name="req"><see cref="CreateGatherRuleRequest"/></param>
        /// <returns><see cref="CreateGatherRuleResponse"/></returns>
        public CreateGatherRuleResponse CreateGatherRuleSync(CreateGatherRuleRequest req)
        {
            return InternalRequestAsync<CreateGatherRuleResponse>(req, "CreateGatherRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete sharing rule interface.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationRuleRequest"/></param>
        /// <returns><see cref="DeleteAllocationRuleResponse"/></returns>
        public Task<DeleteAllocationRuleResponse> DeleteAllocationRule(DeleteAllocationRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllocationRuleResponse>(req, "DeleteAllocationRule");
        }

        /// <summary>
        /// Delete sharing rule interface.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationRuleRequest"/></param>
        /// <returns><see cref="DeleteAllocationRuleResponse"/></returns>
        public DeleteAllocationRuleResponse DeleteAllocationRuleSync(DeleteAllocationRuleRequest req)
        {
            return InternalRequestAsync<DeleteAllocationRuleResponse>(req, "DeleteAllocationRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to batch cancel cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public Task<DeleteAllocationTagResponse> DeleteAllocationTag(DeleteAllocationTagRequest req)
        {
            return InternalRequestAsync<DeleteAllocationTagResponse>(req, "DeleteAllocationTag");
        }

        /// <summary>
        /// u200cThis API is used to batch cancel cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public DeleteAllocationTagResponse DeleteAllocationTagSync(DeleteAllocationTagRequest req)
        {
            return InternalRequestAsync<DeleteAllocationTagResponse>(req, "DeleteAllocationTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a cost allocation unit.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationUnitRequest"/></param>
        /// <returns><see cref="DeleteAllocationUnitResponse"/></returns>
        public Task<DeleteAllocationUnitResponse> DeleteAllocationUnit(DeleteAllocationUnitRequest req)
        {
            return InternalRequestAsync<DeleteAllocationUnitResponse>(req, "DeleteAllocationUnit");
        }

        /// <summary>
        /// Delete a cost allocation unit.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationUnitRequest"/></param>
        /// <returns><see cref="DeleteAllocationUnitResponse"/></returns>
        public DeleteAllocationUnitResponse DeleteAllocationUnitSync(DeleteAllocationUnitRequest req)
        {
            return InternalRequestAsync<DeleteAllocationUnitResponse>(req, "DeleteAllocationUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a collection rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteGatherRuleRequest"/></param>
        /// <returns><see cref="DeleteGatherRuleResponse"/></returns>
        public Task<DeleteGatherRuleResponse> DeleteGatherRule(DeleteGatherRuleRequest req)
        {
            return InternalRequestAsync<DeleteGatherRuleResponse>(req, "DeleteGatherRule");
        }

        /// <summary>
        /// Delete a collection rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteGatherRuleRequest"/></param>
        /// <returns><see cref="DeleteGatherRuleResponse"/></returns>
        public DeleteGatherRuleResponse DeleteGatherRuleSync(DeleteGatherRuleRequest req)
        {
            return InternalRequestAsync<DeleteGatherRuleResponse>(req, "DeleteGatherRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check the Tencent Cloud account balance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance");
        }

        /// <summary>
        /// This API is used to check the Tencent Cloud account balance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
            return InternalRequestAsync<DescribeAccountBalanceResponse>(req, "DescribeAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query sharing rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationRuleDetailResponse"/></returns>
        public Task<DescribeAllocationRuleDetailResponse> DescribeAllocationRuleDetail(DescribeAllocationRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationRuleDetailResponse>(req, "DescribeAllocationRuleDetail");
        }

        /// <summary>
        /// This API is used to query sharing rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationRuleDetailResponse"/></returns>
        public DescribeAllocationRuleDetailResponse DescribeAllocationRuleDetailSync(DescribeAllocationRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationRuleDetailResponse>(req, "DescribeAllocationRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query all sharing rule overviews.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationRuleSummaryRequest"/></param>
        /// <returns><see cref="DescribeAllocationRuleSummaryResponse"/></returns>
        public Task<DescribeAllocationRuleSummaryResponse> DescribeAllocationRuleSummary(DescribeAllocationRuleSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAllocationRuleSummaryResponse>(req, "DescribeAllocationRuleSummary");
        }

        /// <summary>
        /// This API is used to query all sharing rule overviews.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationRuleSummaryRequest"/></param>
        /// <returns><see cref="DescribeAllocationRuleSummaryResponse"/></returns>
        public DescribeAllocationRuleSummaryResponse DescribeAllocationRuleSummarySync(DescribeAllocationRuleSummaryRequest req)
        {
            return InternalRequestAsync<DescribeAllocationRuleSummaryResponse>(req, "DescribeAllocationRuleSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cost tree.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationTreeRequest"/></param>
        /// <returns><see cref="DescribeAllocationTreeResponse"/></returns>
        public Task<DescribeAllocationTreeResponse> DescribeAllocationTree(DescribeAllocationTreeRequest req)
        {
            return InternalRequestAsync<DescribeAllocationTreeResponse>(req, "DescribeAllocationTree");
        }

        /// <summary>
        /// This API is used to query the cost tree.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationTreeRequest"/></param>
        /// <returns><see cref="DescribeAllocationTreeResponse"/></returns>
        public DescribeAllocationTreeResponse DescribeAllocationTreeSync(DescribeAllocationTreeRequest req)
        {
            return InternalRequestAsync<DescribeAllocationTreeResponse>(req, "DescribeAllocationTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query the details of a cost allocation unit.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationUnitDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationUnitDetailResponse"/></returns>
        public Task<DescribeAllocationUnitDetailResponse> DescribeAllocationUnitDetail(DescribeAllocationUnitDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationUnitDetailResponse>(req, "DescribeAllocationUnitDetail");
        }

        /// <summary>
        /// Query the details of a cost allocation unit.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllocationUnitDetailRequest"/></param>
        /// <returns><see cref="DescribeAllocationUnitDetailResponse"/></returns>
        public DescribeAllocationUnitDetailResponse DescribeAllocationUnitDetailSync(DescribeAllocationUnitDetailRequest req)
        {
            return InternalRequestAsync<DescribeAllocationUnitDetailResponse>(req, "DescribeAllocationUnitDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to check whether the current UIN has any adjustment, enabling customers to proactively obtain the adjustment status faster.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillAdjustInfoRequest"/></param>
        /// <returns><see cref="DescribeBillAdjustInfoResponse"/></returns>
        public Task<DescribeBillAdjustInfoResponse> DescribeBillAdjustInfo(DescribeBillAdjustInfoRequest req)
        {
            return InternalRequestAsync<DescribeBillAdjustInfoResponse>(req, "DescribeBillAdjustInfo");
        }

        /// <summary>
        /// This API is used to check whether the current UIN has any adjustment, enabling customers to proactively obtain the adjustment status faster.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillAdjustInfoRequest"/></param>
        /// <returns><see cref="DescribeBillAdjustInfoResponse"/></returns>
        public DescribeBillAdjustInfoResponse DescribeBillAdjustInfoSync(DescribeBillAdjustInfoRequest req)
        {
            return InternalRequestAsync<DescribeBillAdjustInfoResponse>(req, "DescribeBillAdjustInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to get bill details.
        /// Note:
        /// 1. The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// 2.If the volume of your bill data is high (for example, if over 200 thousand bill entries are generated for a month), bill data query via APIs may be slow. We recommend you enable bill storage so that you can obtain bill files from COS buckets for analysis. For details, see [Saving Bills to COS](https://intl.cloud.tencent.com/document/product/555/61275?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail");
        }

        /// <summary>
        /// u200cThis API is used to get bill details.
        /// Note:
        /// 1. The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// 2.If the volume of your bill data is high (for example, if over 200 thousand bill entries are generated for a month), bill data query via APIs may be slow. We recommend you enable bill storage so that you can obtain bill files from COS buckets for analysis. For details, see [Saving Bills to COS](https://intl.cloud.tencent.com/document/product/555/61275?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public DescribeBillDetailResponse DescribeBillDetailSync(DescribeBillDetailRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailResponse>(req, "DescribeBillDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bill details).
        /// Note: The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public Task<DescribeBillDetailForOrganizationResponse> DescribeBillDetailForOrganization(DescribeBillDetailForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailForOrganizationResponse>(req, "DescribeBillDetailForOrganization");
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bill details).
        /// Note: The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public DescribeBillDetailForOrganizationResponse DescribeBillDetailForOrganizationSync(DescribeBillDetailForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillDetailForOrganizationResponse>(req, "DescribeBillDetailForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get bill download URLs for L0, L1, L2, and L3 bills and bill packs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public Task<DescribeBillDownloadUrlResponse> DescribeBillDownloadUrl(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl");
        }

        /// <summary>
        /// This API is used to get bill download URLs for L0, L1, L2, and L3 bills and bill packs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public DescribeBillDownloadUrlResponse DescribeBillDownloadUrlSync(DescribeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeBillDownloadUrlResponse>(req, "DescribeBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the bill summarized by instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public Task<DescribeBillResourceSummaryResponse> DescribeBillResourceSummary(DescribeBillResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryResponse>(req, "DescribeBillResourceSummary");
        }

        /// <summary>
        /// This API is used to get the bill summarized by instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public DescribeBillResourceSummaryResponse DescribeBillResourceSummarySync(DescribeBillResourceSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryResponse>(req, "DescribeBillResourceSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bills by instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public Task<DescribeBillResourceSummaryForOrganizationResponse> DescribeBillResourceSummaryForOrganization(DescribeBillResourceSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryForOrganizationResponse>(req, "DescribeBillResourceSummaryForOrganization");
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bills by instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public DescribeBillResourceSummaryForOrganizationResponse DescribeBillResourceSummaryForOrganizationSync(DescribeBillResourceSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillResourceSummaryForOrganizationResponse>(req, "DescribeBillResourceSummaryForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get bill details by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public Task<DescribeBillSummaryResponse> DescribeBillSummary(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary");
        }

        /// <summary>
        /// This API is used to get bill details by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public DescribeBillSummaryResponse DescribeBillSummarySync(DescribeBillSummaryRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryResponse>(req, "DescribeBillSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the bill summarized by billing mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode");
        }

        /// <summary>
        /// This API is used to get the bill summarized by billing mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public DescribeBillSummaryByPayModeResponse DescribeBillSummaryByPayModeSync(DescribeBillSummaryByPayModeRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByPayModeResponse>(req, "DescribeBillSummaryByPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the bill summarized according to product
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct");
        }

        /// <summary>
        /// Gets the bill summarized according to product
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public DescribeBillSummaryByProductResponse DescribeBillSummaryByProductSync(DescribeBillSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProductResponse>(req, "DescribeBillSummaryByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the bill summarized according to project
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public Task<DescribeBillSummaryByProjectResponse> DescribeBillSummaryByProject(DescribeBillSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProjectResponse>(req, "DescribeBillSummaryByProject");
        }

        /// <summary>
        /// Gets the bill summarized according to project
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public DescribeBillSummaryByProjectResponse DescribeBillSummaryByProjectSync(DescribeBillSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByProjectResponse>(req, "DescribeBillSummaryByProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the bill summarized according to region
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion");
        }

        /// <summary>
        /// Gets the bill summarized according to region
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public DescribeBillSummaryByRegionResponse DescribeBillSummaryByRegionSync(DescribeBillSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByRegionResponse>(req, "DescribeBillSummaryByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the cost distribution over different tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public Task<DescribeBillSummaryByTagResponse> DescribeBillSummaryByTag(DescribeBillSummaryByTagRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByTagResponse>(req, "DescribeBillSummaryByTag");
        }

        /// <summary>
        /// This API is used to get the cost distribution over different tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public DescribeBillSummaryByTagResponse DescribeBillSummaryByTagSync(DescribeBillSummaryByTagRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryByTagResponse>(req, "DescribeBillSummaryByTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get bills summarized by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public Task<DescribeBillSummaryForOrganizationResponse> DescribeBillSummaryForOrganization(DescribeBillSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryForOrganizationResponse>(req, "DescribeBillSummaryForOrganization");
        }

        /// <summary>
        /// This API is used to get bills summarized by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public DescribeBillSummaryForOrganizationResponse DescribeBillSummaryForOrganizationSync(DescribeBillSummaryForOrganizationRequest req)
        {
            return InternalRequestAsync<DescribeBillSummaryForOrganizationResponse>(req, "DescribeBillSummaryForOrganization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query consumption details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public Task<DescribeCostDetailResponse> DescribeCostDetail(DescribeCostDetailRequest req)
        {
            return InternalRequestAsync<DescribeCostDetailResponse>(req, "DescribeCostDetail");
        }

        /// <summary>
        /// This API is used to query consumption details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public DescribeCostDetailResponse DescribeCostDetailSync(DescribeCostDetailRequest req)
        {
            return InternalRequestAsync<DescribeCostDetailResponse>(req, "DescribeCostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view cost analysis details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostExplorerSummaryRequest"/></param>
        /// <returns><see cref="DescribeCostExplorerSummaryResponse"/></returns>
        public Task<DescribeCostExplorerSummaryResponse> DescribeCostExplorerSummary(DescribeCostExplorerSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCostExplorerSummaryResponse>(req, "DescribeCostExplorerSummary");
        }

        /// <summary>
        /// This API is used to view cost analysis details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostExplorerSummaryRequest"/></param>
        /// <returns><see cref="DescribeCostExplorerSummaryResponse"/></returns>
        public DescribeCostExplorerSummaryResponse DescribeCostExplorerSummarySync(DescribeCostExplorerSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCostExplorerSummaryResponse>(req, "DescribeCostExplorerSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by product.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public Task<DescribeCostSummaryByProductResponse> DescribeCostSummaryByProduct(DescribeCostSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProductResponse>(req, "DescribeCostSummaryByProduct");
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by product.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public DescribeCostSummaryByProductResponse DescribeCostSummaryByProductSync(DescribeCostSummaryByProductRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProductResponse>(req, "DescribeCostSummaryByProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by project.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public Task<DescribeCostSummaryByProjectResponse> DescribeCostSummaryByProject(DescribeCostSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProjectResponse>(req, "DescribeCostSummaryByProject");
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by project.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public DescribeCostSummaryByProjectResponse DescribeCostSummaryByProjectSync(DescribeCostSummaryByProjectRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByProjectResponse>(req, "DescribeCostSummaryByProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public Task<DescribeCostSummaryByRegionResponse> DescribeCostSummaryByRegion(DescribeCostSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByRegionResponse>(req, "DescribeCostSummaryByRegion");
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public DescribeCostSummaryByRegionResponse DescribeCostSummaryByRegionSync(DescribeCostSummaryByRegionRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByRegionResponse>(req, "DescribeCostSummaryByRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public Task<DescribeCostSummaryByResourceResponse> DescribeCostSummaryByResource(DescribeCostSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByResourceResponse>(req, "DescribeCostSummaryByResource");
        }

        /// <summary>
        /// This API is used to obtain consumption details summarized by resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public DescribeCostSummaryByResourceResponse DescribeCostSummaryByResourceSync(DescribeCostSummaryByResourceRequest req)
        {
            return InternalRequestAsync<DescribeCostSummaryByResourceResponse>(req, "DescribeCostSummaryByResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Querying orders
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public Task<DescribeDealsByCondResponse> DescribeDealsByCond(DescribeDealsByCondRequest req)
        {
            return InternalRequestAsync<DescribeDealsByCondResponse>(req, "DescribeDealsByCond");
        }

        /// <summary>
        /// Querying orders
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public DescribeDealsByCondResponse DescribeDealsByCondSync(DescribeDealsByCondRequest req)
        {
            return InternalRequestAsync<DescribeDealsByCondResponse>(req, "DescribeDealsByCond")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query COS usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public Task<DescribeDosageCosDetailByDateResponse> DescribeDosageCosDetailByDate(DescribeDosageCosDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageCosDetailByDateResponse>(req, "DescribeDosageCosDetailByDate");
        }

        /// <summary>
        /// This API is used to query COS usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public DescribeDosageCosDetailByDateResponse DescribeDosageCosDetailByDateSync(DescribeDosageCosDetailByDateRequest req)
        {
            return InternalRequestAsync<DescribeDosageCosDetailByDateResponse>(req, "DescribeDosageCosDetailByDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the collection rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatherRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeGatherRuleDetailResponse"/></returns>
        public Task<DescribeGatherRuleDetailResponse> DescribeGatherRuleDetail(DescribeGatherRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeGatherRuleDetailResponse>(req, "DescribeGatherRuleDetail");
        }

        /// <summary>
        /// This API is used to query the collection rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeGatherRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeGatherRuleDetailResponse"/></returns>
        public DescribeGatherRuleDetailResponse DescribeGatherRuleDetailSync(DescribeGatherRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeGatherRuleDetailResponse>(req, "DescribeGatherRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public Task<DescribeTagListResponse> DescribeTagList(DescribeTagListRequest req)
        {
            return InternalRequestAsync<DescribeTagListResponse>(req, "DescribeTagList");
        }

        /// <summary>
        /// This API is used to get cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public DescribeTagListResponse DescribeTagListSync(DescribeTagListRequest req)
        {
            return InternalRequestAsync<DescribeTagListResponse>(req, "DescribeTagList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query vouchers.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public Task<DescribeVoucherInfoResponse> DescribeVoucherInfo(DescribeVoucherInfoRequest req)
        {
            return InternalRequestAsync<DescribeVoucherInfoResponse>(req, "DescribeVoucherInfo");
        }

        /// <summary>
        /// This API is used to query vouchers.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public DescribeVoucherInfoResponse DescribeVoucherInfoSync(DescribeVoucherInfoRequest req)
        {
            return InternalRequestAsync<DescribeVoucherInfoResponse>(req, "DescribeVoucherInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query voucher usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public Task<DescribeVoucherUsageDetailsResponse> DescribeVoucherUsageDetails(DescribeVoucherUsageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeVoucherUsageDetailsResponse>(req, "DescribeVoucherUsageDetails");
        }

        /// <summary>
        /// This API is used to query voucher usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public DescribeVoucherUsageDetailsResponse DescribeVoucherUsageDetailsSync(DescribeVoucherUsageDetailsRequest req)
        {
            return InternalRequestAsync<DescribeVoucherUsageDetailsResponse>(req, "DescribeVoucherUsageDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit sharing rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllocationRuleRequest"/></param>
        /// <returns><see cref="ModifyAllocationRuleResponse"/></returns>
        public Task<ModifyAllocationRuleResponse> ModifyAllocationRule(ModifyAllocationRuleRequest req)
        {
            return InternalRequestAsync<ModifyAllocationRuleResponse>(req, "ModifyAllocationRule");
        }

        /// <summary>
        /// Edit sharing rules.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllocationRuleRequest"/></param>
        /// <returns><see cref="ModifyAllocationRuleResponse"/></returns>
        public ModifyAllocationRuleResponse ModifyAllocationRuleSync(ModifyAllocationRuleRequest req)
        {
            return InternalRequestAsync<ModifyAllocationRuleResponse>(req, "ModifyAllocationRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cost allocation unit information.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllocationUnitRequest"/></param>
        /// <returns><see cref="ModifyAllocationUnitResponse"/></returns>
        public Task<ModifyAllocationUnitResponse> ModifyAllocationUnit(ModifyAllocationUnitRequest req)
        {
            return InternalRequestAsync<ModifyAllocationUnitResponse>(req, "ModifyAllocationUnit");
        }

        /// <summary>
        /// This API is used to modify cost allocation unit information.
        /// </summary>
        /// <param name="req"><see cref="ModifyAllocationUnitRequest"/></param>
        /// <returns><see cref="ModifyAllocationUnitResponse"/></returns>
        public ModifyAllocationUnitResponse ModifyAllocationUnitSync(ModifyAllocationUnitRequest req)
        {
            return InternalRequestAsync<ModifyAllocationUnitResponse>(req, "ModifyAllocationUnit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Edit a collection rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatherRuleRequest"/></param>
        /// <returns><see cref="ModifyGatherRuleResponse"/></returns>
        public Task<ModifyGatherRuleResponse> ModifyGatherRule(ModifyGatherRuleRequest req)
        {
            return InternalRequestAsync<ModifyGatherRuleResponse>(req, "ModifyGatherRule");
        }

        /// <summary>
        /// Edit a collection rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyGatherRuleRequest"/></param>
        /// <returns><see cref="ModifyGatherRuleResponse"/></returns>
        public ModifyGatherRuleResponse ModifyGatherRuleSync(ModifyGatherRuleRequest req)
        {
            return InternalRequestAsync<ModifyGatherRuleResponse>(req, "ModifyGatherRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
