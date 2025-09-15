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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServiceNodeInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Page size.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Searching fields.
        /// </summary>
        [JsonProperty("SearchText")]
        public string SearchText{ get; set; }

        /// <summary>
        /// Configuration status. -2: configuration failed; -1: configuration expired; 1: synchronized; -99: all.
        /// </summary>
        [JsonProperty("ConfStatus")]
        public long? ConfStatus{ get; set; }

        /// <summary>
        /// Filter criteria: Maintenance status
        /// 
        /// 0 indicates all statuses.
        /// 1 indicates normal.
        /// 2 indicates the maintenance status.
        /// </summary>
        [JsonProperty("MaintainStateId")]
        public long? MaintainStateId{ get; set; }

        /// <summary>
        /// Filter criteria: Operation status
        /// 
        /// 0 indicates all statuses.
        /// 1 indicates started.
        /// 2 indicates stopped.
        /// </summary>
        [JsonProperty("OperatorStateId")]
        public long? OperatorStateId{ get; set; }

        /// <summary>
        /// Filter criteria: health status.
        /// 0 indicates unavailable.
        /// 1 indicates good.
        /// -2 indicates unknown.
        /// -99 indicates all.
        /// -3 indicates potential risks.
        /// -4 indicates undetected.
        /// </summary>
        [JsonProperty("HealthStateId")]
        public string HealthStateId{ get; set; }

        /// <summary>
        /// Service component names (in all caps, for example, YARN).
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Node names: master, core, task, common, and router.
        /// </summary>
        [JsonProperty("NodeTypeName")]
        public string NodeTypeName{ get; set; }

        /// <summary>
        /// Filter criteria: whether DN is in the maintenance status.
        /// 0 indicates all statuses.
        /// 1 indicates the maintenance status.
        /// </summary>
        [JsonProperty("DataNodeMaintenanceId")]
        public long? DataNodeMaintenanceId{ get; set; }

        /// <summary>
        /// Searchable fields (currently supported SearchType: ipv4).
        /// </summary>
        [JsonProperty("SearchFields")]
        public SearchItem[] SearchFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchText", this.SearchText);
            this.SetParamSimple(map, prefix + "ConfStatus", this.ConfStatus);
            this.SetParamSimple(map, prefix + "MaintainStateId", this.MaintainStateId);
            this.SetParamSimple(map, prefix + "OperatorStateId", this.OperatorStateId);
            this.SetParamSimple(map, prefix + "HealthStateId", this.HealthStateId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "NodeTypeName", this.NodeTypeName);
            this.SetParamSimple(map, prefix + "DataNodeMaintenanceId", this.DataNodeMaintenanceId);
            this.SetParamArrayObj(map, prefix + "SearchFields.", this.SearchFields);
        }
    }
}

