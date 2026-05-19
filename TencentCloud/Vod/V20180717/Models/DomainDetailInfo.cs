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

    public class DomainDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Acceleration region information.</p>
        /// </summary>
        [JsonProperty("AccelerateAreaInfos")]
        public AccelerateAreaInfo[] AccelerateAreaInfos{ get; set; }

        /// <summary>
        /// <p>Deployment state. Valid values:</p><li>Online: Goes live.</li><li>Deploying: Deployment in progress.</li><li>Locked: Locked. When this state occurs, unable to perform deployment change on that domain name.</li>
        /// </summary>
        [JsonProperty("DeployStatus")]
        public string DeployStatus{ get; set; }

        /// <summary>
        /// <p>HTTPS configuration message.</p>
        /// </summary>
        [JsonProperty("HTTPSConfig")]
        public DomainHTTPSConfig HTTPSConfig{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/14047?from_cn_redirect=1">Key hotlink protection</a> configuration message.</p>
        /// </summary>
        [JsonProperty("UrlSignatureAuthPolicy")]
        public UrlSignatureAuthPolicy UrlSignatureAuthPolicy{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/14046?from_cn_redirect=1">Referer hotlink protection</a> configuration message.</p>
        /// </summary>
        [JsonProperty("RefererAuthPolicy")]
        public RefererAuthPolicy RefererAuthPolicy{ get; set; }

        /// <summary>
        /// <p>The time when the domain name is added to the Tencent Cloud VOD system.</p><li>Format according to ISO 8601 standard. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</li>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Domain name QUIC configuration message.</p>
        /// </summary>
        [JsonProperty("QUICConfig")]
        public DomainQUICConfig QUICConfig{ get; set; }

        /// <summary>
        /// <p>IP access restriction configuration message.</p>
        /// </summary>
        [JsonProperty("IPFilterPolicy")]
        public IPFilterPolicy IPFilterPolicy{ get; set; }

        /// <summary>
        /// <p>Domain type. Valid values: <li>VOD: Domain name distributed by using the VOD product;</li> <li>EdgeOne: Domain name distributed by using the EdgeOne product.</li></p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "AccelerateAreaInfos.", this.AccelerateAreaInfos);
            this.SetParamSimple(map, prefix + "DeployStatus", this.DeployStatus);
            this.SetParamObj(map, prefix + "HTTPSConfig.", this.HTTPSConfig);
            this.SetParamObj(map, prefix + "UrlSignatureAuthPolicy.", this.UrlSignatureAuthPolicy);
            this.SetParamObj(map, prefix + "RefererAuthPolicy.", this.RefererAuthPolicy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "QUICConfig.", this.QUICConfig);
            this.SetParamObj(map, prefix + "IPFilterPolicy.", this.IPFilterPolicy);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

