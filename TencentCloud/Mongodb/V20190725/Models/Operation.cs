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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Operation : AbstractModel
    {
        
        /// <summary>
        /// Name of the shard where the operation is performed. The [DescribeCurrentOp](https://www.tencentcloud.com/document/product/240/48120?from_cn_redirect=1) API can be called to query the shard name.
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// Name of the node where the operation is performed. The [DescribeCurrentOp](https://www.tencentcloud.com/document/product/240/48120?from_cn_redirect=1) API can be called to query the node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Operation number. The [DescribeCurrentOp](https://www.tencentcloud.com/document/product/240/48120?from_cn_redirect=1) API can be called to query the operation number.
        /// </summary>
        [JsonProperty("OpId")]
        public long? OpId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "OpId", this.OpId);
        }
    }
}

