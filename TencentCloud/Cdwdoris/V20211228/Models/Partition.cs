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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Partition : AbstractModel
    {
        
        /// <summary>
        /// Partition type:
        /// ●Range: The partition column is usually of time or integer type. Four writing methods are supported.
        /// ●List: The partition value is an enumeration value.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// Whether to automatically partition
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoPartition")]
        public bool? AutoPartition{ get; set; }

        /// <summary>
        /// Partition information when the partition type is Range
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RangeInfos")]
        public RangeInfo[] RangeInfos{ get; set; }

        /// <summary>
        /// Partition information when the partition type is List
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ListInfos")]
        public ListInfo[] ListInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "AutoPartition", this.AutoPartition);
            this.SetParamArrayObj(map, prefix + "RangeInfos.", this.RangeInfos);
            this.SetParamArrayObj(map, prefix + "ListInfos.", this.ListInfos);
        }
    }
}

