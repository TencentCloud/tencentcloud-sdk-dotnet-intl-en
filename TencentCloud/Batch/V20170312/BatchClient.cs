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

namespace TencentCloud.Batch.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Batch.V20170312.Models;

   public class BatchClient : AbstractClient{

       private const string endpoint = "batch.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BatchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BatchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public async Task<DescribeAvailableCvmInstanceTypesResponse> DescribeAvailableCvmInstanceTypes(DescribeAvailableCvmInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableCvmInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public DescribeAvailableCvmInstanceTypesResponse DescribeAvailableCvmInstanceTypesSync(DescribeAvailableCvmInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableCvmInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public async Task<DescribeCvmZoneInstanceConfigInfosResponse> DescribeCvmZoneInstanceConfigInfos(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCvmZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public DescribeCvmZoneInstanceConfigInfosResponse DescribeCvmZoneInstanceConfigInfosSync(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCvmZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public async Task<DescribeInstanceCategoriesResponse> DescribeInstanceCategories(DescribeInstanceCategoriesRequest req)
        {
             JsonResponseModel<DescribeInstanceCategoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public DescribeInstanceCategoriesResponse DescribeInstanceCategoriesSync(DescribeInstanceCategoriesRequest req)
        {
             JsonResponseModel<DescribeInstanceCategoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
