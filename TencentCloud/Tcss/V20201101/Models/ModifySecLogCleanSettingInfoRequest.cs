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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecLogCleanSettingInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Minimum storage (50-99) for triggering clearing
        /// </summary>
        [JsonProperty("ReservesLimit")]
        public ulong? ReservesLimit{ get; set; }

        /// <summary>
        /// Storage limit (greater than 0 and smaller than `ReservesLimit`) for stopping clearing
        /// </summary>
        [JsonProperty("ReservesDeadline")]
        public ulong? ReservesDeadline{ get; set; }

        /// <summary>
        /// Storage period (no less than one day) for triggering clearing
        /// </summary>
        [JsonProperty("DayLimit")]
        public ulong? DayLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReservesLimit", this.ReservesLimit);
            this.SetParamSimple(map, prefix + "ReservesDeadline", this.ReservesDeadline);
            this.SetParamSimple(map, prefix + "DayLimit", this.DayLimit);
        }
    }
}

