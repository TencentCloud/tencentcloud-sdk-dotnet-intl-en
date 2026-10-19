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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosRiskActionInfo : AbstractModel
    {
        
        /// <summary>
        /// API name
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// Chinese api name
        /// </summary>
        [JsonProperty("ActionNameCn")]
        public string ActionNameCn{ get; set; }

        /// <summary>
        /// Number of calls.
        /// </summary>
        [JsonProperty("InvokeCount")]
        public long? InvokeCount{ get; set; }

        /// <summary>
        /// Last access time in Unix timestamp in milliseconds.
        /// </summary>
        [JsonProperty("ActionAccessTime")]
        public long? ActionAccessTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "ActionNameCn", this.ActionNameCn);
            this.SetParamSimple(map, prefix + "InvokeCount", this.InvokeCount);
            this.SetParamSimple(map, prefix + "ActionAccessTime", this.ActionAccessTime);
        }
    }
}

