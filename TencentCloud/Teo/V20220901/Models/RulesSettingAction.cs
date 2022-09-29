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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RulesSettingAction : AbstractModel
    {
        
        /// <summary>
        /// Feature name. Valid values:
        /// <li>Access URL rewrite (`AccessUrlRedirect`).</li>
        /// <li>Origin-pull URL rewrite (`UpstreamUrlRedirect`).</li>
        /// <li>Custom error page
        /// (`ErrorPage`).</li>
        /// <li>QUIC (`QUIC`).</li>
        /// <li>WebSocket (`WebSocket`).</li>
        /// <li>Video dragging (`VideoSeek`).</li>
        /// <li>Token authentication (`Authentication`).</li>
        /// <li>`CacheKey`: Custom cache key.</li>
        /// <li>`Cache`: Node cache TTL.</li>
        /// <li>`MaxAge`: Browser cache TTL.</li>
        /// <li>`OfflineCache`: Offline cache.</li>
        /// <li>`SmartRouting`: Smart acceleration.</li>
        /// <li>`RangeOriginPull`: Range GETs.</li>
        /// <li>`UpstreamHttp2`: HTTP/2 forwarding.</li>
        /// <li>`HostHeader`: Host header rewrite.</li>
        /// <li>`ForceRedirect`: Force HTTPS.</li>
        /// <li>`OriginPullProtocol`: Origin-pull HTTPS.</li>
        /// <li>`CachePrefresh`: Cache prefresh.</li>
        /// <li>`Compression`: Smart compression.</li>
        /// <li>`RequestHeader`: HTTP request header modification.</li>
        /// <li>HTTP response header modification (`ResponseHeader`).</li>
        /// <li>Status code cache TTL (`StatusCodeCache`).</li>
        /// <li>`Hsts`.</li>
        /// <li>`ClientIpHeader`.</li>
        /// <li>`TlsVersion`.</li>
        /// <li>`OcspStapling`.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Parameter information
        /// </summary>
        [JsonProperty("Properties")]
        public RulesProperties[] Properties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
        }
    }
}

