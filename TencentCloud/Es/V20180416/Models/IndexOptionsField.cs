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
        /// <p>Expiration time.</p>
        /// </summary>
        [JsonProperty("ExpireMaxAge")]
        public string ExpireMaxAge{ get; set; }

        /// <summary>
        /// <p>Expiration size</p>
        /// </summary>
        [JsonProperty("ExpireMaxSize")]
        public string ExpireMaxSize{ get; set; }

        /// <summary>
        /// <p>Rollover period</p>
        /// </summary>
        [JsonProperty("RolloverMaxAge")]
        public string RolloverMaxAge{ get; set; }

        /// <summary>
        /// <p>Whether to enable dynamic scrolling</p>
        /// </summary>
        [JsonProperty("RolloverDynamic")]
        public string RolloverDynamic{ get; set; }

        /// <summary>
        /// <p>Whether to enable dynamic sharding</p>
        /// </summary>
        [JsonProperty("ShardNumDynamic")]
        public string ShardNumDynamic{ get; set; }

        /// <summary>
        /// <p>Time partition field</p>
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// <p>Write mode</p>
        /// </summary>
        [JsonProperty("WriteMode")]
        public string WriteMode{ get; set; }

        /// <summary>
        /// <p>Whether to enable complete uninstallation</p><p>Enumeration values:</p><ul><li>true: enable complete uninstallation</li><li>false: disable complete uninstallation</li></ul>
        /// </summary>
        [JsonProperty("FullOffloadedEnable")]
        public string FullOffloadedEnable{ get; set; }

        /// <summary>
        /// <p>Full uninstall lifecycle</p>
        /// </summary>
        [JsonProperty("FullOffloadedMaxAge")]
        public string FullOffloadedMaxAge{ get; set; }

        /// <summary>
        /// <p>Completely uninstall the lifecycle after backup index retrieval</p>
        /// </summary>
        [JsonProperty("FullOffloadedRetrieveMaxAge")]
        public string FullOffloadedRetrieveMaxAge{ get; set; }


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
            this.SetParamSimple(map, prefix + "FullOffloadedEnable", this.FullOffloadedEnable);
            this.SetParamSimple(map, prefix + "FullOffloadedMaxAge", this.FullOffloadedMaxAge);
            this.SetParamSimple(map, prefix + "FullOffloadedRetrieveMaxAge", this.FullOffloadedRetrieveMaxAge);
        }
    }
}

