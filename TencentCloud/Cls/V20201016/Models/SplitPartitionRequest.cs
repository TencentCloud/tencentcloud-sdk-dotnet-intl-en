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

    public class SplitPartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// Log topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// ID of the partition to be split
        /// </summary>
        [JsonProperty("PartitionId")]
        public long? PartitionId{ get; set; }

        /// <summary>
        /// Partition split hash key position, which is meaningful only if `Number=2` is set
        /// </summary>
        [JsonProperty("SplitKey")]
        public string SplitKey{ get; set; }

        /// <summary>
        /// Number of partitions to split into, which is optional. Default value: 2
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionId", this.PartitionId);
            this.SetParamSimple(map, prefix + "SplitKey", this.SplitKey);
            this.SetParamSimple(map, prefix + "Number", this.Number);
        }
    }
}

