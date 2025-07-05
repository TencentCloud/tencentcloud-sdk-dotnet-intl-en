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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexOptionsField : AbstractModel
    {
        
        /// <summary>
        /// Max age for expiry purpose
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpireMaxAge")]
        public string ExpireMaxAge{ get; set; }

        /// <summary>
        /// Max size for expiry purpose
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpireMaxSize")]
        public string ExpireMaxSize{ get; set; }

        /// <summary>
        /// Rollover cycle
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RolloverMaxAge")]
        public string RolloverMaxAge{ get; set; }

        /// <summary>
        /// Whether to enable the dynamic rollover
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RolloverDynamic")]
        public string RolloverDynamic{ get; set; }

        /// <summary>
        /// Whether to enable dynamic sharding
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ShardNumDynamic")]
        public string ShardNumDynamic{ get; set; }

        /// <summary>
        /// Timestamp field
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// Write mode
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WriteMode")]
        public string WriteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireMaxAge", this.ExpireMaxAge);
            this.SetParamSimple(map, prefix + "ExpireMaxSize", this.ExpireMaxSize);
            this.SetParamSimple(map, prefix + "RolloverMaxAge", this.RolloverMaxAge);
            this.SetParamSimple(map, prefix + "RolloverDynamic", this.RolloverDynamic);
            this.SetParamSimple(map, prefix + "ShardNumDynamic", this.ShardNumDynamic);
            this.SetParamSimple(map, prefix + "TimestampField", this.TimestampField);
            this.SetParamSimple(map, prefix + "WriteMode", this.WriteMode);
        }
    }
}

