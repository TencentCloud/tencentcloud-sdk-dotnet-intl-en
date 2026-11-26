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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Instance name, which can contain 1 to 200 characters, including a-z, A-Z, 0-9, underscores (_), and hyphens (-).</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Instance type. Valid values:</p><li>HTTP_V2: HTTP dedicated (V2). Supports adding HTTP dedicated and general origin server groups. Site acceleration services reference only (such as domain name service and rule engine). This instance type supports selecting the region to initiate probes, which can significantly reduce probe request volume but has lower sensitivity to origin server health awareness.</li><li>HTTP: HTTP dedicated (V1). Supports adding HTTP dedicated and general origin server groups. Site acceleration services reference only (such as domain name service and rule engine). This instance type does not support selecting the region to initiate probes. The probe request volume is large but has higher sensitivity to origin server health awareness.</li><li>GENERAL: General type. Supports adding general origin server groups only. Can be referenced by site acceleration services (such as domain name service and rule engine) and Layer-4 proxies. This instance type does not support selecting the region to initiate probes. The probe request volume is large but has higher sensitivity to origin server health awareness.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>List of origin server groups and their corresponding disaster recovery scheduling priorities. For details, refer to Sample Scenario in <a href="https://www.tencentcloud.com/document/product/1552/104223?from_cn_redirect=1">Quickly Create Load Balancers</a>.</p>
        /// </summary>
        [JsonProperty("OriginGroups")]
        public OriginGroupInLoadBalancer[] OriginGroups{ get; set; }

        /// <summary>
        /// <p>Health check policy. For details, refer to <a href="https://www.tencentcloud.com/document/product/1552/104228?from_cn_redirect=1">Health Check Policies</a>. If left empty, health check is disabled by default.</p>
        /// </summary>
        [JsonProperty("HealthChecker")]
        public HealthChecker HealthChecker{ get; set; }

        /// <summary>
        /// <p>Traffic scheduling policy between origin server groups. Valid values:</p><li>Pritory: Perform failover according to priority.</li>Default value: Pritory.
        /// </summary>
        [JsonProperty("SteeringPolicy")]
        public string SteeringPolicy{ get; set; }

        /// <summary>
        /// <p>Request retry policy when access to an origin server fails. For details, refer to <a href="https://www.tencentcloud.com/document/product/1552/104227?from_cn_redirect=1">Introduction to Request Retry Strategy</a>. Valid values:</p><li>OtherOriginGroup: After a single request fails, retry with another origin server within the next lower priority origin server group.</li><li>OtherRecordInOriginGroup: After a single request fails, retry with another origin server within the same origin server group.</li>The default value is OtherRecordInOriginGroup.
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

