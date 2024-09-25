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

    public class DomainInfo : AbstractModel
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
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// CNAME Address
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Instance type of the domain name.
        /// sparta-waf: SaaS WAF instance
        /// clb-waf: CLB WAF instance
        /// cdc-clb-waf: CLB WAF instances in the CDC environment
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// Region
        /// "Toronto": "ca"
        /// "Guangzhou": "gz"
        /// "Chengdu": "cd"
        /// "Fuzhou": "fzec"
        /// "Shenzhen": "szx"
        /// "India": "in"
        /// "Jinan": "jnec"
        /// "Chongqing": "cq"
        /// "Tianjin": "tsn"
        /// "Northeast Europe": "ru"
        /// "Nanjing": "nj"
        /// "Silicon Valley, USA": "usw"
        /// "Thailand": "th"
        /// "Guangzhou Open": "gzopen"
        /// "Shenzhen Finance": "szjr"
        /// "Frankfurt": "de"
        /// "Japan": "jp"
        /// "Virginia": "use"
        /// "Beijing": "bj"
        /// "Hong Kong (China)": "hk"
        /// "Hangzhou": "hzec"
        /// "Beijing Finance": "bjjr"
        /// "Shanghai Finance": "shjr"
        /// "Taipei (China)": "tpe"
        /// "Seoul": "kr"
        /// "Shanghai": "sh"
        /// "Singapore": "sg"
        /// "Qingyuan": "qy"
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Access log switch status
        /// 0: disabled
        /// 1: enabled
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// CLB WAF usage mode
        /// 0: image mode
        /// 1: cleaning mode
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// WAF switch status
        /// 0: disabled
        /// 1: enabled
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Rule engine protection mode
        /// 0: observation mode
        /// 1: interception mode
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Joint status of rule engine and AI engine protection modes.
        /// 1: initial status: interception for the rule engine and disabled for the AI engine
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
        /// Sandbox cluster origin-pull outbound IP list
        /// </summary>
        [JsonProperty("CCList")]
        public string[] CCList{ get; set; }

        /// <summary>
        /// Production cluster origin-pull outbound IP list
        /// </summary>
        [JsonProperty("RsList")]
        public string[] RsList{ get; set; }

        /// <summary>
        /// Service port configuration
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// CLB-related configuration
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancerPackageNew[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// LB listener status of the domain name protected by CLB WAF0: Operation successful.
        /// 4: The LB is being bound.
        /// 6: The LB is being unbound.
        /// 7: Failed to unbind the LB.
        /// 8: Failed to bind the LB.
        /// 10: Internal error.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// IPv6 switch status.
        /// 0: disabled
        /// 1: enabled
        /// </summary>
        [JsonProperty("Ipv6Status")]
        public long? Ipv6Status{ get; set; }

        /// <summary>
        /// Bot switch status.
        /// 0: disabled
        /// 1: disabled
        /// 2: enabled
        /// 3: enabled
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// Instance version information.
        /// 101: Small and Micro Agile Edition
        /// 102: Small and Micro Ultra-light Edition
        /// 2: Advanced Edition
        /// 3: Enterprise Edition
        /// 4: Ultimate Edition
        /// 6: Exclusive Edition
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// Shipping status of CLS.
        /// 0: disabled
        /// 1: enabled
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// Shipping status of CKafka.
        /// 0: disabled
        /// 1: enabled
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }

        /// <summary>
        /// Cluster information accessed by the CDC instance domain name, which can be ignored for non-CDC instances.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CdcClusters")]
        public string CdcClusters{ get; set; }

        /// <summary>
        /// API security switch status.
        /// 0: disabled
        /// 1: enabled
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiStatus")]
        public long? ApiStatus{ get; set; }

        /// <summary>
        /// Application-based CLB type. The default value is clb.
        /// clb: layer-7 CLB
        /// apisix: APISIX gateway
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlbType")]
        public string AlbType{ get; set; }

        /// <summary>
        /// Security group status.
        /// 0: not display
        /// 1: non-Tencent Cloud origin server
        /// 2: Security group binding failed.
        /// 3: security groups changed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SgState")]
        public long? SgState{ get; set; }

        /// <summary>
        /// Detailed Explanation of Security Group Status
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SgDetail")]
        public string SgDetail{ get; set; }

        /// <summary>
        /// Domain name cloud environment. hybrid: hybrid cloud domain name
        /// public: public cloud domain name
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
        /// SaaS WAF origin server IP list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// SaaS WAF origin server domain name list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamDomainList")]
        public string[] UpstreamDomainList{ get; set; }

        /// <summary>
        /// Security group ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SgID")]
        public string SgID{ get; set; }

        /// <summary>
        /// CLB WAF access status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessStatus")]
        public long? AccessStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamArraySimple(map, prefix + "CCList.", this.CCList);
            this.SetParamArraySimple(map, prefix + "RsList.", this.RsList);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Ipv6Status", this.Ipv6Status);
            this.SetParamSimple(map, prefix + "BotStatus", this.BotStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "PostCLSStatus", this.PostCLSStatus);
            this.SetParamSimple(map, prefix + "PostCKafkaStatus", this.PostCKafkaStatus);
            this.SetParamSimple(map, prefix + "CdcClusters", this.CdcClusters);
            this.SetParamSimple(map, prefix + "ApiStatus", this.ApiStatus);
            this.SetParamSimple(map, prefix + "AlbType", this.AlbType);
            this.SetParamSimple(map, prefix + "SgState", this.SgState);
            this.SetParamSimple(map, prefix + "SgDetail", this.SgDetail);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamArraySimple(map, prefix + "UpstreamDomainList.", this.UpstreamDomainList);
            this.SetParamSimple(map, prefix + "SgID", this.SgID);
            this.SetParamSimple(map, prefix + "AccessStatus", this.AccessStatus);
        }
    }
}

