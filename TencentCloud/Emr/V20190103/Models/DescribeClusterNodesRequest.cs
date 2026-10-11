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

    public class DescribeClusterNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID, such as emr-xxxxxxxx.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Node identifier. Valid values:
        /// <li>all: indicates retrieving all types of nodes, except CDB information.</li>
        /// <li>master: indicates retrieving Master node information.</li>
        /// <li>core: indicates retrieving Core node information.</li>
        /// <li>task: indicates retrieving Task node information.</li>
        /// <li>common: indicates retrieving Common node information.</li>
        /// <li>router: indicates retrieving Router node information.</li>
        /// <li>db: indicates retrieving CDB information in the normal status.</li>
        /// <li>recyle: indicates retrieving information of nodes isolated in the recycle bin, including CDB information.</li>
        /// <li>renew: indicates retrieving information of all nodes pending renewal, including CDB information. Auto-renewed nodes will not be returned.</li>
        /// Note: Only the values above are supported currently. Entering other values will result in an error.
        /// </summary>
        [JsonProperty("NodeFlag")]
        public string NodeFlag{ get; set; }

        /// <summary>
        /// Whether to carry CDB information when all node information is exported in CSV format.
        /// </summary>
        [JsonProperty("ExportDb")]
        public bool? ExportDb{ get; set; }

        /// <summary>
        /// Page number. The default value is 0, indicating the first page.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of items returned per page. Default value: 100. Maximum value: 100.
        /// If both offset and limit are not set, or both are set to 0, all data will be returned.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Resource type. Valid values: all (default), host, and pod.
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// Searchable fields.
        /// </summary>
        [JsonProperty("SearchFields")]
        public SearchItem[] SearchFields{ get; set; }

        /// <summary>
        /// Sorting field.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Whether to sort data in ascending order. Valid values: 1 (yes) and 0 (no).
        /// </summary>
        [JsonProperty("Asc")]
        public long? Asc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeFlag", this.NodeFlag);
            this.SetParamSimple(map, prefix + "ExportDb", this.ExportDb);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "HardwareResourceType", this.HardwareResourceType);
            this.SetParamArrayObj(map, prefix + "SearchFields.", this.SearchFields);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
        }
    }
}

