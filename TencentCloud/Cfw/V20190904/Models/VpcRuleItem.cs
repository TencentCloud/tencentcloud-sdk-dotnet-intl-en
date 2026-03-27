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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcRuleItem : AbstractModel
    {
        
        /// <summary>
        /// Access source example:
        /// 
        /// net: IP/CIDR (192.168.0.2)
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Access source type, which can be: net
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Access destination example:
        /// 
        /// net: IP/CIDR (192.168.0.2)
        /// 
        /// domain: domain name rules, for example *.qq.com
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// Access destination type, which can be: net, domain, dnsparse
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// Protocol, optional values:
        /// 
        /// TCP
        /// 
        /// UDP
        /// 
        /// ICMP
        /// 
        /// ANY
        /// 
        /// HTTP
        /// 
        /// HTTPS
        /// 
        /// HTTP/HTTPS
        /// 
        /// SMTP
        /// 
        /// SMTPS
        /// 
        /// SMTP/SMTPS
        /// 
        /// FTP
        /// 
        /// DNS
        /// 
        /// TLS/SSL
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// How traffic set in the access control policy passes through CFW. Values:
        /// 
        /// accept: allow
        /// 
        /// drop: deny
        /// 
        /// log: observe
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Access control policy ports. Values:
        /// 
        /// -1/-1: all ports
        /// 
        /// 80: port 80
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Rule order, where -1 indicates the lowest and 1 indicates the highest.
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// Rule status, where true indicates enabled and false indicates disabled.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// The scope of effect for the rule, specifying whether it applies between a specific pair of VPCs or across all VPCs.
        /// </summary>
        [JsonProperty("EdgeId")]
        public string EdgeId{ get; set; }

        /// <summary>
        /// The unique id corresponding to the rule. This field is ignored when adding a rule; when modifying the rule, the Uuid needs to be filled in. This parameter will be returned in query results.
        /// </summary>
        [JsonProperty("Uuid")]
        public long? Uuid{ get; set; }

        /// <summary>
        /// The hit count of the rule. This parameter does not need to be passed during CRUD operations and is mainly used for returning query result data.
        /// </summary>
        [JsonProperty("DetectedTimes")]
        public long? DetectedTimes{ get; set; }

        /// <summary>
        /// Description of the firewall between the pair of VPCs corresponding to EdgeId
        /// </summary>
        [JsonProperty("EdgeName")]
        public string EdgeName{ get; set; }

        /// <summary>
        /// Internal-use uuid, generally not used
        /// </summary>
        [JsonProperty("InternalUuid")]
        public long? InternalUuid{ get; set; }

        /// <summary>
        /// Rule deletion status: 1 indicates deleted; 0 indicates not deleted
        /// </summary>
        [JsonProperty("Deleted")]
        public long? Deleted{ get; set; }

        /// <summary>
        /// The firewall instance ID where the rule takes effect
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// Firewall name
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// beta task details
        /// </summary>
        [JsonProperty("BetaList")]
        public BetaInfoByACL[] BetaList{ get; set; }

        /// <summary>
        /// Port Protocol Group ID
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// Port Protocol Group Name
        /// </summary>
        [JsonProperty("ParamTemplateName")]
        public string ParamTemplateName{ get; set; }

        /// <summary>
        /// Access destination name
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// Access source name
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// Ip version, 0: IPv4, 1: IPv6, default is IPv4
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }

        /// <summary>
        /// Whether the rule is invalid, where 0 indicates a valid rule and 1 indicates an invalid rule, used in output parameters.
        /// </summary>
        [JsonProperty("Invalid")]
        public long? Invalid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "EdgeId", this.EdgeId);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "DetectedTimes", this.DetectedTimes);
            this.SetParamSimple(map, prefix + "EdgeName", this.EdgeName);
            this.SetParamSimple(map, prefix + "InternalUuid", this.InternalUuid);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamArrayObj(map, prefix + "BetaList.", this.BetaList);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "ParamTemplateName", this.ParamTemplateName);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
        }
    }
}

