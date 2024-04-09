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
        /// Common feature operations. The options for this category include:
        /// <li> Access URL overriding (AccessUrlRedirect);</li>
        /// <li> Origin URL overriding (UpstreamUrlRedirect);</li>
        /// <li> QUIC;</li>
        /// <li> WebSocket;</li>
        /// <li> Video dragging (VideoSeek);</li>
        /// <li> Token authentication (Authentication);</li>
        /// <li> Custom CacheKey (CacheKey);</li>
        /// <li> Node caching TTL (Cache);</li>
        /// <li> Browser caching TTL (MaxAge);</li>
        /// <li> Offline caching (OfflineCache);</li>
        /// <li> Smart routing (SmartRouting);</li>
        /// <li> Range-based origin pull (RangeOriginPull);</li>
        /// <li> HTTP/2 origin pull (UpstreamHttp2);</li>
        /// <li> Host header overriding (HostHeader);</li>
        /// <li> Forced HTTPS (ForceRedirect);</li>
        /// <li> HTTPS origin pull (OriginPullProtocol);</li>
        /// <li> Cache pre-refresh (CachePrefresh);</li>
        /// <li> Smart compression (Compression);</li>
        /// <li> Hsts;</li>
        /// <li> ClientIpHeader;</li>
        /// <li> SslTlsSecureConf;</li>
        /// <li> OcspStapling;</li>
        /// <li> HTTP/2 access (Http2);</li>
        /// <li> Redirection during origin pull (UpstreamFollowRedirect);</li>
        /// <li> Modifying origin server (Origin);</li>
        /// <li> Layer 7 origin pull timeout (HTTPUpstreamTimeout);</li>
        /// <li> HTTP response (HttpResponse).</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

