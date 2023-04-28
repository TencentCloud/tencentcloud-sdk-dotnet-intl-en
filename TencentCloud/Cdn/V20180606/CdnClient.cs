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

namespace TencentCloud.Cdn.V20180606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdn.V20180606.Models;

   public class CdnClient : AbstractClient{

       private const string endpoint = "cdn.tencentcloudapi.com";
       private const string version = "2018-06-06";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add one or more domains to a specified log topic.
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public async Task<AddCLSTopicDomainsResponse> AddCLSTopicDomains(AddCLSTopicDomainsRequest req)
        {
             JsonResponseModel<AddCLSTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCLSTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCLSTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add one or more domains to a specified log topic.
        /// </summary>
        /// <param name="req"><see cref="AddCLSTopicDomainsRequest"/></param>
        /// <returns><see cref="AddCLSTopicDomainsResponse"/></returns>
        public AddCLSTopicDomainsResponse AddCLSTopicDomainsSync(AddCLSTopicDomainsRequest req)
        {
             JsonResponseModel<AddCLSTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCLSTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCLSTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a CDN acceleration domain name. Up to 100 domain names can be added per minute.
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public async Task<AddCdnDomainResponse> AddCdnDomain(AddCdnDomainRequest req)
        {
             JsonResponseModel<AddCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a CDN acceleration domain name. Up to 100 domain names can be added per minute.
        /// </summary>
        /// <param name="req"><see cref="AddCdnDomainRequest"/></param>
        /// <returns><see cref="AddCdnDomainResponse"/></returns>
        public AddCdnDomainResponse AddCdnDomainSync(AddCdnDomainRequest req)
        {
             JsonResponseModel<AddCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log topic. Up to 10 log topics can be created under one logset.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public async Task<CreateClsLogTopicResponse> CreateClsLogTopic(CreateClsLogTopicRequest req)
        {
             JsonResponseModel<CreateClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a log topic. Up to 10 log topics can be created under one logset.
        /// </summary>
        /// <param name="req"><see cref="CreateClsLogTopicRequest"/></param>
        /// <returns><see cref="CreateClsLogTopicResponse"/></returns>
        public CreateClsLogTopicResponse CreateClsLogTopicSync(CreateClsLogTopicRequest req)
        {
             JsonResponseModel<CreateClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public async Task<CreateScdnFailedLogTaskResponse> CreateScdnFailedLogTask(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recreate a failed event log task.
        /// </summary>
        /// <param name="req"><see cref="CreateScdnFailedLogTaskRequest"/></param>
        /// <returns><see cref="CreateScdnFailedLogTaskResponse"/></returns>
        public CreateScdnFailedLogTaskResponse CreateScdnFailedLogTaskSync(CreateScdnFailedLogTaskRequest req)
        {
             JsonResponseModel<CreateScdnFailedLogTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScdnFailedLogTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScdnFailedLogTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public async Task<DeleteCdnDomainResponse> DeleteCdnDomain(DeleteCdnDomainRequest req)
        {
             JsonResponseModel<DeleteCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteCdnDomainRequest"/></param>
        /// <returns><see cref="DeleteCdnDomainResponse"/></returns>
        public DeleteCdnDomainResponse DeleteCdnDomainSync(DeleteCdnDomainRequest req)
        {
             JsonResponseModel<DeleteCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log topic. Note: when a log topic is deleted, all logs of the domain names bound to it will no longer be published to the topic, and the logs previously published to the topic will be deleted. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public async Task<DeleteClsLogTopicResponse> DeleteClsLogTopic(DeleteClsLogTopicRequest req)
        {
             JsonResponseModel<DeleteClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a log topic. Note: when a log topic is deleted, all logs of the domain names bound to it will no longer be published to the topic, and the logs previously published to the topic will be deleted. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DeleteClsLogTopicRequest"/></param>
        /// <returns><see cref="DeleteClsLogTopicResponse"/></returns>
        public DeleteClsLogTopicResponse DeleteClsLogTopicSync(DeleteClsLogTopicRequest req)
        {
             JsonResponseModel<DeleteClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query billing data details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public async Task<DescribeBillingDataResponse> DescribeBillingData(DescribeBillingDataRequest req)
        {
             JsonResponseModel<DescribeBillingDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillingData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query billing data details.
        /// </summary>
        /// <param name="req"><see cref="DescribeBillingDataRequest"/></param>
        /// <returns><see cref="DescribeBillingDataResponse"/></returns>
        public DescribeBillingDataResponse DescribeBillingDataSync(DescribeBillingDataRequest req)
        {
             JsonResponseModel<DescribeBillingDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillingData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillingDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of hit requests
        /// + Request hit rate (in %)
        /// + Hit traffic (in bytes)
        /// + Traffic hit rate (in %)
        /// + Aggregate list of 2xx status codes and the details of status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx status codes and the details of status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx status codes and the details of status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx status codes and the details of status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public async Task<DescribeCdnDataResponse> DescribeCdnData(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of hit requests
        /// + Request hit rate (in %)
        /// + Hit traffic (in bytes)
        /// + Traffic hit rate (in %)
        /// + Aggregate list of 2xx status codes and the details of status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx status codes and the details of status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx status codes and the details of status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx status codes and the details of status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public DescribeCdnDataResponse DescribeCdnDataSync(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download link of an access log. You can use this API for access logs in the last 30 days either within or outside Mainland China.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download link of an access log. You can use this API for access logs in the last 30 days either within or outside Mainland China.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsSync(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN IP ownership.
        /// (Note: the request rate limit of this API is subject to the limit in CDN, which is 200 calls/10 minutes).  
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public async Task<DescribeCdnIpResponse> DescribeCdnIp(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN IP ownership.
        /// (Note: the request rate limit of this API is subject to the limit in CDN, which is 200 calls/10 minutes).  
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public DescribeCdnIpResponse DescribeCdnIpSync(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the IP information of CDN intermediate nodes. Note: this API will be deactivated soon and no longer be maintained. Please call `DescribeIpStatus` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public async Task<DescribeCdnOriginIpResponse> DescribeCdnOriginIp(DescribeCdnOriginIpRequest req)
        {
             JsonResponseModel<DescribeCdnOriginIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnOriginIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnOriginIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the IP information of CDN intermediate nodes. Note: this API will be deactivated soon and no longer be maintained. Please call `DescribeIpStatus` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnOriginIpRequest"/></param>
        /// <returns><see cref="DescribeCdnOriginIpResponse"/></returns>
        public DescribeCdnOriginIpResponse DescribeCdnOriginIpSync(DescribeCdnOriginIpRequest req)
        {
             JsonResponseModel<DescribeCdnOriginIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnOriginIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnOriginIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a SSL certificate and obtain its domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public async Task<DescribeCertDomainsResponse> DescribeCertDomains(DescribeCertDomainsRequest req)
        {
             JsonResponseModel<DescribeCertDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify a SSL certificate and obtain its domain names.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertDomainsRequest"/></param>
        /// <returns><see cref="DescribeCertDomainsResponse"/></returns>
        public DescribeCertDomainsResponse DescribeCertDomainsSync(DescribeCertDomainsRequest req)
        {
             JsonResponseModel<DescribeCertDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the basic configuration information of CDN acceleration domain names (inside and outside mainland China), including the project ID, service status, service type, creation time, and update time, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the basic configuration information of CDN acceleration domain names (inside and outside mainland China), including the project ID, service status, service type, creation time, and update time, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the complete configuration information of CDN acceleration domain names (inside and outside mainland China).
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public async Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the complete configuration information of CDN acceleration domain names (inside and outside mainland China).
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the IP details of edge nodes (available soon) and intermediate nodes. Note that there is a certain delay in data availability.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41954?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public async Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the IP details of edge nodes (available soon) and intermediate nodes. Note that there is a certain delay in data availability.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41954?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeIpVisit) is used to query the number of users who remain active for 5 minutes and the detailed number of daily active users.
        /// 
        /// + Number of users who remain active for 5 minutes: Collects deduplicated statistics based on client IP addresses in the log with the 5-minute granularity.
        /// + Number of daily active users: Collects deduplicated statistics based on client IP addresses in the log with the 1-day granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public async Task<DescribeIpVisitResponse> DescribeIpVisit(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeIpVisit) is used to query the number of users who remain active for 5 minutes and the detailed number of daily active users.
        /// 
        /// + Number of users who remain active for 5 minutes: Collects deduplicated statistics based on client IP addresses in the log with the 5-minute granularity.
        /// + Number of daily active users: Collects deduplicated statistics based on client IP addresses in the log with the 1-day granularity.
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public DescribeIpVisitResponse DescribeIpVisitSync(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeMapInfo) is used to query the IDs of districts or ISPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public async Task<DescribeMapInfoResponse> DescribeMapInfo(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeMapInfo) is used to query the IDs of districts or ISPs.
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public DescribeMapInfoResponse DescribeMapInfoSync(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN real-time origin-pull monitoring data and supports the following metrics:
        /// 
        /// + Origin-pull traffic (in bytes)
        /// + Origin-pull bandwidth (in bps)
        /// + Number of origin-pull requests
        /// + Number of failed origin-pull requests
        /// + Origin-pull failure rate (in % with two decimal digits)
        /// + Aggregate list of 2xx origin-pull status codes and the details of origin-pull status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx origin-pull status codes and the details of origin-pull status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx origin-pull status codes and the details of origin-pull status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx origin-pull status codes and the details of origin-pull status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public async Task<DescribeOriginDataResponse> DescribeOriginData(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CDN real-time origin-pull monitoring data and supports the following metrics:
        /// 
        /// + Origin-pull traffic (in bytes)
        /// + Origin-pull bandwidth (in bps)
        /// + Number of origin-pull requests
        /// + Number of failed origin-pull requests
        /// + Origin-pull failure rate (in % with two decimal digits)
        /// + Aggregate list of 2xx origin-pull status codes and the details of origin-pull status codes starting with 2 (in entries)
        /// + Aggregate list of 3xx origin-pull status codes and the details of origin-pull status codes starting with 3 (in entries)
        /// + Aggregate list of 4xx origin-pull status codes and the details of origin-pull status codes starting with 4 (in entries)
        /// + Aggregate list of 5xx origin-pull status codes and the details of origin-pull status codes starting with 5 (in entries)
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public DescribeOriginDataResponse DescribeOriginDataSync(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribePayType) is used to query billing information of the current account, such as billing mode and billing cycle.
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public async Task<DescribePayTypeResponse> DescribePayType(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribePayType) is used to query billing information of the current account, such as billing mode and billing cycle.
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public DescribePayTypeResponse DescribePayTypeSync(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purge usage quota and daily available usage for an account.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public async Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purge usage quota and daily available usage for an account.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the record and progress of URL or directory purge tasks submitted via the `PurgePathCache` or `PurgeUrlsCache` APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the record and progress of URL or directory purge tasks submitted via the `PurgePathCache` or `PurgeUrlsCache` APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the prefetch quota and daily available usage.
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public async Task<DescribePushQuotaResponse> DescribePushQuota(DescribePushQuotaRequest req)
        {
             JsonResponseModel<DescribePushQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the prefetch quota and daily available usage.
        /// </summary>
        /// <param name="req"><see cref="DescribePushQuotaRequest"/></param>
        /// <returns><see cref="DescribePushQuotaResponse"/></returns>
        public DescribePushQuotaResponse DescribePushQuotaSync(DescribePushQuotaRequest req)
        {
             JsonResponseModel<DescribePushQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the submission record and progress of prefetch tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public async Task<DescribePushTasksResponse> DescribePushTasks(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the submission record and progress of prefetch tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public DescribePushTasksResponse DescribePushTasksSync(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily/weekly/monthly report data at domain name/project levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public async Task<DescribeReportDataResponse> DescribeReportData(DescribeReportDataRequest req)
        {
             JsonResponseModel<DescribeReportDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the daily/weekly/monthly report data at domain name/project levels.
        /// </summary>
        /// <param name="req"><see cref="DescribeReportDataRequest"/></param>
        /// <returns><see cref="DescribeReportDataResponse"/></returns>
        public DescribeReportDataResponse DescribeReportDataSync(DescribeReportDataRequest req)
        {
             JsonResponseModel<DescribeReportDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReportData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of domain name URLs containing regulation-violating content scanned and detected by the CDN system, and the current status of the URLs.
        /// It corresponds to the **Pornography Detection** page on the CDN Console.
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public async Task<DescribeUrlViolationsResponse> DescribeUrlViolations(DescribeUrlViolationsRequest req)
        {
             JsonResponseModel<DescribeUrlViolationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUrlViolations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlViolationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of domain name URLs containing regulation-violating content scanned and detected by the CDN system, and the current status of the URLs.
        /// It corresponds to the **Pornography Detection** page on the CDN Console.
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlViolationsRequest"/></param>
        /// <returns><see cref="DescribeUrlViolationsResponse"/></returns>
        public DescribeUrlViolationsResponse DescribeUrlViolationsSync(DescribeUrlViolationsRequest req)
        {
             JsonResponseModel<DescribeUrlViolationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUrlViolations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlViolationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to block access to a specific URL on CDN. When a URL is blocked, error 403 will be returned for requests from the Chinese mainland. URL blocking is not permanent. Note that this API is only available to beta users now. 
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public async Task<DisableCachesResponse> DisableCaches(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to block access to a specific URL on CDN. When a URL is blocked, error 403 will be returned for requests from the Chinese mainland. URL blocking is not permanent. Note that this API is only available to beta users now. 
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public DisableCachesResponse DisableCachesSync(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop publishing to a log topic. Note: after a log topic is disabled, all logs of the domain names bound to it will no longer be published to the topic, and the logs that have already been published will be retained. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public async Task<DisableClsLogTopicResponse> DisableClsLogTopic(DisableClsLogTopicRequest req)
        {
             JsonResponseModel<DisableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop publishing to a log topic. Note: after a log topic is disabled, all logs of the domain names bound to it will no longer be published to the topic, and the logs that have already been published will be retained. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="DisableClsLogTopicRequest"/></param>
        /// <returns><see cref="DisableClsLogTopicResponse"/></returns>
        public DisableClsLogTopicResponse DisableClsLogTopicSync(DisableClsLogTopicRequest req)
        {
             JsonResponseModel<DisableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableCaches) is used to unblock manually blocked URLs. After a URL is successfully unblocked, it takes about 5 to 10 minutes to take effect across the entire network. (This API is during beta test and not fully available now.)
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public async Task<EnableCachesResponse> EnableCaches(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableCaches) is used to unblock manually blocked URLs. After a URL is successfully unblocked, it takes about 5 to 10 minutes to take effect across the entire network. (This API is during beta test and not fully available now.)
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public EnableCachesResponse EnableCachesSync(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start publishing to a log topic. Note: after a log topic is enabled, all logs of the domain names bound to the topic will be published to it. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public async Task<EnableClsLogTopicResponse> EnableClsLogTopic(EnableClsLogTopicRequest req)
        {
             JsonResponseModel<EnableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start publishing to a log topic. Note: after a log topic is enabled, all logs of the domain names bound to the topic will be published to it. This action will take effect within 5–15 minutes.
        /// </summary>
        /// <param name="req"><see cref="EnableClsLogTopicRequest"/></param>
        /// <returns><see cref="EnableClsLogTopicResponse"/></returns>
        public EnableClsLogTopicResponse EnableClsLogTopicSync(EnableClsLogTopicRequest req)
        {
             JsonResponseModel<EnableClsLogTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableClsLogTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableClsLogTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the resource blocking history and the current URL status. (This API is in beta test and not generally available yet.)
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public async Task<GetDisableRecordsResponse> GetDisableRecords(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the resource blocking history and the current URL status. (This API is in beta test and not generally available yet.)
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public GetDisableRecordsResponse GetDisableRecordsSync(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the list of log topics. Note: a logset can contain up to 10 log topics.
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public async Task<ListClsLogTopicsResponse> ListClsLogTopics(ListClsLogTopicsRequest req)
        {
             JsonResponseModel<ListClsLogTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClsLogTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsLogTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display the list of log topics. Note: a logset can contain up to 10 log topics.
        /// </summary>
        /// <param name="req"><see cref="ListClsLogTopicsRequest"/></param>
        /// <returns><see cref="ListClsLogTopicsResponse"/></returns>
        public ListClsLogTopicsResponse ListClsLogTopicsSync(ListClsLogTopicsRequest req)
        {
             JsonResponseModel<ListClsLogTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClsLogTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsLogTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public async Task<ListClsTopicDomainsResponse> ListClsTopicDomains(ListClsTopicDomainsRequest req)
        {
             JsonResponseModel<ListClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ListClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ListClsTopicDomainsResponse"/></returns>
        public ListClsTopicDomainsResponse ListClsTopicDomainsSync(ListClsTopicDomainsRequest req)
        {
             JsonResponseModel<ListClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list data sorted the following ways by using different combinations of the Metric and Filter input parameters:
        /// 
        /// + It sorts access URLs by total traffic and total requests, and returns the top 1,000 URLs in descending order.
        /// + It sorts client districts by total traffic and total requests, and returns the list of districts in descending order.
        /// + It sorts client ISPs by total traffic and total requests, and returns the list of ISPs in descending order.
        /// + It sorts domain names by total traffic, peak bandwidth, total requests, average hit rate, and 2XX/3XX/4XX/5XX status codes, and returns the list of domain names in descending order.
        /// + It sorts domain names by total origin-pull traffic, peak origin-pull bandwidth, total origin-pull requests, average origin-pull failure rate, and 2XX/3XX/4XX/5XX origin-pull status codes, and returns the list of domain names in descending order.
        /// 
        /// Note: only data from the last 90 days will be queried.
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public async Task<ListTopDataResponse> ListTopData(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list data sorted the following ways by using different combinations of the Metric and Filter input parameters:
        /// 
        /// + It sorts access URLs by total traffic and total requests, and returns the top 1,000 URLs in descending order.
        /// + It sorts client districts by total traffic and total requests, and returns the list of districts in descending order.
        /// + It sorts client ISPs by total traffic and total requests, and returns the list of ISPs in descending order.
        /// + It sorts domain names by total traffic, peak bandwidth, total requests, average hit rate, and 2XX/3XX/4XX/5XX status codes, and returns the list of domain names in descending order.
        /// + It sorts domain names by total origin-pull traffic, peak origin-pull bandwidth, total origin-pull requests, average origin-pull failure rate, and 2XX/3XX/4XX/5XX origin-pull status codes, and returns the list of domain names in descending order.
        /// 
        /// Note: only data from the last 90 days will be queried.
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public ListTopDataResponse ListTopDataSync(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public async Task<ManageClsTopicDomainsResponse> ManageClsTopicDomains(ManageClsTopicDomainsRequest req)
        {
             JsonResponseModel<ManageClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the list of domain names bound to a log topic.
        /// </summary>
        /// <param name="req"><see cref="ManageClsTopicDomainsRequest"/></param>
        /// <returns><see cref="ManageClsTopicDomainsResponse"/></returns>
        public ManageClsTopicDomainsResponse ManageClsTopicDomainsSync(ManageClsTopicDomainsRequest req)
        {
             JsonResponseModel<ManageClsTopicDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageClsTopicDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageClsTopicDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public async Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple URL purge tasks, which are carried out according to the current acceleration region of the domain names in the URLs.
        /// By default, a maximum of 10,000 URLs can be purged per day for acceleration regions either within or outside Mainland China, and up to 1,000 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public async Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit multiple URL purge tasks, which are carried out according to the current acceleration region of the domain names in the URLs.
        /// By default, a maximum of 10,000 URLs can be purged per day for acceleration regions either within or outside Mainland China, and up to 1,000 tasks can be submitted at a time.
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public async Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1000 URLs can be prefetched per day for regions either within or outside the Chinese mainland, and up to 500 tasks can be submitted at a time. Note that resources prefetched outside the Chinese mainland will be cached to CDN nodes outside the Chinese mainland and the traffic generated will incur costs.
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for CLS logs. Search filters can be set to today, 24 hours (one of the last 7 days), and the last 7 days.
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public async Task<SearchClsLogResponse> SearchClsLog(SearchClsLogRequest req)
        {
             JsonResponseModel<SearchClsLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to search for CLS logs. Search filters can be set to today, 24 hours (one of the last 7 days), and the last 7 days.
        /// </summary>
        /// <param name="req"><see cref="SearchClsLogRequest"/></param>
        /// <returns><see cref="SearchClsLogResponse"/></returns>
        public SearchClsLogResponse SearchClsLogSync(SearchClsLogRequest req)
        {
             JsonResponseModel<SearchClsLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchClsLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchClsLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the acceleration service for a disabled domain name.
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public async Task<StartCdnDomainResponse> StartCdnDomain(StartCdnDomainRequest req)
        {
             JsonResponseModel<StartCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the acceleration service for a disabled domain name.
        /// </summary>
        /// <param name="req"><see cref="StartCdnDomainRequest"/></param>
        /// <returns><see cref="StartCdnDomainResponse"/></returns>
        public StartCdnDomainResponse StartCdnDomainSync(StartCdnDomainRequest req)
        {
             JsonResponseModel<StartCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to suspend the acceleration service for a domain name.
        /// Note: after the acceleration service has been suspended, requests to the cache node will return a 404 error. In order to avoid impact to your business, please move the domain name to another service before suspending the acceleration service.
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public async Task<StopCdnDomainResponse> StopCdnDomain(StopCdnDomainRequest req)
        {
             JsonResponseModel<StopCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to suspend the acceleration service for a domain name.
        /// Note: after the acceleration service has been suspended, requests to the cache node will return a 404 error. In order to avoid impact to your business, please move the domain name to another service before suspending the acceleration service.
        /// </summary>
        /// <param name="req"><see cref="StopCdnDomainRequest"/></param>
        /// <returns><see cref="StopCdnDomainResponse"/></returns>
        public StopCdnDomainResponse StopCdnDomainSync(StopCdnDomainRequest req)
        {
             JsonResponseModel<StopCdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopCdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopCdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of CDN acceleration domain names.
        /// Note: if you need to update complex configuration items, you must pass all the attributes of the entire object. The default value will be used for attributes that are not passed. We recommend calling the querying API to obtain the configuration attributes first. You can then modify and pass the attributes to the API. The certificate and key fields do not need to be passed for HTTPS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public async Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration of CDN acceleration domain names.
        /// Note: if you need to update complex configuration items, you must pass all the attributes of the entire object. The default value will be used for attributes that are not passed. We recommend calling the querying API to obtain the configuration attributes first. You can then modify and pass the attributes to the API. The certificate and key fields do not need to be passed for HTTPS configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the billing mode of an account. At present, the billing mode of accounts on a monthly billing cycle and sub-accounts cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public async Task<UpdatePayTypeResponse> UpdatePayType(UpdatePayTypeRequest req)
        {
             JsonResponseModel<UpdatePayTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the billing mode of an account. At present, the billing mode of accounts on a monthly billing cycle and sub-accounts cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="UpdatePayTypeRequest"/></param>
        /// <returns><see cref="UpdatePayTypeResponse"/></returns>
        public UpdatePayTypeResponse UpdatePayTypeSync(UpdatePayTypeRequest req)
        {
             JsonResponseModel<UpdatePayTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify security configurations of SCDN acceleration domain names.
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public async Task<UpdateScdnDomainResponse> UpdateScdnDomain(UpdateScdnDomainRequest req)
        {
             JsonResponseModel<UpdateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify security configurations of SCDN acceleration domain names.
        /// </summary>
        /// <param name="req"><see cref="UpdateScdnDomainRequest"/></param>
        /// <returns><see cref="UpdateScdnDomainResponse"/></returns>
        public UpdateScdnDomainResponse UpdateScdnDomainSync(UpdateScdnDomainRequest req)
        {
             JsonResponseModel<UpdateScdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateScdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
