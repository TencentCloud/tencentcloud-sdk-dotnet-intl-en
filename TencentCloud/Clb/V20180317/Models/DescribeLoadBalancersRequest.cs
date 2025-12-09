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

    public class DescribeLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance IDs. There can be up to 20 IDs.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// CLB instance network type:
        /// OPEN: public network; INTERNAL: private network.
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// CLB instance type. 1: generic CLB instance; 0: classic CLB instance
        /// </summary>
        [JsonProperty("Forward")]
        public long? Forward{ get; set; }

        /// <summary>
        /// Specifies the name of the clb instance. fuzzy query is supported.
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// Tencent cloud assigns a domain name to the cloud load balancer instance. fuzzy query is supported.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// VIP address of a CLB instance (there can be multiple addresses)
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// Public IPs of the backend services bound with the load balancer. Only the public IPs of CVMs are supported now.
        /// </summary>
        [JsonProperty("BackendPublicIps")]
        public string[] BackendPublicIps{ get; set; }

        /// <summary>
        /// Private IPs of the backend services bound with the load balancer. Only the private IPs of CVMs are supported now.
        /// </summary>
        [JsonProperty("BackendPrivateIps")]
        public string[] BackendPrivateIps{ get; set; }

        /// <summary>
        /// Data offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned CLB instances. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Sorting parameter. supports the following fields:.
        /// - LoadBalancerName
        /// - CreateTime
        /// - Domain
        /// - LoadBalancerType
        /// 
        /// Defaults to CreateTime.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 1 for descending, 0 for ascending, defaults to 1, sorted by creation time in descending order.
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// Specifies the fuzzy search field for fuzzy matching the name, domain name, VIP address, or ID of a cloud load balancer instance.
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Project ID of the cloud load balancer instance. you can call the [DescribeProject](https://www.tencentcloud.comom/document/api/651/78725?from_cn_redirect=1) api to obtain the ID. defaults to all projects if not passed.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Whether a CLB instance is bound to a real server. 0: no; 1: yes; -1: query all.
        /// </summary>
        [JsonProperty("WithRs")]
        public long? WithRs{ get; set; }

        /// <summary>
        /// Specifies the unique vpc ID of the load balancing instance, such as vpc-bhqkbhdx. you can call the [DescribeVpcs](https://www.tencentcloud.comom/document/api/215/15778?from_cn_redirect=1) api to obtain it.
        /// Searches for cloud load balancer of basic network type. allows input '0'.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Security group ID, such as sg-m1cc****, can be obtained through the API [DescribeSecurityGroups](https://www.tencentcloud.comom/document/product/215/15808?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// Primary availability zone ID, such as 100001 (corresponding to Guangzhou Zone 1). You can obtain the list of availability zones through [DescribeZones](https://intl.cloud.tencent.com/document/product/213/15707?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// Each request can have up to 10 `Filters` and 100 `Filter.Values`. Detailed filter conditions:
        /// <li> internet-charge-type - Type: String - Required: No - Filter by CLB network billing mode, including `TRAFFIC_POSTPAID_BY_HOUR`</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Specifies the expanded fields to return. not specified, expanded fields do not return by default. supported expanded fields are as follows:.
        /// <Li>TargetCount: specifies the number of real servers bound to it.</li>.
        /// </summary>
        [JsonProperty("AdditionalFields")]
        public string[] AdditionalFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamArraySimple(map, prefix + "BackendPublicIps.", this.BackendPublicIps);
            this.SetParamArraySimple(map, prefix + "BackendPrivateIps.", this.BackendPrivateIps);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WithRs", this.WithRs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "AdditionalFields.", this.AdditionalFields);
        }
    }
}

