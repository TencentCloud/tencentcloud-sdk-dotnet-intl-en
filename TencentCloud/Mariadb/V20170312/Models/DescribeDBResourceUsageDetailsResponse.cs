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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBResourceUsageDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// Master node resource usage monitoring node
        /// </summary>
        [JsonProperty("Master")]
        public ResourceUsageMonitorSet Master{ get; set; }

        /// <summary>
        /// Slave 1 resource usage monitoring node
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Slave1")]
        public ResourceUsageMonitorSet Slave1{ get; set; }

        /// <summary>
        /// Slave 2 resource usage monitoring node
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Slave2")]
        public ResourceUsageMonitorSet Slave2{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Master.", this.Master);
            this.SetParamObj(map, prefix + "Slave1.", this.Slave1);
            this.SetParamObj(map, prefix + "Slave2.", this.Slave2);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

