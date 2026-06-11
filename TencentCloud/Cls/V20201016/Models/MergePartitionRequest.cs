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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MergePartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// Log topic ID
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Merged partition id (find the next partition whose InclusiveBeginKey equals the ExclusiveEndKey of the corresponding partition id in the input parameter, and the found partition must be a read-write partition (Status:readwrite), set the input partition id and the found partition id to read-only partition (Status:readonly), then create a new read-write partition). [Get partition list](https://www.tencentcloud.com/document/product/614/56470?from_cn_redirect=1)
        /// 
        /// 1. PartitionId can only be a read-write partition (Status can be readonly or readwrite), and the next read-write partition of PartitionId can be found (the InclusiveBeginKey of the next partition equals to the ExclusiveEndKey of PartitionId).
        /// 2. The PartitionId cannot be the last partition (the ExclusiveEndKey of PartitionId cannot be ffffffffffffffffffffffffffffffff).
        /// 3. The number of topic partitions is limited (50 by default). After merging, it must not exceed the maximum partition, otherwise merging is not allowed.
        /// </summary>
        [JsonProperty("PartitionId")]
        public long? PartitionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionId", this.PartitionId);
        }
    }
}

