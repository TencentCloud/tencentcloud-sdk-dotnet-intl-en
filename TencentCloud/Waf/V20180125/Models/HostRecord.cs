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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostRecord : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Unique domain name ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// Primary Domain, empty upon input
        /// </summary>
        [JsonProperty("MainDomain")]
        public string MainDomain{ get; set; }

        /// <summary>
        /// Rule engine protection mode
        /// 0: observation mode
        /// 1: interception mode
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Binding relationship between WAF and CLB
        /// 0: unbound
        /// 1: bound
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Domain name listener status of CLB WAF
        /// 0: operation successful
        /// 4: CLB instance binding in progress
        /// 6: CLB instance unbinding in progress
        /// 7: CLB instance unbinding failed
        /// 8: CLB instance binding failed
        /// 10: internal error
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// Status of the rule engine and AI engine
        /// 1: initial status. Interception for the rule engine and disabled for the AI engine.
        /// 10: observation for the rule engine and disabled for the AI engine
        /// 11: observation for both the rule engine and AI engine
        /// 12: observation for the rule engine and interception for the AI engine
        /// 20: interception for the rule engine and disabled for the AI engine
        /// 21: interception for the rule engine and observation for the AI engine
        /// 22: interception for both the rule engine and AI engine
        /// </summary>
        [JsonProperty("Engine")]
        public ulong? Engine{ get; set; }

        /// <summary>
        /// Whether a layer-7 proxy service is deployed before WAF. 0: No proxy service deployed; 1: Proxy service deployed, and WAF will use XFF to obtain the client IP address; 2: Proxy service deployed, and WAF will use remote_addr to obtain the client IP address; 3: Proxy service deployed, and WAF will use the custom header in ip_headers to obtain the client IP address.
        /// </summary>
        [JsonProperty("IsCdn")]
        public ulong? IsCdn{ get; set; }

        /// <summary>
        /// List of the information on the bound CLB instance
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancer[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// Region of the CLB instance bound to the domain name. Separate multiple regions by commas.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance type of the domain name. For CLB WAF, the value is "clb-waf".
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// Traffic mode of domain names protected by CLB WAF
        /// 1: cleaning mode
        /// 0: mirror mode
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// Whether to enable access logging
        /// 1: enable
        /// 0: disable
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// Protection Level, Optional Values: 100, 200, 300
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// List of CDC clusters to which the domain name needs to be delivered. Specify this parameter for CDC scenes only.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string[] CdcClusters{ get; set; }

        /// <summary>
        /// Application CLB type. Default value: clb. 
        /// clb: layer-7 CLB
        /// tsegw: Tencent Cloud API Gateway
        /// scf: Tencent Cloud Serverless
        /// apisix: Other Tencent Cloud Gateway. eg: APISIX gateway
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// IsCdn=3 required for this parameter, indicates custom header
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// Rule engine type
        /// 1: menshen
        /// 2: tiga
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EngineType")]
        public long? EngineType{ get; set; }

        /// <summary>
        /// Cloud type
        /// public: public cloud
        /// private: private cloud
        /// hybrid: hybrid cloud
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloudType")]
        public string CloudType{ get; set; }

        /// <summary>
        /// Domain name remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "MainDomain", this.MainDomain);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "CdcClusters.", this.CdcClusters);
            this.SetParamSimple(map, prefix + "AlbType", this.AlbType);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

