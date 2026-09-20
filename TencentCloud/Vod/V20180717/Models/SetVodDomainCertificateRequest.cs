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

    public class SetVodDomainCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Operation type of this API call. Available values:</p><li>Set: set the certificate required for setting domain HTTPS;</li><li>Clear: clear domain HTTPS configuration. After clearance, the domain cannot support HTTPS access.</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, if they access resources in on-demand applications (whether the default application or a newly created application), they must fill in this field with the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>ID of the certificate uploaded to <a href="/document/product/400/7572">Tencent Cloud SSL</a>. This field is not required when clearing domain HTTPS configuration.</p>
        /// </summary>
        [JsonProperty("CertID")]
        public string CertID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "CertID", this.CertID);
        }
    }
}

