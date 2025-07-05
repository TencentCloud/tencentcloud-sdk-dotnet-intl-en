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

    public class AddAcRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// -1: lowest priority; 1: highest priority
        /// </summary>
        [JsonProperty("OrderIndex")]
        public string OrderIndex{ get; set; }

        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// accept: allow
        /// drop: deny
        /// log: observe
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// The traffic direction for access control rules. Valid values:
        /// in: incoming traffic access control
        /// out: outgoing traffic access control
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// The description of access control rules.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The type of source address in access control rules. Valid values:
        /// net: source IP or range (IP or CIDR)
        /// location: source region
        /// template: CFW address template
        /// instance: instance ID
        /// vendor: Cloud vendor
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// The source address in the access control policy. 
        /// When `SourceType` is `net`, `SourceContent` is the source IP or CIDR block.
        /// For example: 1.1.1.0/24
        /// 
        /// When `SourceType` is `template`, `SourceContent` must be the source address template ID.
        /// 
        /// When `SourceType` is `location`, `SourceContent` is the source region. 
        /// For example, ["BJ11", "ZB"]
        /// 
        /// When `SourceType` is `instance`, `SourceContent` is the public IP of the instance.
        /// For example, ins-xxxxx
        /// 
        /// When `SourceType` is `vendor`, `SourceContent` is the cloud service provider.
        /// Values: `aws`, `huawei`, `tencent`, `aliyun`, `azure` and `all`. 
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// The type of destination address in access control rules. Valid values:
        /// net: destination IP or range (IP or CIDR)
        /// location: source region
        /// template: CFW address template
        /// instance: instance ID
        /// vendor: Cloud vendor
        /// domain: Domain name or IP.
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// The destination address in the access control policy. 
        /// When `DestType` is `net`, `DestContent` is the destination IP or CIDR block.
        /// For example: 1.1.1.0/24
        /// 
        /// When `DestType` is `template`, `DestContent` is the destination address template ID.
        /// 
        /// When `DestType` is `location`, `DestContent` is the destination region. 
        /// For example, ["BJ11", "ZB"]
        /// 
        /// When `DestType` is `instance`, `DestContent` is the public IP of the instance.
        /// For example, ins-xxxxx
        /// 
        /// When `DestType` is `domain`, `DestContent` is the domain name associated with the instance.
        /// For example, *.qq.com
        /// 
        /// When `DestType`, `DestContent` is the selected cloud service provider.
        /// Values: `aws`, `huawei`, `tencent`, `aliyun`, `azure` and `all`. 
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// The port to apply access control rules. Valid values:
        /// -1/-1: all ports
        /// 80,443: 80 or 443
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// The protocol type of traffic in access control rules. Valid value: TCP. Only TCP is supported for edge firewall rules. If this parameter is not specified, it defaults to TCP.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The Layer 7 protocol. Valid values:
        /// HTTP/HTTPS
        /// TLS/SSL
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Indicates whether to enable the rules. Default: enable. Valid values:
        /// true: enable; false: disable
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

