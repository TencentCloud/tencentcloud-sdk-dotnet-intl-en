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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateBucketCORSOptRequest : AbstractModel
    {
        
        /// <summary>
        /// Allowed access source. For details, see [COS Documentation](https://intl.cloud.tencent.com/document/product/436/8279?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("AllowedOrigins")]
        public string[] AllowedOrigins{ get; set; }

        /// <summary>
        /// Allowed HTTP method(s). Multiple methods are allowed, including PUT, GET, POST, and HEAD. For details, see [COS Documentation](https://intl.cloud.tencent.com/document/product/436/8279?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public string[] AllowedMethods{ get; set; }

        /// <summary>
        /// Specifies the custom HTTP request headers that the browser is allowed to include in a CORS request. Wildcard (*) is supported, indicating allowing all headers (recommended). For details, see [COS Documentation](https://intl.cloud.tencent.com/document/product/436/8279?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("AllowedHeaders")]
        public string[] AllowedHeaders{ get; set; }

        /// <summary>
        /// Sets the validity duration for the CORS configuration (in second). For details, see [COS Documentation](https://intl.cloud.tencent.com/document/product/436/8279?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("MaxAgeSeconds")]
        public long? MaxAgeSeconds{ get; set; }

        /// <summary>
        /// CORS response header(s) that can be exposed to the browser, case-insensitive. If this parameter is not specified, the browser can access only simple response headers Cache-Control, Content-Type, Expires, and Last-Modified by default. For details, see [COS Documentation](https://intl.cloud.tencent.com/document/product/436/8279?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ExposeHeaders")]
        public string[] ExposeHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AllowedOrigins.", this.AllowedOrigins);
            this.SetParamArraySimple(map, prefix + "AllowedMethods.", this.AllowedMethods);
            this.SetParamArraySimple(map, prefix + "AllowedHeaders.", this.AllowedHeaders);
            this.SetParamSimple(map, prefix + "MaxAgeSeconds", this.MaxAgeSeconds);
            this.SetParamArraySimple(map, prefix + "ExposeHeaders.", this.ExposeHeaders);
        }
    }
}

