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
        /// Number of entries per page.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Searching field.
        /// </summary>
        [JsonProperty("SearchText")]
        public string SearchText{ get; set; }

        /// <summary>
        /// 'Configuration status. Valid values: -2 (configuration failed), -1 (configuration expired), 1 (synchronized)', and -99 '(all)'.
        /// </summary>
        [JsonProperty("ConfStatus")]
        public long? ConfStatus{ get; set; }

        /// <summary>
        /// Filter criterion, which specifies the maintenance status. Valid values:
        /// 0: all statuses
        /// 1: normal mode
        /// 2: maintenance mode
        /// </summary>
        [JsonProperty("MaintainStateId")]
        public long? MaintainStateId{ get; set; }

        /// <summary>
        /// Filter criterion, which specifies the operation status. Valid values:
        /// 0: all statuses
        /// 1: started
        /// 2: stopped.
        /// </summary>
        [JsonProperty("OperatorStateId")]
        public long? OperatorStateId{ get; set; }

        /// <summary>
        /// Filter criterion, which specifies the health status. Valid values:
        /// "0": unavailable
        /// "1": good
        /// -2: unknown
        /// -99: all statuses
        /// -3: potential risk
        /// -4: undetected
        /// </summary>
        [JsonProperty("HealthStateId")]
        public string HealthStateId{ get; set; }

        /// <summary>
        /// Service component name, which must be specified by using uppercase letters (for example, YARN). Select either the service component name or ServiceGroupType in an API call and ensure that the selected item is required.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Node name. Valid values: master, core, task, common, and router.
        /// </summary>
        [JsonProperty("NodeTypeName")]
        public string NodeTypeName{ get; set; }

        /// <summary>
        /// Filter criterion, which specifies whether the data node is in maintenance. Valid values:
        /// 0: all statuses
        /// 1: maintenance status
        /// </summary>
        [JsonProperty("DataNodeMaintenanceId")]
        public long? DataNodeMaintenanceId{ get; set; }

        /// <summary>
        /// Searchable fields (Currently, SearchType: ipv4 is supported).
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

