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

    public class DescribeEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Page number of the current page displayed for query by page number.
        /// 
        /// 1 by default.
        /// </summary>
        [JsonProperty("PageNo")]
        public string PageNo{ get; set; }

        /// <summary>
        /// Maximum number of entries per page displayed for query by page number.
        /// 
        /// Maximum value: 50.
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// Source example:
        /// net: IP/CIDR (192.168.0.2)
        /// template: parameter template (ipm-dyodhpby)
        /// instance: asset instance (ins-123456)
        /// resourcegroup: asset group (/all groups/group 1/subgroup 1)
        /// tag: resource tag ({"Key":"tag key","Value":"tag value"})
        /// region: region (ap-gaungzhou)
        /// Wildcards are supported.
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Destination example:
        /// net: IP/CIDR (192.168.0.2)
        /// template: parameter template (ipm-dyodhpby)
        /// instance: asset instance (ins-123456)
        /// resourcegroup: asset group (/all groups/group 1/subgroup 1)
        /// tag: resource tag ({"Key":"tag key","Value":"tag value"})
        /// region: region (ap-gaungzhou)
        /// Wildcards are supported.
        /// </summary>
        [JsonProperty("DestContent")]
        public string DestContent{ get; set; }

        /// <summary>
        /// Rule description. Wildcards are supported.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values:
        /// accept: allow
        /// drop: deny
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Indicates whether to enable the rules. Default: enable. Valid values:
        /// true: enable; false: disable
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// The port to apply access control rules. Valid values:
        /// -1/-1: all ports
        /// 80: port 80
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Protocol. TCP/UDP/ICMP/ANY
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Parameter template ID of port and protocol type; mutually exclusive with Protocol and Port
        /// </summary>
        [JsonProperty("ServiceTemplateId")]
        public string ServiceTemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "DestContent", this.DestContent);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceTemplateId", this.ServiceTemplateId);
        }
    }
}

