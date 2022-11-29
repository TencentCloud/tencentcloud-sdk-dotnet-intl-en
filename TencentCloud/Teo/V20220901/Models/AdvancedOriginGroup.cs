/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedOriginGroup : AbstractModel
    {
        
        /// <summary>
        /// Matching condition. The "Target" field must be unique.
        /// </summary>
        [JsonProperty("OriginGroupConditions")]
        public OriginGroupCondition[] OriginGroupConditions{ get; set; }

        /// <summary>
        /// ID of the primary origin server.
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// ID of the secondary origin server.
        /// </summary>
        [JsonProperty("BackupOriginGroupId")]
        public string BackupOriginGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "OriginGroupConditions.", this.OriginGroupConditions);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamSimple(map, prefix + "BackupOriginGroupId", this.BackupOriginGroupId);
        }
    }
}

