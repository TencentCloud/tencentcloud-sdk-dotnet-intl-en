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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Primary origin server list When modifying the origin server, you need to enter the corresponding OriginType. Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type The following types are supported for input parameters: <li> domain:domain；</li> <li>ip：IP address；</li> <li>third_party：third-party object storage origin.</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Host header used when accessing the primary origin server. If it is left empty, the acceleration domain name will be used by default.When the origin server type is object storage, the ServerName field is required.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration http: forced HTTP origin-pull follow: protocol follow origin-pull https: forced HTTPS origin-pull. This only supports origin server port 443 for origin-pull. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// Backup origin server list When modifying the backup origin server, you need to enter the corresponding BackupOriginType. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        ///  Backup origin server type, which supports the following types: <li>domain：Domain；</li> <li>ip：IP address；</li> <li>third_party：third-party object storage origin.</li>
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }

        /// <summary>
        /// Host header used when accessing the backup origin server. If it is left empty, the ServerName of primary origin server will be used by default. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BackupServerName")]
        public string BackupServerName{ get; set; }

        /// <summary>
        /// The object storage returns to the source vendor. It is required when the source site type is a third-party storage source site (third_party). The optional values include the following:<li>aws_s3：AWS S3;</li> <li>ali_oss：Alibaba Cloud OSS;</li> <li>hw_obs：Huawei OBS;</li> <li>others：Object storage from other vendors only supports object storage compatible with the AWS signature algorithm, such as Tencent Cloud COS.</li>
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

