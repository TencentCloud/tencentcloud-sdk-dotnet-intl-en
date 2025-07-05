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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowlogDetail : AbstractModel
    {
        
        /// <summary>
        /// Total time consumed
        /// </summary>
        [JsonProperty("TotalTime")]
        public float? TotalTime{ get; set; }

        /// <summary>
        /// Total number of calls
        /// </summary>
        [JsonProperty("TotalCalls")]
        public long? TotalCalls{ get; set; }

        /// <summary>
        /// List of slow SQL statements after desensitization
        /// </summary>
        [JsonProperty("NormalQueries")]
        public NormalQueryItem[] NormalQueries{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "TotalCalls", this.TotalCalls);
            this.SetParamArrayObj(map, prefix + "NormalQueries.", this.NormalQueries);
        }
    }
}

