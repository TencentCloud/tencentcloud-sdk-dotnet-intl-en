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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name of the protocol port
        /// </summary>
        [JsonProperty("ServiceTemplateName")]
        public string ServiceTemplateName{ get; set; }

        /// <summary>
        /// Supported ports inlcude single port, multiple ports, consecutive ports and all ports. Supported protocols include TCP, UDP, ICMP and GRE. Either Services or ServicesExtra is required.
        /// </summary>
        [JsonProperty("Services")]
        public string[] Services{ get; set; }

        /// <summary>
        /// You can add remarks. Supported ports include single port, multiple ports, consecutive ports and all ports. Supported protocols include TCP, UDP, ICMP and GRE. Either Services or ServicesExtra is required.
        /// </summary>
        [JsonProperty("ServicesExtra")]
        public ServicesInfo[] ServicesExtra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceTemplateName", this.ServiceTemplateName);
            this.SetParamArraySimple(map, prefix + "Services.", this.Services);
            this.SetParamArrayObj(map, prefix + "ServicesExtra.", this.ServicesExtra);
        }
    }
}

