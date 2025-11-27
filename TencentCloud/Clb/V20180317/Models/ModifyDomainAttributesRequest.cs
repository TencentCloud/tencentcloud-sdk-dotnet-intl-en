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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDomainAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance. You can call the [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/214/30685?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// ID of the CLB instance listener. You can call the [DescribeListeners](https://www.tencentcloud.comom/document/product/214/30686?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Domain name (must be a domain name under a created forwarding rule). if it is multiple domains, you can specify any one of the domain name list. it can be accessed through the [DescribeListeners](https://www.tencentcloud.comom/document/product/214/30686?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// The one domain name to modify. `NewDomain` and `NewDomains` can not be both specified.
        /// </summary>
        [JsonProperty("NewDomain")]
        public string NewDomain{ get; set; }

        /// <summary>
        /// Certificate information of the domain name. It is only applicable to listeners with SNI enabled. `Certificate` and `MultiCertInfo` cannot be specified at the same time. 
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP/2. note that only HTTPS domain names support HTTP/2.
        /// True: enable HTTP2. false: disable HTTP2.
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// Whether to set as the default domain name. Note: Only one default domain name can be set under a listener.
        /// True: set as default domain name. false: do not set as default domain name.
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// Specifies whether QUIC is enabled. note that QUIC can only be enabled for HTTPS domains.
        /// True: enable QUIC. False: disable.
        /// </summary>
        [JsonProperty("Quic")]
        public bool? Quic{ get; set; }

        /// <summary>
        /// Specifies a new default domain name for the listener. This field is used when the original default domain name is disabled. If there are multiple domain names, specify one of them.
        /// </summary>
        [JsonProperty("NewDefaultServerDomain")]
        public string NewDefaultServerDomain{ get; set; }

        /// <summary>
        /// The new domain names to modify. `NewDomain` and `NewDomains` can not be both specified.
        /// </summary>
        [JsonProperty("NewDomains")]
        public string[] NewDomains{ get; set; }

        /// <summary>
        /// Certificate information related to the domain name. Note: This applies only to listeners with SNI enabled. Multiple server certificates with different algorithm types can be input simultaneously, but this parameter cannot be input together with the Certificate.
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "NewDomain", this.NewDomain);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Quic", this.Quic);
            this.SetParamSimple(map, prefix + "NewDefaultServerDomain", this.NewDefaultServerDomain);
            this.SetParamArraySimple(map, prefix + "NewDomains.", this.NewDomains);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
        }
    }
}

