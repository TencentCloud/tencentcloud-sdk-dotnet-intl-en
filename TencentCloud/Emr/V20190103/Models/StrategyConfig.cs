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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyConfig : AbstractModel
    {
        
        /// <summary>
        /// `0`: Disable rolling restart
        /// `1`: Enable rolling restart
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RollingRestartSwitch")]
        public long? RollingRestartSwitch{ get; set; }

        /// <summary>
        /// The quantity of restarts per batch during a rolling restart, with the maximum number of restarts being 99999
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BatchSize")]
        public long? BatchSize{ get; set; }

        /// <summary>
        /// The wait time (in seconds) per batch in rolling restart, with a maximum value of 5 minutes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeWait")]
        public long? TimeWait{ get; set; }

        /// <summary>
        /// The failure handling policy. Valid values: `0` (blocks the process) and `1` (skips).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DealOnFail")]
        public long? DealOnFail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RollingRestartSwitch", this.RollingRestartSwitch);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "TimeWait", this.TimeWait);
            this.SetParamSimple(map, prefix + "DealOnFail", this.DealOnFail);
        }
    }
}

