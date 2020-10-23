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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceListResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of records
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// Resource record list. Valid values of `key`:
        /// "Key": "CreateTime" - resource instance purchase time
        /// "Key": "Region" - resource instance region
        /// "Key": "BoundIP" - IP bound to single IP instance
        /// "Key": "Id" - resource instance ID
        /// "Key": "CCEnabled" - CC protection status of resource instance
        /// "Key": "DDoSThreshold" - DDoS cleansing threshold of resource instance	
        /// "Key": "BoundStatus" - IP binding status of single IP instance or multi-IP instance (binding or bound)
        /// "Key": "Type" - this field has been disused
        /// "Key": "ElasticLimit" - elastic protection value of resource instance
        /// "Key": "DDoSAI" - DDoS AI protection status of resource instance
        /// "Key": "Bandwidth" - base protection value of resource instance
        /// "Key": "OverloadCount" - number of attacks to the resource instance that exceed the elastic protection value
        /// "Key": "Status" - resource instance status (idle: running, attacking: attacking, blocking: blocking, isolate: isolating)
        /// "Key": "Lbid" - this field has been disused
        /// "Key": "ShowFlag" - this field has been disused
        /// "Key": "Expire" - resource instance expiration time
        /// "Key": "CCThreshold" - CC protection triggering threshold of resource instance
        /// "Key": "AutoRenewFlag" - auto-renewal flag of resource instance
        /// "Key": "IspCode" - line of single IP instance or multi-IP instance (0: China Telecom, 1: China Unicom, 2: China Mobile, 5: BGP)
        /// "Key": "PackType" - package type
        /// "Key": "PackId" - package ID
        /// "Key": "Name" - resource instance name
        /// "Key": "Locked" - this field has been disused
        /// "Key": "IpDDoSLevel" - protection level of resource instance (low: loose, middle: normal, high: strict)
        /// "Key": "DefendStatus" - DDoS protection status of resource (enabled or temporarily disabled)
        /// "Key": "UndefendExpire" - end time of temporary disablement of DDoS protection for resource instance
        /// "Key": "Tgw" - whether the resource instance is a new resource
        /// </summary>
        [JsonProperty("ServicePacks")]
        public KeyValueRecord[] ServicePacks{ get; set; }

        /// <summary>
        /// Anti-DDoS service type. `bgp`: Anti-DDoS Pro (single IP), `bgp-multip`: Anti-DDoS Pro (multi-IP), `bgpip`: Anti-DDoS Advanced, `net`: Anti-DDoS Ultimate)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "ServicePacks.", this.ServicePacks);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

