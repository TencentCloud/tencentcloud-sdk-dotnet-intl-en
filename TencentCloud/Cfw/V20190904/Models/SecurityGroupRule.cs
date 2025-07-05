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

    public class SecurityGroupRule : AbstractModel
    {
        
        /// <summary>
        /// Source example:
        /// net: IP/CIDR (192.168.0.2)
        /// template: parameter template (ipm-dyodhpby)
        /// instance: asset instance (ins-123456)
        /// resourcegroup: asset group (/all groups/group 1/subgroup 1)
        /// tag: resource tag ({"Key":"tag key","Value":"tag value"})
        /// region: region (ap-gaungzhou)
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Access source type. Valid values: net|template|instance|resourcegroup|tag|region
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Destination example:
        /// net: IP/CIDR (192.168.0.2)
        /// template: parameter template (ipm-dyodhpby)
        /// instance: asset instance (ins-123456)
        /// resourcegroup: asset group (/all groups/group 1/subgroup 1)
        /// tag: resource tag ({"Key":"tag key","Value":"tag value"})
        /// region: region (ap-gaungzhou)
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// Access destination type. Valid values: net|template|instance|resourcegroup|tag|region
        /// </summary>
        [JsonProperty("DestType")]
        public string DestType{ get; set; }

        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// accept: allow
        /// drop: deny
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Rule priority. -1: lowest; 1: highest
        /// </summary>
        [JsonProperty("OrderIndex")]
        public string OrderIndex{ get; set; }

        /// <summary>
        /// Protocol. TCP/UDP/ICMP/ANY
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The port to apply access control rules. Valid values:
        /// -1/-1: all ports
        /// 80: port 80
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Parameter template ID of port and protocol type; mutually exclusive with Protocol and Port
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }

        /// <summary>
        /// The unique ID of the rule
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Rule status. true: enabled; false: disabled
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "DestType", this.DestType);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

