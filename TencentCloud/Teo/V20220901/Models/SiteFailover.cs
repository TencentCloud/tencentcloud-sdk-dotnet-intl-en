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

    public class SiteFailover : AbstractModel
    {
        
        /// <summary>
        /// Origin-pull failover type. Valid values:
        /// <li>FailoverToHost: Failover to the specified IP/domain;</li>
        /// <li> FailoverToCOS: Failover to Tencent Cloud COS;</li>
        /// <li>FailoverToS3CompatibleObjectStorage: Failover to S3-compatible storage;</li>
        /// <li> FailoverRedirectToURL: redirect to the specified URL;</li>
        /// <li> FailoverCustomResponsePage: Use a custom response page.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Origin server address, divided into the following scenarios based on the value of Mode:
        /// <li>When Mode = FailoverToHost, fill in an IPV4 address, an IPV6 address, or a domain name;</li>
        /// <li>When Mode = FailoverToCOS, fill in the access domain name of the COS bucket;</li>
        /// <li>When Mode = FailoverToS3CompatibleObjectStorage, fill in the access domain name of the S3 bucket.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration. This parameter is required when Mode is FailoverToHost. Valid values:
        /// <li>http: use HTTP protocol;</li>
        /// <li>https: Use HTTPS protocol;</li>
        /// <li>follow: follow protocol.</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin-pull port. Value range: 1–65535. This parameter is required when the origin-pull protocol OriginProtocol is http or follow.
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin-pull port, in the range of 1–65535. This parameter is required when OriginProtocol is https or follow.
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// Host Header rewrite configuration for origin-pull.
        /// </summary>
        [JsonProperty("UpstreamHostHeader")]
        public HostHeaderParameters UpstreamHostHeader{ get; set; }

        /// <summary>
        /// Origin-pull URL rewrite configuration.
        /// </summary>
        [JsonProperty("UpstreamURLRewrite")]
        public UpstreamURLRewriteParameters UpstreamURLRewrite{ get; set; }

        /// <summary>
        /// Origin-pull request parameter configuration.
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// HTTP/2 origin-pull configuration parameter.
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. This parameter is required when the origin server type Mode is FailoverToCOS or FailoverToS3CompatibleObjectStorage. Valid values:
        /// <li>on: Enable private authentication;</li>
        /// <li>off: Disable private authentication.</li>
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when Mode = FailoverToS3CompatibleObjectStorage and PrivateAccess = on.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public OriginPrivateParameters PrivateParameters{ get; set; }

        /// <summary>
        /// Redirect target URL. This parameter is required when Mode is FailoverRedirectToURL.
        /// </summary>
        [JsonProperty("RedirectURL")]
        public string RedirectURL{ get; set; }

        /// <summary>
        /// page ID. This parameter is required when Mode is FailoverCustomResponsePage.
        /// </summary>
        [JsonProperty("ResponsePageId")]
        public string ResponsePageId{ get; set; }

        /// <summary>
        /// status code. This parameter is required when Mode is FailoverRedirectToURL or FailoverCustomResponsePage. Valid values:
        /// <li>When Mode = FailoverRedirectToURL, the parameter value is one of 301, 302, 303, 307, 308;</li>
        /// <li>When Mode = FailoverCustomResponsePage, the parameter value is one of 400, 403, 404, 405, 414, 416, 451, 500, 501, 502, 503, 504.</li>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HTTPOriginPort", this.HTTPOriginPort);
            this.SetParamSimple(map, prefix + "HTTPSOriginPort", this.HTTPSOriginPort);
            this.SetParamObj(map, prefix + "UpstreamHostHeader.", this.UpstreamHostHeader);
            this.SetParamObj(map, prefix + "UpstreamURLRewrite.", this.UpstreamURLRewrite);
            this.SetParamObj(map, prefix + "UpstreamRequestParameters.", this.UpstreamRequestParameters);
            this.SetParamObj(map, prefix + "UpstreamHTTP2Parameters.", this.UpstreamHTTP2Parameters);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "RedirectURL", this.RedirectURL);
            this.SetParamSimple(map, prefix + "ResponsePageId", this.ResponsePageId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
        }
    }
}

