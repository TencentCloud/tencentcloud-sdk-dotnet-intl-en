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
        /// Origin server failover type. Valid values:
        /// <li>FailoverToHost: Fail back to the specified IP/domain.</li>
        /// <li>FailoverToCOS: Fail back to Tencent Cloud COS;</li>
        /// <li>FailoverToS3CompatibleObjectStorage: Fail over to S3-compatible object storage;</li>
        /// <li> FailoverRedirectToURL: Redirect to the specified URL.</li>
        /// <li>FailoverCustomResponsePage: Use a custom response page.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Origin server address, divided into following scenarios based on the Mode value:
        /// <li>When Mode = FailoverToHost, specify an IPV4 address, an IPV6 address, or a domain name;</li>
        /// <li>When Mode = FailoverToCOS, specify the access domain name of the COS bucket;</li>
        /// <li>When Mode = FailoverToS3CompatibleObjectStorage, specify the access domain of the S3 bucket.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Protocol configuration. This parameter is required when Mode value is FailoverToHost. Valid values:
        /// <li>http: use HTTP protocol;</li>
        /// <li>https: Using HTTPS protocol;</li>
        /// <li>follow: protocol following.</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin port, value ranges from 1 to 65535. This parameter is required when the origin-pull protocol OriginProtocol is http or follow.
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin port, value ranges from 1–65535. This parameter is required when the origin-pull protocol OriginProtocol is https or follow.
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// Host Header rewrite configuration for origin-pull
        /// </summary>
        [JsonProperty("UpstreamHostHeader")]
        public HostHeaderParameters UpstreamHostHeader{ get; set; }

        /// <summary>
        /// Origin-pull URL rewrite configuration.
        /// </summary>
        [JsonProperty("UpstreamURLRewrite")]
        public UpstreamURLRewriteParameters UpstreamURLRewrite{ get; set; }

        /// <summary>
        /// Origin Requests parameter configuration.
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// HTTP2 origin-pull configuration parameters.
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// Specify whether access to the private object storage origin server is allowed. This parameter is required when the origin server type is FailoverToCOS or FailoverToS3CompatibleObjectStorage. Valid values:
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
        /// Redirect target URL. This parameter is required when Mode has a value of FailoverRedirectToURL.
        /// </summary>
        [JsonProperty("RedirectURL")]
        public string RedirectURL{ get; set; }

        /// <summary>
        /// Response page ID. This parameter is required when Mode value is FailoverCustomResponsePage.
        /// </summary>
        [JsonProperty("ResponsePageId")]
        public string ResponsePageId{ get; set; }

        /// <summary>
        /// Response status code. This parameter is required when Mode is a value of FailoverRedirectToURL or FailoverCustomResponsePage. Valid values:
        /// <li>When Mode = FailoverRedirectToURL, the parameter value is one of 301, 302, 303, 307, 308.</li>
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

