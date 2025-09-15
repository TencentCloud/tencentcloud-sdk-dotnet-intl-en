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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyConfig : AbstractModel
    {
        
        /// <summary>
        /// 0: disable rolling restart.
        /// 1: enable rolling start.
        /// </summary>
        [JsonProperty("RollingRestartSwitch")]
        public long? RollingRestartSwitch{ get; set; }

        /// <summary>
        /// Rolling restart quantity per batch, which is up to 99999.
        /// </summary>
        [JsonProperty("BatchSize")]
        public long? BatchSize{ get; set; }

        /// <summary>
        /// Stop and wait time for rolling restart per batch, with the maximum interval of 5 minutes and the unit of seconds.
        /// </summary>
        [JsonProperty("TimeWait")]
        public long? TimeWait{ get; set; }

        /// <summary>
        /// Operation failure processing policy. 0: Block upon failure, 1: Automatically skipping failure.
        /// </summary>
        [JsonProperty("DealOnFail")]
        public long? DealOnFail{ get; set; }

        /// <summary>
        /// Parameters required in the instruction.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Args")]
        public Arg[] Args{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RollingRestartSwitch", this.RollingRestartSwitch);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "TimeWait", this.TimeWait);
            this.SetParamSimple(map, prefix + "DealOnFail", this.DealOnFail);
            this.SetParamArrayObj(map, prefix + "Args.", this.Args);
        }
    }
}

