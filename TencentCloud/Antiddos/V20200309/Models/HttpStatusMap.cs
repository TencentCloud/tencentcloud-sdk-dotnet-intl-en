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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HttpStatusMap : AbstractModel
    {
        
        /// <summary>
        /// HTTP 2xx Forwarding status code
        /// </summary>
        [JsonProperty("SourceHttp2xx")]
        public float?[] SourceHttp2xx{ get; set; }

        /// <summary>
        /// HTTP 5xx Status code
        /// </summary>
        [JsonProperty("Http5xx")]
        public float?[] Http5xx{ get; set; }

        /// <summary>
        /// HTTP 5xx Forwarding status code
        /// </summary>
        [JsonProperty("SourceHttp5xx")]
        public float?[] SourceHttp5xx{ get; set; }

        /// <summary>
        /// HTTP 404 Forwarding status code
        /// </summary>
        [JsonProperty("SourceHttp404")]
        public float?[] SourceHttp404{ get; set; }

        /// <summary>
        /// HTTP 4xx Status code
        /// </summary>
        [JsonProperty("Http4xx")]
        public float?[] Http4xx{ get; set; }

        /// <summary>
        /// HTTP 4xx Forwarding status code
        /// </summary>
        [JsonProperty("SourceHttp4xx")]
        public float?[] SourceHttp4xx{ get; set; }

        /// <summary>
        /// HTTP 2xx Status code
        /// </summary>
        [JsonProperty("Http2xx")]
        public float?[] Http2xx{ get; set; }

        /// <summary>
        /// HTTP 404 Status code
        /// </summary>
        [JsonProperty("Http404")]
        public float?[] Http404{ get; set; }

        /// <summary>
        /// HTTP 3xx Forwarding status code
        /// </summary>
        [JsonProperty("SourceHttp3xx")]
        public float?[] SourceHttp3xx{ get; set; }

        /// <summary>
        /// HTTP 3xx Status code
        /// </summary>
        [JsonProperty("Http3xx")]
        public float?[] Http3xx{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SourceHttp2xx.", this.SourceHttp2xx);
            this.SetParamArraySimple(map, prefix + "Http5xx.", this.Http5xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp5xx.", this.SourceHttp5xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp404.", this.SourceHttp404);
            this.SetParamArraySimple(map, prefix + "Http4xx.", this.Http4xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp4xx.", this.SourceHttp4xx);
            this.SetParamArraySimple(map, prefix + "Http2xx.", this.Http2xx);
            this.SetParamArraySimple(map, prefix + "Http404.", this.Http404);
            this.SetParamArraySimple(map, prefix + "SourceHttp3xx.", this.SourceHttp3xx);
            this.SetParamArraySimple(map, prefix + "Http3xx.", this.Http3xx);
        }
    }
}

