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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID list (When it is empty,
        /// all clusters under the account will be obtained)
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of output entries. Default value: 20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// ·  ClusterName
        ///     Filters by the cluster name
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  ClusterType
        ///     Filters by the cluster type
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  ClusterStatus
        ///     Filters by the cluster status
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  Tags
        ///     Filters by key-value pairs of tags
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  vpc-id
        ///     Filters by the VPC ID
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  tag-key
        ///     Filters by the tag key
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  tag-value
        ///     Filters by the tag value
        ///     Type: String
        ///     Required: No
        /// 
        /// ·  tag:tag-key
        ///     Filters by key-value pairs of tags
        ///     Type: String
        ///     Required: No
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Cluster type, such as `MANAGED_CLUSTER`
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

