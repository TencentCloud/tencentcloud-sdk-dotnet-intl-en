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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongRoutePreview : AbstractModel
    {
        
        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// Service name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// None.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// None.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// None.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("Protocols")]
        public string[] Protocols{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("PreserveHost")]
        public bool? PreserveHost{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("HttpsRedirectStatusCode")]
        public long? HttpsRedirectStatusCode{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("StripPath")]
        public bool? StripPath{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Is mandatory HTTPS enabled?
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForceHttps")]
        [System.Obsolete]
        public bool? ForceHttps{ get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// Destination Port
        /// </summary>
        [JsonProperty("DestinationPorts")]
        public ulong?[] DestinationPorts{ get; set; }

        /// <summary>
        /// Headers of the route
        /// </summary>
        [JsonProperty("Headers")]
        public KVMapping[] Headers{ get; set; }

        /// <summary>
        /// Whether to cache the request body, default true
        /// </summary>
        [JsonProperty("RequestBuffering")]
        public bool? RequestBuffering{ get; set; }

        /// <summary>
        /// Whether to cache response body, default true
        /// </summary>
        [JsonProperty("ResponseBuffering")]
        public bool? ResponseBuffering{ get; set; }

        /// <summary>
        /// Regular Priority
        /// </summary>
        [JsonProperty("RegexPriority")]
        public long? RegexPriority{ get; set; }

        /// <summary>
        /// querystring parameter
        /// </summary>
        [JsonProperty("QueryStringParameters")]
        public KVMapping[] QueryStringParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArraySimple(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "PreserveHost", this.PreserveHost);
            this.SetParamSimple(map, prefix + "HttpsRedirectStatusCode", this.HttpsRedirectStatusCode);
            this.SetParamSimple(map, prefix + "StripPath", this.StripPath);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ForceHttps", this.ForceHttps);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamArraySimple(map, prefix + "DestinationPorts.", this.DestinationPorts);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "RequestBuffering", this.RequestBuffering);
            this.SetParamSimple(map, prefix + "ResponseBuffering", this.ResponseBuffering);
            this.SetParamSimple(map, prefix + "RegexPriority", this.RegexPriority);
            this.SetParamArrayObj(map, prefix + "QueryStringParameters.", this.QueryStringParameters);
        }
    }
}

