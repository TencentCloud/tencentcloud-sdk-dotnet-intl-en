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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIncrementalMigrationStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The ID of [VOD Professional Application](http://tencentcloud.com/document/product/266/67977).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The bucket ID where the strategy takes effect.
        /// </summary>
        [JsonProperty("BucketId")]
        public string BucketId{ get; set; }

        /// <summary>
        /// The ID of the incremental migration strategy.
        /// </summary>
        [JsonProperty("StrategyId")]
        public string StrategyId{ get; set; }

        /// <summary>
        /// The name of the incremental migration strategy.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Source type. Valid values: 
        /// <li>HTTP: (Default) the source type is HTTP.</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Incremental migration HTTP origin source configuration. If left blank, it will default to no modification.
        /// </summary>
        [JsonProperty("HttpOriginConfig")]
        public IncrementalMigrationHttpOriginConfig HttpOriginConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "BucketId", this.BucketId);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamObj(map, prefix + "HttpOriginConfig.", this.HttpOriginConfig);
        }
    }
}

