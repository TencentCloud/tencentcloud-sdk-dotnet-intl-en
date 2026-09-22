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

    public class ModifyVodDomainConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, if they access resources in on-demand applications (whether the default application or a newly created application), this field must be filled in as the application ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/14046?from_cn_redirect=1">Referer hotlink protection</a> rule.</p>
        /// </summary>
        [JsonProperty("RefererAuthPolicy")]
        public RefererAuthPolicy RefererAuthPolicy{ get; set; }

        /// <summary>
        /// <p><a href="https://www.tencentcloud.com/document/product/266/14047?from_cn_redirect=1">Key hotlink protection</a> rule.</p>
        /// </summary>
        [JsonProperty("UrlSignatureAuthPolicy")]
        public UrlSignatureAuthPolicy UrlSignatureAuthPolicy{ get; set; }

        /// <summary>
        /// <p>QUIC configuration.</p>
        /// </summary>
        [JsonProperty("QUICConfig")]
        public DomainQUICConfig QUICConfig{ get; set; }

        /// <summary>
        /// <p>IP access restriction rule.</p>
        /// </summary>
        [JsonProperty("IPFilterPolicy")]
        public IPFilterPolicy IPFilterPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "RefererAuthPolicy.", this.RefererAuthPolicy);
            this.SetParamObj(map, prefix + "UrlSignatureAuthPolicy.", this.UrlSignatureAuthPolicy);
            this.SetParamObj(map, prefix + "QUICConfig.", this.QUICConfig);
            this.SetParamObj(map, prefix + "IPFilterPolicy.", this.IPFilterPolicy);
        }
    }
}

