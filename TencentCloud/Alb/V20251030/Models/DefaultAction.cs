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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DefaultAction : AbstractModel
    {
        
        /// <summary>
        /// Forwarding target group configuration. When a listener is created, the target group configuration in the forwarding action enables only a single target group.
        /// </summary>
        [JsonProperty("TargetGroupConfig")]
        public TargetGroupConfig TargetGroupConfig{ get; set; }

        /// <summary>
        /// Forward action type. When a listener is created, the default forward action type only supports forwarding to a target group.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TargetGroupConfig.", this.TargetGroupConfig);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

