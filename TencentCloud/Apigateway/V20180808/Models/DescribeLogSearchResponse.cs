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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogSearchResponse : AbstractModel
    {
        
        /// <summary>
        /// Cursor for getting more search results. If the value is `""`, there will be no subsequent results
        /// </summary>
        [JsonProperty("ConText")]
        public string ConText{ get; set; }

        /// <summary>
        /// The returned result contains zero or multiple logs, which are in the following format:
        /// '[$app_id][$env_name][$service_id][$http_host][$api_id][$uri][$scheme][rsp_st:$status][ups_st:$upstream_status]'
        /// '[cip:$remote_addr][uip:$upstream_addr][vip:$server_addr][rsp_len:$bytes_sent][req_len:$request_length]'
        /// '[req_t:$request_time][ups_rsp_t:$upstream_response_time][ups_conn_t:$upstream_connect_time][ups_head_t:$upstream_header_time]’
        /// '[err_msg:$err_msg][tcp_rtt:$tcpinfo_rtt][$pid][$time_local][req_id:$request_id]';
        /// 
        /// Note:
        /// app_id: user ID.
        /// env_name: environment name.
        /// service_id: service ID.
        /// http_host: domain name.
        /// api_id: API ID.
        /// uri: request path.
        /// scheme: HTTP/HTTPS protocol.
        /// rsp_st: request response status code.
        /// ups_st: backend business server response status code (if the request is passed through to the backend, this variable will not be empty. If the request is blocked in API Gateway, this variable will be `-`).
        /// cip: client IP.
        /// uip: backend business service (upstream) IP.
        /// vip: VIP requested to be accessed.
        /// rsp_len: response length.
        /// req_len: request length.
        /// req_t: total request response time.
        /// ups_rsp_t: total backend response time (time between connection establishment by API Gateway and backend response reception).
        /// ups_conn_t: time when the backend business server is successfully connected.
        /// ups_head_t: time when the backend response head arrives.
        /// err_msg: error message.
        /// tcp_rtt: client TCP connection information. RTT (Round Trip Time) consists of three parts: link propagation delay, end system processing delay, queuing and processing delay in router cache.
        /// req_id: request ID.
        /// </summary>
        [JsonProperty("LogSet")]
        public string[] LogSet{ get; set; }

        /// <summary>
        /// Number of logs returned for a search (`TotalCount <= Limit`)
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConText", this.ConText);
            this.SetParamArraySimple(map, prefix + "LogSet.", this.LogSet);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

