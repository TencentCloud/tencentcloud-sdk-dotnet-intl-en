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

    public class IncrementalMigrationHttpHeaderInfo : AbstractModel
    {
        
        /// <summary>
        /// HTTP Header Passthrough Mode. Values valid:
        /// <li>FOLLOW_ALL: Pass through all header information;<\li>
        /// <li>FOLLOW_PART: Pass through partial header information;<\li>
        /// <li>IGNORE_PART: Ignore partial header information.<\li>
        /// </summary>
        [JsonProperty("HeaderFollowMode")]
        public string HeaderFollowMode{ get; set; }

        /// <summary>
        /// Header Key Set for Passthrough. This field is required only when the HeaderFollowMode is set to `FOLLOW_PART`.
        /// </summary>
        [JsonProperty("FollowHttpHeaderKeySet")]
        public string[] FollowHttpHeaderKeySet{ get; set; }

        /// <summary>
        /// Add Header Key-Value Pair Collection.
        /// </summary>
        [JsonProperty("NewHttpHeaderSet")]
        public IncrementalMigrationHttpHeader[] NewHttpHeaderSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeaderFollowMode", this.HeaderFollowMode);
            this.SetParamArraySimple(map, prefix + "FollowHttpHeaderKeySet.", this.FollowHttpHeaderKeySet);
            this.SetParamArrayObj(map, prefix + "NewHttpHeaderSet.", this.NewHttpHeaderSet);
        }
    }
}

