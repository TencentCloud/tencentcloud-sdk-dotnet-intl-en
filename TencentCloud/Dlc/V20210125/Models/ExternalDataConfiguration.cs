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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalDataConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Metadata storage object
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sds")]
        public DMSSds Sds{ get; set; }

        /// <summary>
        /// View text
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ViewOriginalText")]
        public string ViewOriginalText{ get; set; }

        /// <summary>
        /// View text
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ViewExpandedText")]
        public string ViewExpandedText{ get; set; }

        /// <summary>
        /// Hive maintenance version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Retention")]
        public long? Retention{ get; set; }

        /// <summary>
        /// Lifecycle
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LifeTime")]
        public long? LifeTime{ get; set; }

        /// <summary>
        /// Partition
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Partitions")]
        public DMSPartition[] Partitions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Sds.", this.Sds);
            this.SetParamSimple(map, prefix + "ViewOriginalText", this.ViewOriginalText);
            this.SetParamSimple(map, prefix + "ViewExpandedText", this.ViewExpandedText);
            this.SetParamSimple(map, prefix + "Retention", this.Retention);
            this.SetParamSimple(map, prefix + "LifeTime", this.LifeTime);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
        }
    }
}

