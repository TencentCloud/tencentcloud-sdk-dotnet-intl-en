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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// Certificate download address
        /// </summary>
        [JsonProperty("CertDownloadUrl")]
        public string CertDownloadUrl{ get; set; }

        /// <summary>
        /// Expiration time of the certificate download address
        /// </summary>
        [JsonProperty("UrlExpiredTime")]
        public string UrlExpiredTime{ get; set; }

        /// <summary>
        /// SSL configuration status of an instance. Valid values: `true` (enable), `false` (disable).
        /// </summary>
        [JsonProperty("SSLConfig")]
        public bool? SSLConfig{ get; set; }

        /// <summary>
        /// Whether the instance supports SSL. Valid values: `true` (Yes. When minor version is upgraded.), `false` (No).
        /// </summary>
        [JsonProperty("FeatureSupport")]
        public bool? FeatureSupport{ get; set; }

        /// <summary>
        /// SSL configuration status. Valid values: `1`(Configuring), `2` (Configured).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertDownloadUrl", this.CertDownloadUrl);
            this.SetParamSimple(map, prefix + "UrlExpiredTime", this.UrlExpiredTime);
            this.SetParamSimple(map, prefix + "SSLConfig", this.SSLConfig);
            this.SetParamSimple(map, prefix + "FeatureSupport", this.FeatureSupport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

