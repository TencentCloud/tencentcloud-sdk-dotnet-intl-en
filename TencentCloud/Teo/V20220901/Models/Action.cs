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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Action : AbstractModel
    {
        
        /// <summary>
        /// Normal feature operation. Feature items of this type:
        /// <li> Access URL rewrite (AccessUrlRedirect);</li>
        /// <li> Origin-pull URL rewrite (UpstreamUrlRedirect);</li>
        /// <li> QUIC(QUIC);</li>
        /// <li> WebSocket (WebSocket);</li>
        /// <li> Video dragging (VideoSeek);</li>
        /// <li> Token authentication (Authentication);</li>
        /// <li> Custom CacheKey (CacheKey);</li>
        /// <li> Node cache TTL (Cache);</li>
        /// <li> Browser caching TTL (MaxAge);</li>
        /// <li> Offline caching (OfflineCache);</li>
        /// <li> Smart acceleration (SmartRouting);</li>
        /// <li> Range-based origin pull (RangeOriginPull);</li>
        /// <li> HTTP/2 origin pull (UpstreamHttp2);</li>
        /// <li> Host header overriding (HostHeader);</li>
        /// <li> Force HTTPS (ForceRedirect);</li>
        /// <li> HTTPS origin pull (OriginPullProtocol);</li>
        /// <li> Single connection download speed limit (ResponseSpeedLimit);</li>
        /// <li> Cache pre-refresh (CachePrefresh);</li>
        /// <li> Intelligent compression (Compression);</li>
        /// <li> Hsts;</li>
        /// <li> ClientIpHeader;</li>
        /// <li> SslTlsSecureConf;</li>
        /// <li> OcspStapling;</li>
        /// <li> HTTP/2 access (Http2);</li>
        /// <li> Redirection during origin pull (UpstreamFollowRedirect);</li>
        /// <li> Modifying origin server (Origin);</li>
        /// <li> Layer 7 origin pull timeout (HTTPUpstreamTimeout).</li>
        /// <li> HTTP response (HttpResponse).</li>
        /// </summary>
        [JsonProperty("NormalAction")]
        public NormalAction NormalAction{ get; set; }

        /// <summary>
        /// Feature operations with request/response headers. Feature items of this type include:
        /// <li>HTTP request header modification (RequestHeader).</li>
        /// <li> HTTP response header modification (ResponseHeader).</li>
        /// </summary>
        [JsonProperty("RewriteAction")]
        public RewriteAction RewriteAction{ get; set; }

        /// <summary>
        /// Feature operation with a status code. Feature items of this type:
        /// <li> Custom error page (ErrorPage);</li>
        /// <li> Status code cache TTL (StatusCodeCache).</li>
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

