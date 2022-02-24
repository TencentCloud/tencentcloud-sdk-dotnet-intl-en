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

namespace TencentCloud.Ecdn.V20191012
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecdn.V20191012.Models;

   public class EcdnClient : AbstractClient{

       private const string endpoint = "ecdn.tencentcloudapi.com";
       private const string version = "2019-10-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EcdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an acceleration domain name.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41123?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public async Task<AddEcdnDomainResponse> AddEcdnDomain(AddEcdnDomainRequest req)
        {
             JsonResponseModel<AddEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an acceleration domain name.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41123?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public AddEcdnDomainResponse AddEcdnDomainSync(AddEcdnDomainRequest req)
        {
             JsonResponseModel<AddEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name. The acceleration domain name to be deleted must be in disabled status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/570/42471?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public async Task<DeleteEcdnDomainResponse> DeleteEcdnDomain(DeleteEcdnDomainRequest req)
        {
             JsonResponseModel<DeleteEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a specified acceleration domain name. The acceleration domain name to be deleted must be in disabled status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/570/42471?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public DeleteEcdnDomainResponse DeleteEcdnDomainSync(DeleteEcdnDomainRequest req)
        {
             JsonResponseModel<DeleteEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the basic information of a CDN domain name, including the project ID, status, business type, creation time, update time, etc.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41118?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the basic information of a CDN domain name, including the project ID, status, business type, creation time, update time, etc.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41118?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the detailed configuration information of a CDN acceleration domain name.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41117?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the detailed configuration information of a CDN acceleration domain name.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41117?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the access log download link of a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public async Task<DescribeEcdnDomainLogsResponse> DescribeEcdnDomainLogs(DescribeEcdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the access log download link of a domain name.
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public DescribeEcdnDomainLogsResponse DescribeEcdnDomainLogsSync(DescribeEcdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistical metrics of domain name access within a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public async Task<DescribeEcdnDomainStatisticsResponse> DescribeEcdnDomainStatistics(DescribeEcdnDomainStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnDomainStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistical metrics of domain name access within a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public DescribeEcdnDomainStatisticsResponse DescribeEcdnDomainStatisticsSync(DescribeEcdnDomainStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnDomainStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query ECDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of 2xx status codes and details of status codes starting with 2
        /// + Number of 3xx status codes and details of status codes starting with 3
        /// + Number of 4xx status codes and details of status codes starting with 4
        /// + Number of 5xx status codes and details of status codes starting with 5
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnStatisticsResponse"/></returns>
        public async Task<DescribeEcdnStatisticsResponse> DescribeEcdnStatistics(DescribeEcdnStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query ECDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Number of 2xx status codes and details of status codes starting with 2
        /// + Number of 3xx status codes and details of status codes starting with 3
        /// + Number of 4xx status codes and details of status codes starting with 4
        /// + Number of 5xx status codes and details of status codes starting with 5
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnStatisticsResponse"/></returns>
        public DescribeEcdnStatisticsResponse DescribeEcdnStatisticsSync(DescribeEcdnStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query ECDN node IPs. This API is only available to beta users. Please submit a ticket to use it.
        /// 
        /// If you need to add the node IPs to your origin allowlist, keep querying the updating the IPs regularly to ensure the success of origin forwarding. 
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
        /// This API is used to query ECDN node IPs. This API is only available to beta users. Please submit a ticket to use it.
        /// 
        /// If you need to add the node IPs to your origin allowlist, keep querying the updating the IPs regularly to ensure the success of origin forwarding. 
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
        /// This API is used to query the usage quota of the purge API.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41956?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the usage quota of the purge API.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/41956?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the submission record and progress of purge tasks.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/37873?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to query the submission record and progress of purge tasks.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/37873?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to purge cache directories in batches. One purge task ID will be returned for each submission.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/570/42475?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to purge cache directories in batches. One purge task ID will be returned for each submission.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/570/42475?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to batch purge URLs. One purge task ID will be returned for each submission.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/37870?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to batch purge URLs. One purge task ID will be returned for each submission.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/api/228/37870?from_cn_redirect=1">corresponding CDN API</a>.
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
        /// This API is used to enable an acceleration domain name. The domain name to be enabled must be in deactivated status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/product/228/41121?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public async Task<StartEcdnDomainResponse> StartEcdnDomain(StartEcdnDomainRequest req)
        {
             JsonResponseModel<StartEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable an acceleration domain name. The domain name to be enabled must be in deactivated status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/product/228/41121?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public StartEcdnDomainResponse StartEcdnDomainSync(StartEcdnDomainRequest req)
        {
             JsonResponseModel<StartEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an acceleration domain name. The domain name to be disabled must be in enabled or deploying status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/product/228/41120?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public async Task<StopEcdnDomainResponse> StopEcdnDomain(StopEcdnDomainRequest req)
        {
             JsonResponseModel<StopEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an acceleration domain name. The domain name to be disabled must be in enabled or deploying status.
        /// 
        /// >? If you have migrated your ECDN service to CDN, you can use the <a href="https://intl.cloud.tencent.com/document/product/228/41120?from_cn_redirect=1">corresponding CDN API</a>.
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public StopEcdnDomainResponse StopEcdnDomainSync(StopEcdnDomainRequest req)
        {
             JsonResponseModel<StopEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the configuration information of an ECDN acceleration domain name.
        /// Note: if you need to update complex configuration items, you must pass all the attributes of the entire object. The default value will be used for attributes that are not passed. We recommend calling the querying API to obtain the configuration attributes first. You can then modify and pass the attributes to the API. The certificate and key fields do not need to be passed for HTTPS configuration.
        /// 
        /// >?  If your application has been migrated to Tencent Cloud CDN, you can use <a href="https://intl.cloud.tencent.com/document/product/228/41116?from_cn_redirect=1">CDN APIs</a>.
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
        /// This API is used to update the configuration information of an ECDN acceleration domain name.
        /// Note: if you need to update complex configuration items, you must pass all the attributes of the entire object. The default value will be used for attributes that are not passed. We recommend calling the querying API to obtain the configuration attributes first. You can then modify and pass the attributes to the API. The certificate and key fields do not need to be passed for HTTPS configuration.
        /// 
        /// >?  If your application has been migrated to Tencent Cloud CDN, you can use <a href="https://intl.cloud.tencent.com/document/product/228/41116?from_cn_redirect=1">CDN APIs</a>.
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

    }
}
