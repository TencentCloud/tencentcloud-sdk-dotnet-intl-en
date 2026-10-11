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

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster filtering policy. Valid values:
        /// <li>clusterList: Queries the list of clusters except for those that have been terminated.</li>
        /// <li>monitorManage: Queries the list of clusters except for those that have been terminated, are being created, or fail to be created.</li><li>cloudHardwareManage/componentManage: Currently these two values are reserved and temporarily have the same meaning as monitorManage.</li>
        /// </summary>
        [JsonProperty("DisplayStrategy")]
        public string DisplayStrategy{ get; set; }

        /// <summary>
        /// Query by one or more instance IDs. The instance ID is in the format of emr-xxxxxxxx. (For the specific format of this parameter, see the section Ids.N in the API [Introduction](https://www.tencentcloud.com/document/api/213/15688?from_cn_redirect=1)). If the instance ID is not specified, the list of all the instances for the APPID is returned.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of items returned per page. Default value: 100. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// It is recommended to set this parameter to -1, indicating all clusters under all projects are pulled.
        /// If not specified, the default value is 0, indicating the clusters under the default project are pulled.
        /// ID of the project to which the instance belongs. This parameter can be obtained from the projectId field in the return value of [DescribeProjects](https://www.tencentcloud.com/document/product/651/78725?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Sorting field. Valid values:
        /// <li>clusterId: sort by instance ID.</li>
        /// <li>addTime: sort by instance creation time.</li>
        /// <li>status: sort by instance status code.</li>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Sorts by OrderField in ascending or descending order. Valid values:<li>0: descending order</li>
        /// <li>1: ascending order</li>The default value is 0.
        /// </summary>
        [JsonProperty("Asc")]
        public long? Asc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayStrategy", this.DisplayStrategy);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
        }
    }
}

