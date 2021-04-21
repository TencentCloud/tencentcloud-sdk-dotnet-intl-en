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
        /// Resource record list. The description of key values is as follows:
        /// "Key": "CreateTime" (Instance purchase time)
        /// "Key": "Region" (Instance region)
        /// "Key": "BoundIP" (IP bound to the single-IP instance)
        /// "Key": "Id" (Instance ID)
        /// "Key": "CCEnabled" (CC protection switch status of the instance)
        /// "Key": "DDoSThreshold" (Anti-DDoS cleansing threshold of the instance)	
        /// "Key": "BoundStatus" (IP binding status of the single-IP/multi-IP instance; binding or bound)
        /// "Key": "Type" (Disused field)
        /// "Key": "ElasticLimit" (Elastic protection value of the instance)
        /// "Key": "DDoSAI" (Anti-DDoS AI protection switch of the instance)
        /// "Key": "OverloadCount" (The number of attacks exceeding the elastic protection value to the instance)
        /// "Key": "Status" (Instance status; idle: running; attacking: under attacks; blocking: being blocked; isolate: being isolated)
        /// "Key": "Lbid" (Disused field)
        /// "Key": "ShowFlag" (Disused field)
        /// "Key": "Expire" (Instance expiry time)
        /// "Key": "CCThreshold" (CC protection trigger value of the instance)
        /// "Key": "AutoRenewFlag" (Whether the instance is on auto-renewal)
        /// "Key": "IspCode" (Line of the single-IP/multi-IP instance; 0: China Telecom; 1: China Unicom; 2: China Mobile; 5: BGP)
        /// "Key": "PackType" (Package type)
        /// "Key": "PackId" (Package ID)
        /// "Key": "Name" (Instance name)
        /// "Key": "Locked" (Disused field)
        /// "Key": "IpDDoSLevel" (Protection level of the instance; low: loose; middle: normal; high: strict)
        /// "Key": "DefendStatus" (DDoS protection status of the instance; enabled or temporarily disabled)
        /// "Key": "UndefendExpire" (End time of the temporary disabling on DDoS protection for the instance)
        /// "Key": "Tgw" (Whether it is a new instance)
        /// "Key": "Bandwidth" (Base protection value of the Anti-DDoS Pro/Advanced instance)
        /// "Key": "DdosMax" (Base protection value of the Anti-DDoS Ultimate instance)
        /// "Key": "GFBandwidth" (Base business application bandwidth of the Anti-DDoS Advanced instance)
        /// "Key": "ServiceBandwidth" (Base business application bandwidth of the Anti-DDoS Ultimate instance)
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

