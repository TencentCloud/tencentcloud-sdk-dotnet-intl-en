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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyAgentFromAppRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Target application ID. Required when kind=0</p>
        /// </summary>
        [JsonProperty("TargetAppId")]
        public string TargetAppId{ get; set; }

        /// <summary>
        /// <p>Agent type, case-sensitive between B-end configuration Agent and C-end client user Agent</p><p>Enumeration values:</p><ul><li>0: Configuration end Agent</li><li>1: User space Agent</li></ul>
        /// </summary>
        [JsonProperty("Kind")]
        public long? Kind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TargetAppId", this.TargetAppId);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
        }
    }
}

