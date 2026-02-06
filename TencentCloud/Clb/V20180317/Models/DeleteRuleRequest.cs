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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the CLB instance. You can call the [DescribeLoadBalancers](https://www.tencentcloud.com/document/product/214/30685?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// ID of the CLB instance listener. You can call the [DescribeListeners](https://www.tencentcloud.com/document/product/214/30686?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Array of ids of forwarding rules to be deleted, can be accessed through the [DescribeLoadBalancersDetail](https://www.tencentcloud.com/document/api/214/46916?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("LocationIds")]
        public string[] LocationIds{ get; set; }

        /// <summary>
        /// Domain name of the forwarding rule to be deleted. if it is multiple domains, you can specify any one of the domain name list. it can be accessed through the [DescribeLoadBalancersDetail](https://www.tencentcloud.com/document/api/214/46916?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Forwarding path of the forwarding rule to be deleted can be accessed through the DescribeLoadBalancersDetail api (https://www.tencentcloud.com/document/api/214/46916?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// A default domain name must be configured under the listener. when you need to delete the default domain name, you can specify another domain name as the new default domain name. if the new default domain name is multiple domains, you can specify any one of the domain name list. it can be accessed through the [DescribeListeners](https://www.tencentcloud.com/document/product/214/30686?from_cn_redirect=1) api.
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

