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

    public class CustomEndpoint : AbstractModel
    {
        
        /// <summary>
        /// The address of the custom HTTP interface for real-time log delivery. Currently, only HTTP and HTTPS protocols are supported.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Specifies the custom SecretId for generating an encrypted signature. This parameter is required if the origin server needs authentication.
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// Specifies the custom SecretKey for generating an encrypted signature. This parameter is required if the origin server needs authentication.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// The type of data compression. Valid values:<li>gzip: gzip compression.</li>If this field is not filled in, compression is disabled.
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        /// <summary>
        /// The type of the application layer protocol used when POST requests log delivery. Valid values:
        /// <li>http: HTTP protocol;</li>
        /// <li>https: HTTPS protocol.</li>If this field is not filled in, the protocol type will be parsed from the URL field.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The custom request header carried during log delivery. If the header name you fill in is the default header carried by EdgeOne log delivery such as Content-Type, then the header value you fill in will override the default value. The header value supports referring to a single variable ${batchSize} to obtain the number of log entries included in each POST request.
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
        }
    }
}

