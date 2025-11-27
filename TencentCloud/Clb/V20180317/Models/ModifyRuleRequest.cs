/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance. You can call the [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/214/30685?from_cn_redirect=1) API to obtain the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// ID of the clb listener. can be obtained through the [DescribeListeners](https://www.tencentcloud.comom/document/product/214/30686?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Specifies the rule ID of the forwarding rule to be modified, which can be obtained through the DescribeListeners API (https://www.tencentcloud.comom/document/product/214/30686?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// New forwarding path of the forwarding rule. This parameter is not required if the URL does not need to be modified.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Health check information
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Request forwarding method of the rule. Value range: WRR, LEAST_CONN, IP_HASH
        /// They represent weighted round robin, least connections, and IP hash, respectively. Default value: WRR.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Session persistence duration, in seconds. Value range: 0 or 30-86400.
        /// Defaults to 0.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Forwarding protocol between a CLB instance and the real server. Default value: HTTP. Valid values: HTTP, HTTPS, GRPC. This parameter is valid only for HTTPS listeners.
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// TRPC callee server route, which is required when `ForwardType` is "TRPC". This is now only for internal usage.
        /// </summary>
        [JsonProperty("TrpcCallee")]
        public string TrpcCallee{ get; set; }

        /// <summary>
        /// TRPC calling service API, which is required when `ForwardType` is "TRPC". This is now only for internal usage.
        /// </summary>
        [JsonProperty("TrpcFunc")]
        public string TrpcFunc{ get; set; }

        /// <summary>
        /// OAuth configuration information.
        /// </summary>
        [JsonProperty("OAuth")]
        public OAuth OAuth{ get; set; }

        /// <summary>
        /// Specifies the custom cookie name.
        /// </summary>
        [JsonProperty("CookieName")]
        public string CookieName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "TrpcCallee", this.TrpcCallee);
            this.SetParamSimple(map, prefix + "TrpcFunc", this.TrpcFunc);
            this.SetParamObj(map, prefix + "OAuth.", this.OAuth);
            this.SetParamSimple(map, prefix + "CookieName", this.CookieName);
        }
    }
}

