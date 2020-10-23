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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Array of IDs of the forwarding rules to be deleted
        /// </summary>
        [JsonProperty("LocationIds")]
        public string[] LocationIds{ get; set; }

        /// <summary>
        /// Domain name of the forwarding rule to be deleted. This parameter does not take effect if LocationIds is specified
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Forwarding path of the forwarding rule to be deleted. This parameter does not take effect if LocationIds is specified
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// A listener must be configured with a default domain name. If you need to delete the default domain name, you can specify another one as the new default domain name.
        /// </summary>
        [JsonProperty("NewDefaultServerDomain")]
        public string NewDefaultServerDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArraySimple(map, prefix + "LocationIds.", this.LocationIds);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "NewDefaultServerDomain", this.NewDefaultServerDomain);
        }
    }
}

