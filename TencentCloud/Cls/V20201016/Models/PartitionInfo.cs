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

    public class PartitionInfo : AbstractModel
    {
        
        /// <summary>
        /// Partition ID
        /// </summary>
        [JsonProperty("PartitionId")]
        public long? PartitionId{ get; set; }

        /// <summary>
        /// Partition status. Valid values: `readwrite`, `readonly`
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Partition hash start key
        /// </summary>
        [JsonProperty("InclusiveBeginKey")]
        public string InclusiveBeginKey{ get; set; }

        /// <summary>
        /// Partition hash end key
        /// </summary>
        [JsonProperty("ExclusiveEndKey")]
        public string ExclusiveEndKey{ get; set; }

        /// <summary>
        /// Partition creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified of read-only partition
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastWriteTime")]
        public string LastWriteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionId", this.PartitionId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InclusiveBeginKey", this.InclusiveBeginKey);
            this.SetParamSimple(map, prefix + "ExclusiveEndKey", this.ExclusiveEndKey);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastWriteTime", this.LastWriteTime);
        }
    }
}

