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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadSpec : AbstractModel
    {
        
        /// <summary>
        /// Configuration for concurrency mode.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Concurrency")]
        public Concurrency Concurrency{ get; set; }

        /// <summary>
        /// Configuration for RPS mode.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RequestsPerSecond")]
        public RequestsPerSecond RequestsPerSecond{ get; set; }

        /// <summary>
        /// Built-in script mode.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ScriptOrigin")]
        public ScriptOrigin ScriptOrigin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Concurrency.", this.Concurrency);
            this.SetParamObj(map, prefix + "RequestsPerSecond.", this.RequestsPerSecond);
            this.SetParamObj(map, prefix + "ScriptOrigin.", this.ScriptOrigin);
        }
    }
}

