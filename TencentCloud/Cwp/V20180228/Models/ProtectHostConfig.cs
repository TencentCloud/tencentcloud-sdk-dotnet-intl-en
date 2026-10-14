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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectHostConfig : AbstractModel
    {
        
        /// <summary>
        /// Unique host ID.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Protection switch: 0 - off; 1 - on
        /// </summary>
        [JsonProperty("ProtectSwitch")]
        public ulong? ProtectSwitch{ get; set; }

        /// <summary>
        /// Auto recovery switch. 0: disabled. 1: enabled.
        /// </summary>
        [JsonProperty("AutoRecovery")]
        public ulong? AutoRecovery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "ProtectSwitch", this.ProtectSwitch);
            this.SetParamSimple(map, prefix + "AutoRecovery", this.AutoRecovery);
        }
    }
}

