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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSPolicyCaseRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `bgp`: Anti-DDoS Pro (single IP); `bgp-multip`: Anti-DDoS Pro (multi-IP), `net`: Anti-DDoS Ultimate
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Policy scenario ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// Development platform. Valid values: [PC (PC client), MOBILE (mobile device), TV (TV), SERVER (server)]
        /// </summary>
        [JsonProperty("PlatformTypes")]
        public string[] PlatformTypes{ get; set; }

        /// <summary>
        /// Category. Valid values: [WEB (website), GAME (game), APP (application), OTHER (other)]
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// Application protocol. Valid values: [tcp (TCP protocol), udp (UDP protocol), icmp (ICMP protocol), all (other protocols)]
        /// </summary>
        [JsonProperty("AppProtocols")]
        public string[] AppProtocols{ get; set; }

        /// <summary>
        /// TCP start port. Value range: (0, 65535]
        /// </summary>
        [JsonProperty("TcpSportStart")]
        public string TcpSportStart{ get; set; }

        /// <summary>
        /// TCP end port. Value range: (0, 65535). It must be greater than or equal to the TCP start port
        /// </summary>
        [JsonProperty("TcpSportEnd")]
        public string TcpSportEnd{ get; set; }

        /// <summary>
        /// UDP start port. Value range: (0, 65535]
        /// </summary>
        [JsonProperty("UdpSportStart")]
        public string UdpSportStart{ get; set; }

        /// <summary>
        /// End UDP business port. Value range: (0, 65535). It must be greater than or equal to the start UDP business port
        /// </summary>
        [JsonProperty("UdpSportEnd")]
        public string UdpSportEnd{ get; set; }

        /// <summary>
        /// Whether there are customers outside Mainland China. Valid values: [no, yes]
        /// </summary>
        [JsonProperty("HasAbroad")]
        public string HasAbroad{ get; set; }

        /// <summary>
        /// Whether to actively initiate outbound TCP requests. Valid values: [no, yes]
        /// </summary>
        [JsonProperty("HasInitiateTcp")]
        public string HasInitiateTcp{ get; set; }

        /// <summary>
        /// Whether to actively initiate outbound UDP requests. Valid values: [no, yes]
        /// </summary>
        [JsonProperty("HasInitiateUdp")]
        public string HasInitiateUdp{ get; set; }

        /// <summary>
        /// Port that actively initiates TCP requests. Value range: (0, 65535]
        /// </summary>
        [JsonProperty("PeerTcpPort")]
        public string PeerTcpPort{ get; set; }

        /// <summary>
        /// Port that actively initiates UDP requests. Value range: (0, 65535]
        /// </summary>
        [JsonProperty("PeerUdpPort")]
        public string PeerUdpPort{ get; set; }

        /// <summary>
        /// Fixed feature code of TCP payload. String length limit: 512
        /// </summary>
        [JsonProperty("TcpFootprint")]
        public string TcpFootprint{ get; set; }

        /// <summary>
        /// Fixed feature code of UDP payload. String length limit: 512
        /// </summary>
        [JsonProperty("UdpFootprint")]
        public string UdpFootprint{ get; set; }

        /// <summary>
        /// Web business API URL
        /// </summary>
        [JsonProperty("WebApiUrl")]
        public string[] WebApiUrl{ get; set; }

        /// <summary>
        /// Minimum length of TCP business packet. Value range: (0, 1500)
        /// </summary>
        [JsonProperty("MinTcpPackageLen")]
        public string MinTcpPackageLen{ get; set; }

        /// <summary>
        /// Maximum length of TCP business packet. Value range: (0, 1500). It must be greater than or equal to the minimum length of TCP business packet
        /// </summary>
        [JsonProperty("MaxTcpPackageLen")]
        public string MaxTcpPackageLen{ get; set; }

        /// <summary>
        /// Minimum length of UDP business packet. Value range: (0, 1500)
        /// </summary>
        [JsonProperty("MinUdpPackageLen")]
        public string MinUdpPackageLen{ get; set; }

        /// <summary>
        /// Maximum length of UDP business packet. Value range: (0, 1500). It must be greater than or equal to the minimum length of UDP business packet
        /// </summary>
        [JsonProperty("MaxUdpPackageLen")]
        public string MaxUdpPackageLen{ get; set; }

        /// <summary>
        /// Whether there are VPN businesses. Valid values: [no, yes]
        /// </summary>
        [JsonProperty("HasVPN")]
        public string HasVPN{ get; set; }

        /// <summary>
        /// TCP business port list. Individual ports and port ranges are supported, which should be in string type, such as 80,443,700-800,53,1000-3000
        /// </summary>
        [JsonProperty("TcpPortList")]
        public string TcpPortList{ get; set; }

        /// <summary>
        /// UDP business port list. Individual ports and port ranges are supported, which should be in string type, such as 80,443,700-800,53,1000-3000
        /// </summary>
        [JsonProperty("UdpPortList")]
        public string UdpPortList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamArraySimple(map, prefix + "PlatformTypes.", this.PlatformTypes);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamArraySimple(map, prefix + "AppProtocols.", this.AppProtocols);
            this.SetParamSimple(map, prefix + "TcpSportStart", this.TcpSportStart);
            this.SetParamSimple(map, prefix + "TcpSportEnd", this.TcpSportEnd);
            this.SetParamSimple(map, prefix + "UdpSportStart", this.UdpSportStart);
            this.SetParamSimple(map, prefix + "UdpSportEnd", this.UdpSportEnd);
            this.SetParamSimple(map, prefix + "HasAbroad", this.HasAbroad);
            this.SetParamSimple(map, prefix + "HasInitiateTcp", this.HasInitiateTcp);
            this.SetParamSimple(map, prefix + "HasInitiateUdp", this.HasInitiateUdp);
            this.SetParamSimple(map, prefix + "PeerTcpPort", this.PeerTcpPort);
            this.SetParamSimple(map, prefix + "PeerUdpPort", this.PeerUdpPort);
            this.SetParamSimple(map, prefix + "TcpFootprint", this.TcpFootprint);
            this.SetParamSimple(map, prefix + "UdpFootprint", this.UdpFootprint);
            this.SetParamArraySimple(map, prefix + "WebApiUrl.", this.WebApiUrl);
            this.SetParamSimple(map, prefix + "MinTcpPackageLen", this.MinTcpPackageLen);
            this.SetParamSimple(map, prefix + "MaxTcpPackageLen", this.MaxTcpPackageLen);
            this.SetParamSimple(map, prefix + "MinUdpPackageLen", this.MinUdpPackageLen);
            this.SetParamSimple(map, prefix + "MaxUdpPackageLen", this.MaxUdpPackageLen);
            this.SetParamSimple(map, prefix + "HasVPN", this.HasVPN);
            this.SetParamSimple(map, prefix + "TcpPortList", this.TcpPortList);
            this.SetParamSimple(map, prefix + "UdpPortList", this.UdpPortList);
        }
    }
}

