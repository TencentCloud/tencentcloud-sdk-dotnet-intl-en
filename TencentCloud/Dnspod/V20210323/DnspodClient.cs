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

namespace TencentCloud.Dnspod.V20210323
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dnspod.V20210323.Models;

   public class DnspodClient : AbstractClient{

       private const string endpoint = "dnspod.tencentcloudapi.com";
       private const string version = "2021-03-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DnspodClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DnspodClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add a domain.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a domain.
        /// </summary>
        /// <param name="req"><see cref="CreateDomainRequest"/></param>
        /// <returns><see cref="CreateDomainResponse"/></returns>
        public CreateDomainResponse CreateDomainSync(CreateDomainRequest req)
        {
             JsonResponseModel<CreateDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a record.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public async Task<CreateRecordResponse> CreateRecord(CreateRecordRequest req)
        {
             JsonResponseModel<CreateRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a record.
        /// </summary>
        /// <param name="req"><see cref="CreateRecordRequest"/></param>
        /// <returns><see cref="CreateRecordResponse"/></returns>
        public CreateRecordResponse CreateRecordSync(CreateRecordRequest req)
        {
             JsonResponseModel<CreateRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public async Task<DeleteDomainResponse> DeleteDomain(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a domain.
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainRequest"/></param>
        /// <returns><see cref="DeleteDomainResponse"/></returns>
        public DeleteDomainResponse DeleteDomainSync(DeleteDomainRequest req)
        {
             JsonResponseModel<DeleteDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a record.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public async Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a record.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public async Task<DescribeDomainResponse> DescribeDomain(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a domain.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainRequest"/></param>
        /// <returns><see cref="DescribeDomainResponse"/></returns>
        public DescribeDomainResponse DescribeDomainSync(DescribeDomainRequest req)
        {
             JsonResponseModel<DescribeDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a record.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public async Task<DescribeRecordResponse> DescribeRecord(DescribeRecordRequest req)
        {
             JsonResponseModel<DescribeRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a record.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordRequest"/></param>
        /// <returns><see cref="DescribeRecordResponse"/></returns>
        public DescribeRecordResponse DescribeRecordSync(DescribeRecordRequest req)
        {
             JsonResponseModel<DescribeRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the remarks of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public async Task<ModifyDomainRemarkResponse> ModifyDomainRemark(ModifyDomainRemarkRequest req)
        {
             JsonResponseModel<ModifyDomainRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the remarks of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainRemarkRequest"/></param>
        /// <returns><see cref="ModifyDomainRemarkResponse"/></returns>
        public ModifyDomainRemarkResponse ModifyDomainRemarkSync(ModifyDomainRemarkRequest req)
        {
             JsonResponseModel<ModifyDomainRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public async Task<ModifyDomainStatusResponse> ModifyDomainStatus(ModifyDomainStatusRequest req)
        {
             JsonResponseModel<ModifyDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the status of a domain.
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainStatusRequest"/></param>
        /// <returns><see cref="ModifyDomainStatusResponse"/></returns>
        public ModifyDomainStatusResponse ModifyDomainStatusSync(ModifyDomainStatusRequest req)
        {
             JsonResponseModel<ModifyDomainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public async Task<ModifyRecordResponse> ModifyRecord(ModifyRecordRequest req)
        {
             JsonResponseModel<ModifyRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a record.
        /// </summary>
        /// <param name="req"><see cref="ModifyRecordRequest"/></param>
        /// <returns><see cref="ModifyRecordResponse"/></returns>
        public ModifyRecordResponse ModifyRecordSync(ModifyRecordRequest req)
        {
             JsonResponseModel<ModifyRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
