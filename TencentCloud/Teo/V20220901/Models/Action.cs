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

    public class Action : AbstractModel
    {
        
        /// <summary>
        /// Common operation. Values:
        /// <li>`AccessUrlRedirect`: Access URL rewrite</li>
        /// <li>`UpstreamUrlRedirect`: Origin-pull URL rewrite</li>
        /// <li>`QUIC`: QUIC</li>
        /// <li>`WebSocket`: WebSocket</li>
        /// <li>`VideoSeek`: Video dragging</li>
        /// <li>`Authentication`: Token authentication</li>
        /// <li>`CacheKey`: Custom cache key</li>
        /// <li>`Cache`: Node cache TTL</li>
        /// <li>`MaxAge`: Browser cache TTL</li>
        /// <li>`OfflineCache`: Offline cache</li>
        /// <li>`SmartRouting`: Smart acceleration</li>
        /// <li>`RangeOriginPull`: Range GETs</li>
        /// <li>`UpstreamHttp2`: HTTP/2 forwarding</li>
        /// <li>`HostHeader`: Host header rewrite</li>
        /// <li>`ForceRedirect`: Force HTTPS</li>
        /// <li>`OriginPullProtocol`: Origin-pull HTTPS</li>
        /// <li>`CachePrefresh`: Cache prefresh</li>
        /// <li>`Compression`: Smart compression</li>
        /// <li>`Hsts`</li>
        /// <li>`ClientIpHeader`</li>
        /// <li>`SslTlsSecureConf`</li>
        /// <li>`OcspStapling`</li>
        /// <li>`Http2`: HTTP/2 access</li>
        /// <li>`UpstreamFollowRedirect`: Follow origin redirect</li>
        /// <li>`Origin`: Origin</li>
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NormalAction")]
        public NormalAction NormalAction{ get; set; }

        /// <summary>
        /// Feature operation with a request/response header. Features of this type include:
        /// <li>`RequestHeader`: HTTP request header modification.</li>
        /// <li>`ResponseHeader`: HTTP response header modification.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RewriteAction")]
        public RewriteAction RewriteAction{ get; set; }

        /// <summary>
        /// Feature operation with a status code. Features of this type include:
        /// <li>`ErrorPage`: Custom error page.</li>
        /// <li>`StatusCodeCache`: Status code cache TTL.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodeAction")]
        public CodeAction CodeAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NormalAction.", this.NormalAction);
            this.SetParamObj(map, prefix + "RewriteAction.", this.RewriteAction);
            this.SetParamObj(map, prefix + "CodeAction.", this.CodeAction);
        }
    }
}

