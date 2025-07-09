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

    public class DescribeSLInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance filtering policy. Valid values: <li>clusterList: Query the list of instances except for those that have been terminated.</li> <li>monitorManage: Query the list of instances except for those that have been terminated, are being created, or fail to be created.</li>
        /// </summary>
        [JsonProperty("DisplayStrategy")]
        public string DisplayStrategy{ get; set; }

        /// <summary>
        /// Page number. The default value is 0, indicating the first page.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of records to be returned per page. The default value is 10, and the maximum value is 100.	
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Sorting field. Valid values: <li>clusterId: Sort by instance ID.</li> <li>addTime: Sort by instance creation time.</li> <li>status: Sort by instance status code.</li>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Sorts by OrderField in ascending or descending order. Valid values: <li>0: ascending order;</li> <li>1: descending order.</li> The default value is 0.
        /// </summary>
        [JsonProperty("Asc")]
        public long? Asc{ get; set; }

        /// <summary>
        /// Custom search filters. Examples: <li>Filter instances by ClusterId: [{"Name":"ClusterId","Values":["emr-xxxxxxxx"]}]</li><li> Filter instances by clusterName: [{"Name": "ClusterName","Values": ["cluster_name"]}]</li><li>Filter instances by ClusterStatus: [{"Name": "ClusterStatus","Values": ["2"]}]</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayStrategy", this.DisplayStrategy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

