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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// LoadBalancer name, which can contain 1 to 200 characters, including a-z, A-Z, 0-9, underscores (_), and hyphens (-).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// LoadBalancer type. Valid values:
        /// <li>HTTP: HTTP-specific LoadBalancer. It supports adding HTTP-specific and general origin server groups. It can only be referenced by site acceleration services (such as domain name service and rule engine).</li>
        /// <li>GENERAL: general LoadBalancer. It only supports adding general origin server groups. It can be referenced by site acceleration services (such as domain name service and rule engine) and Layer-4 proxy.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// List of origin server groups and their corresponding disaster recovery scheduling priorities. For details, refer to Sample Scenario in [Quickly Create Load Balancers](https://intl.cloud.tencent.com/document/product/1552/104223?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("OriginGroups")]
        public OriginGroupInLoadBalancer[] OriginGroups{ get; set; }

        /// <summary>
        /// Health check policy. For details, refer to [Health Check Policies](https://intl.cloud.tencent.com/document/product/1552/104228?from_cn_redirect=1). If left empty, health check is disabled by default.
        /// </summary>
        [JsonProperty("HealthChecker")]
        public HealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// Traffic scheduling policy among origin server groups. Valid values:
        /// <li>Priority: Perform failover according to priority.</li>The default value is Priority.
        /// </summary>
        [JsonProperty("SteeringPolicy")]
        public string SteeringPolicy{ get; set; }

        /// <summary>
        /// Request retry policy when access to an origin server fails. For details, refer to [Introduction to Request Retry Strategy](https://intl.cloud.tencent.com/document/product/1552/104227?from_cn_redirect=1). Valid values:
        /// <li>OtherOriginGroup: After a single request fails, retry with another origin server within the next lower priority origin server group.</li>
        /// <li>OtherRecordInOriginGroup: After a single request fails, retry with another origin server within the same origin server group.</li> The default value is OtherRecordInOriginGroup.
        /// </summary>
        [JsonProperty("FailoverPolicy")]
        public string FailoverPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "OriginGroups.", this.OriginGroups);
            this.SetParamObj(map, prefix + "HealthChecker.", this.HealthChecker);
            this.SetParamSimple(map, prefix + "SteeringPolicy", this.SteeringPolicy);
            this.SetParamSimple(map, prefix + "FailoverPolicy", this.FailoverPolicy);
        }
    }
}

