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
        /// This API (DescribeCdnData) is used to query CDN real-time access monitoring data and supports the following metrics:
        /// 
        /// + Traffic (in bytes)
        /// + Bandwidth (in bps)
        /// + Number of requests
        /// + Traffic hit rate (in % with two decimal digits)
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
        /// This API is used to query CDN IP ownership.
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
        /// This API (DescribeOriginData) is used to query CDN real-time origin-pull monitoring data and supports the following metrics:
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
        /// This API is used to query the submission record and progress of prefetch tasks.
        /// This API is in beta test and not fully available yet. Please stay tuned.
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
        /// This API (DisableCaches) is used to block access to a specific URL on CDN. After a URL is blocked, error 403 will be returned for all access requests to it. (This API is during beta test and not fully available now.)
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
        /// This API (GetDisableRecords) is used to query the resource blocking history and the current URL status. (This API is during beta test and not fully available now.)
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
        /// This API (ListTopData) is used to query the following sorting data by using different combinations of the `Metric` and `Filter` input parameters:
        /// 
        /// + Sorts access URLs by total traffic and total requests and returns top 1,000 URLs in descending order.
        /// + Sorts client districts by total traffic and total requests and returns the list of districts in descending order.
        /// + Sorts client ISPs by total traffic and total requests and returns the list of ISPs in descending order.
        /// + Sorts domain names by total traffic, peak bandwidth, total requests, average hit rate, and 2XX/3XX/4XX/5XX status codes and returns the list of domain names in descending order.
        /// + Sorts domain names by total origin-pull traffic, peak origin-pull bandwidth, total origin-pull requests, average origin-pull failure rate, and 2XX/3XX/4XX/5XX origin-pull status codes and returns the list of domain names in descending order.
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
        /// This API is used to submit multiple directory purge tasks, which are carried out according to the acceleration region of the domain names.
        /// By default, a maximum of 100 directories can be purged per day for acceleration regions either within or outside Mainland China, and up to 20 tasks can be submitted at a time.
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
        /// This API is used to cache specified URL resources to CDN nodes. You can specify acceleration regions for the prefetch.
        /// By default, a maximum of 1,000 URLs can be prefetched per day either within or outside Mainland China, and up to 20 tasks can be submitted at a time.
        /// This API is in beta test and not fully available yet. Please stay tuned.
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

    }
}
