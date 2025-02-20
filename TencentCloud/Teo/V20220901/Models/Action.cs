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
        /// Common feature operations. the options for this category include:.
        /// <Li>Access url rewrite (`accessurlredirect`).</li>.
        /// <Li> origin url overriding (upstreamurlredirect);</li>.
        /// <Li> quic;</li>.
        /// <Li> websocket;</li>.
        /// <Li> video dragging (videoseek);</li>.
        /// <Li> token authentication (authentication);</li>.
        /// <Li> custom cachekey (cachekey);</li>.
        /// <Li> node caching ttl (cache);</li>.
        /// <Li> browser cache ttl (maxage);</li>.
        /// <Li> offline caching (offlinecache);</li>.
        /// <Li> smart acceleration (smartrouting);</li>.
        /// <Li> range-based origin pull (rangeoriginpull);</li>.
        /// <Li> http/2 origin pull (upstreamhttp2);</li>.
        /// <Li> host header overriding (hostheader);</li>.
        /// <Li> force https (forceredirect);</li>.
        /// <Li> https origin pull (originpullprotocol);</li>.
        /// <Li>`ResponseSpeedLimit`: single connection download speed limit.</li>.
        /// <Li>`CachePrefresh`: cache prefresh.</li>.
        /// <Li>`Compression`: smart compression.</li>.
        /// <Li>Hsts;</Li>.
        /// <Li>ClientIpHeader;</Li>.
        /// <Li> ssltlssecureconf;</li>.
        /// <Li> ocspstapling;</li>.
        /// <Li> http/2 access (http2);</li>.
        /// <Li> redirection during origin pull (upstreamfollowredirect);</li>.
        /// <Li> modifying origin server (origin);</li>.
        /// <Li> layer 7 origin pull timeout (httpupstreamtimeout).</li>.
        /// <Li> http response (httpresponse).</li>.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
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

