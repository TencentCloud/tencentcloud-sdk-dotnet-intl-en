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

       private const string endpoint = "billing.tencentcloudapi.com";
       private const string version = "2018-07-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BillingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to batch set cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public async Task<CreateAllocationTagResponse> CreateAllocationTag(CreateAllocationTagRequest req)
        {
             JsonResponseModel<CreateAllocationTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAllocationTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAllocationTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch set cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="CreateAllocationTagRequest"/></param>
        /// <returns><see cref="CreateAllocationTagResponse"/></returns>
        public CreateAllocationTagResponse CreateAllocationTagSync(CreateAllocationTagRequest req)
        {
             JsonResponseModel<CreateAllocationTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAllocationTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAllocationTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to batch cancel cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public async Task<DeleteAllocationTagResponse> DeleteAllocationTag(DeleteAllocationTagRequest req)
        {
             JsonResponseModel<DeleteAllocationTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllocationTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllocationTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to batch cancel cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DeleteAllocationTagRequest"/></param>
        /// <returns><see cref="DeleteAllocationTagResponse"/></returns>
        public DeleteAllocationTagResponse DeleteAllocationTagSync(DeleteAllocationTagRequest req)
        {
             JsonResponseModel<DeleteAllocationTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllocationTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllocationTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check the Tencent Cloud account balance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public async Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check the Tencent Cloud account balance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to get bill details.
        /// Note:
        /// 1. The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// 2.If the volume of your bill data is high (for example, if over 200 thousand bill entries are generated for a month), bill data query via APIs may be slow. We recommend you enable bill storage so that you can obtain bill files from COS buckets for analysis. For details, see [Saving Bills to COS](https://intl.cloud.tencent.com/document/product/555/61275?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public async Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
             JsonResponseModel<DescribeBillDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeBillDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bill details).
        /// Note: The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public async Task<DescribeBillDetailForOrganizationResponse> DescribeBillDetailForOrganization(DescribeBillDetailForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillDetailForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillDetailForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bill details).
        /// Note: The API request may fail due to network instability or other exceptions. In this case, we recommend you manually retry the request when the API request fails.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillDetailForOrganizationResponse"/></returns>
        public DescribeBillDetailForOrganizationResponse DescribeBillDetailForOrganizationSync(DescribeBillDetailForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillDetailForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillDetailForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bill download URLs for L0, L1, L2, and L3 bills and bill packs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public async Task<DescribeBillDownloadUrlResponse> DescribeBillDownloadUrl(DescribeBillDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bill download URLs for L0, L1, L2, and L3 bills and bill packs.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeBillDownloadUrlResponse"/></returns>
        public DescribeBillDownloadUrlResponse DescribeBillDownloadUrlSync(DescribeBillDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bill summarized by instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public async Task<DescribeBillResourceSummaryResponse> DescribeBillResourceSummary(DescribeBillResourceSummaryRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillResourceSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bill summarized by instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public DescribeBillResourceSummaryResponse DescribeBillResourceSummarySync(DescribeBillResourceSummaryRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillResourceSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bills by instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public async Task<DescribeBillResourceSummaryForOrganizationResponse> DescribeBillResourceSummaryForOrganization(DescribeBillResourceSummaryForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillResourceSummaryForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get pay-on-behalf bills of the admin account (bills by instance).
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryForOrganizationResponse"/></returns>
        public DescribeBillResourceSummaryForOrganizationResponse DescribeBillResourceSummaryForOrganizationSync(DescribeBillResourceSummaryForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillResourceSummaryForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bill details by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public async Task<DescribeBillSummaryResponse> DescribeBillSummary(DescribeBillSummaryRequest req)
        {
             JsonResponseModel<DescribeBillSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bill details by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryResponse"/></returns>
        public DescribeBillSummaryResponse DescribeBillSummarySync(DescribeBillSummaryRequest req)
        {
             JsonResponseModel<DescribeBillSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bill summarized by billing mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public async Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByPayModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the bill summarized by billing mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public DescribeBillSummaryByPayModeResponse DescribeBillSummaryByPayModeSync(DescribeBillSummaryByPayModeRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByPayModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to product
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public async Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to product
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public DescribeBillSummaryByProductResponse DescribeBillSummaryByProductSync(DescribeBillSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to project
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public async Task<DescribeBillSummaryByProjectResponse> DescribeBillSummaryByProject(DescribeBillSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to project
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public DescribeBillSummaryByProjectResponse DescribeBillSummaryByProjectSync(DescribeBillSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to region
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public async Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Gets the bill summarized according to region
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public DescribeBillSummaryByRegionResponse DescribeBillSummaryByRegionSync(DescribeBillSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the cost distribution over different tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public async Task<DescribeBillSummaryByTagResponse> DescribeBillSummaryByTag(DescribeBillSummaryByTagRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the cost distribution over different tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public DescribeBillSummaryByTagResponse DescribeBillSummaryByTagSync(DescribeBillSummaryByTagRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bills summarized by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public async Task<DescribeBillSummaryForOrganizationResponse> DescribeBillSummaryForOrganization(DescribeBillSummaryForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillSummaryForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get bills summarized by product, project, region, billing mode, and tag by passing in parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryForOrganizationRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryForOrganizationResponse"/></returns>
        public DescribeBillSummaryForOrganizationResponse DescribeBillSummaryForOrganizationSync(DescribeBillSummaryForOrganizationRequest req)
        {
             JsonResponseModel<DescribeBillSummaryForOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryForOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryForOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query COS usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public async Task<DescribeDosageCosDetailByDateResponse> DescribeDosageCosDetailByDate(DescribeDosageCosDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageCosDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDosageCosDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageCosDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query COS usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public DescribeDosageCosDetailByDateResponse DescribeDosageCosDetailByDateSync(DescribeDosageCosDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageCosDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDosageCosDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageCosDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public async Task<DescribeTagListResponse> DescribeTagList(DescribeTagListRequest req)
        {
             JsonResponseModel<DescribeTagListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get cost allocation tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagListRequest"/></param>
        /// <returns><see cref="DescribeTagListResponse"/></returns>
        public DescribeTagListResponse DescribeTagListSync(DescribeTagListRequest req)
        {
             JsonResponseModel<DescribeTagListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query vouchers.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public async Task<DescribeVoucherInfoResponse> DescribeVoucherInfo(DescribeVoucherInfoRequest req)
        {
             JsonResponseModel<DescribeVoucherInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVoucherInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query vouchers.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public DescribeVoucherInfoResponse DescribeVoucherInfoSync(DescribeVoucherInfoRequest req)
        {
             JsonResponseModel<DescribeVoucherInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVoucherInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query voucher usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public async Task<DescribeVoucherUsageDetailsResponse> DescribeVoucherUsageDetails(DescribeVoucherUsageDetailsRequest req)
        {
             JsonResponseModel<DescribeVoucherUsageDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVoucherUsageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherUsageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query voucher usage details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public DescribeVoucherUsageDetailsResponse DescribeVoucherUsageDetailsSync(DescribeVoucherUsageDetailsRequest req)
        {
             JsonResponseModel<DescribeVoucherUsageDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVoucherUsageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherUsageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
