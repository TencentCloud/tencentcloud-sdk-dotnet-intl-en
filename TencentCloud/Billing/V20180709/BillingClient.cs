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
        /// This API is used to query bill details.
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
        /// This API is used to query bill details.
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
        /// This API is used to query bill resources summary. 
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
        /// This API is used to query bill resources summary. 
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
        /// Gets the bill summarized according to billing mode
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
        /// Gets the bill summarized according to billing mode
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
