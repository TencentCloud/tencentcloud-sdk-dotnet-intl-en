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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSpartaProtectionInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// CNAME value
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Source IP address list
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// Certificate type
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// Certificate
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// Private key
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// SSL ID
        /// </summary>
        [JsonProperty("Sslid")]
        public string Sslid{ get; set; }

        /// <summary>
        /// Whether it is a CDN
        /// </summary>
        [JsonProperty("IsCdn")]
        public string IsCdn{ get; set; }

        /// <summary>
        /// Grayscale area list
        /// </summary>
        [JsonProperty("GrayAreas")]
        public string[] GrayAreas{ get; set; }

        /// <summary>
        /// Engine
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// HTTPS rewriting
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public string HttpsRewrite{ get; set; }

        /// <summary>
        /// upstreamType value
        /// </summary>
        [JsonProperty("UpstreamType")]
        public string UpstreamType{ get; set; }

        /// <summary>
        /// Value of upstreamDomain
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// Value of upstreamScheme
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// Whether it is HTTP2.
        /// </summary>
        [JsonProperty("IsHttp2")]
        public string IsHttp2{ get; set; }

        /// <summary>
        /// Whether it includes WebSocket
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public string IsWebsocket{ get; set; }

        /// <summary>
        /// LoadBalance information
        /// </summary>
        [JsonProperty("LoadBalance")]
        public string LoadBalance{ get; set; }

        /// <summary>
        /// Value of httpsUpstreamPort
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// Port information
        /// </summary>
        [JsonProperty("Ports")]
        public PortItem[] Ports{ get; set; }

        /// <summary>
        /// Whether it is grayscale
        /// </summary>
        [JsonProperty("IsGray")]
        public string IsGray{ get; set; }

        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Defense level: 100, 200, 300
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Whether to maintain a long connection with the origin server
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public string IsKeepAlive{ get; set; }

        /// <summary>
        /// 0: BGP; 1: Anycast.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Anycast")]
        public string Anycast{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "Sslid", this.Sslid);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamArraySimple(map, prefix + "GrayAreas.", this.GrayAreas);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "Anycast", this.Anycast);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

