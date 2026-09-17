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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Primary origin server list.
        /// When modifying the primary origin server, fill in the corresponding OriginType at the same time.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type. The input parameter supports the following types:
        /// <li>domain: Domain type;</li>
        /// <li>ip: IP list as the origin server;</li>
        /// <li>third_party: third-party object storage origin.</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Host header when accessing the primary origin server. If not filled in, it defaults to the acceleration domain name.
        /// When the origin server type is COS, the ServerName field is required.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration:
        /// <li>http: Force HTTP origin-pull.</li>
        /// <li>follow: follow protocol for origin-pull;</li>
        /// <li>`https`: Switch HTTP requests to HTTPS. This only supports port 443 on the origin server.</li>
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// Backup origin list.
        /// When modifying the standby origin server, fill in the corresponding OriginType at the same time.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Secondary origin type. Input supports the following types:
        /// <li>domain: Domain type;</li>
        /// <li>ip: IP list as the origin server;</li>
        /// <li>third_party: third-party object storage origin.</li>
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BackupServerName")]
        public string BackupServerName{ get; set; }

        /// <summary>
        /// Object storage origin service vendor. Required when the origin server type is third-party object storage origin (third_party). Optional values include:
        /// <li>aws_s3:AWS S3;</li>
        /// <li>ali_oss: Alibaba Cloud OSS;</li>
        /// <li>hw_obs: Huawei OBS;</li>
        /// <li>others: other vendor's object storage. Only object storage compatible with the AWS signature algorithm is supported, such as Tencent Cloud COS.</li>
        /// </summary>
        [JsonProperty("OriginCompany")]
        public string OriginCompany{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "BackupOriginType", this.BackupOriginType);
            this.SetParamSimple(map, prefix + "BackupServerName", this.BackupServerName);
            this.SetParamSimple(map, prefix + "OriginCompany", this.OriginCompany);
        }
    }
}

