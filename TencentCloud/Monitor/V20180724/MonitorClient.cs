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

namespace TencentCloud.Monitor.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20180724.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2018-07-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to get the details of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public async Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of basic metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monitoring data of a Tencent Cloud product by passing in the product's namespace, object dimension description, and monitoring metric.
        /// API call rate limit: 20 calls/sec, 1,200 calls/min.
        /// If you need to call a lot of metrics and objects, there may be cases where the call fails due to the rate limit. It is recommended to spread the call requests as much as possible over time.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public async Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the monitoring data of a Tencent Cloud product by passing in the product's namespace, object dimension description, and monitoring metric.
        /// API call rate limit: 20 calls/sec, 1,200 calls/min.
        /// If you need to call a lot of metrics and objects, there may be cases where the call fails due to the rate limit. It is recommended to spread the call requests as much as possible over time.
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
