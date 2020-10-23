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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Total number of steps
        /// </summary>
        [JsonProperty("StepAll")]
        public long? StepAll{ get; set; }

        /// <summary>
        /// Current step
        /// </summary>
        [JsonProperty("StepNow")]
        public long? StepNow{ get; set; }

        /// <summary>
        /// Overall progress, such as "10"
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }

        /// <summary>
        /// Progress of current step, such as "1"
        /// </summary>
        [JsonProperty("CurrentStepProgress")]
        public string CurrentStepProgress{ get; set; }

        /// <summary>
        /// Master/slave lag in MB, which is valid during incremental sync and currently supported by TencentDB for Redis and MySQL
        /// </summary>
        [JsonProperty("MasterSlaveDistance")]
        public long? MasterSlaveDistance{ get; set; }

        /// <summary>
        /// Master/slave lag in seconds, which is valid during incremental sync and currently supported by TencentDB for MySQL
        /// </summary>
        [JsonProperty("SecondsBehindMaster")]
        public long? SecondsBehindMaster{ get; set; }

        /// <summary>
        /// Step information
        /// </summary>
        [JsonProperty("StepInfo")]
        public MigrateStepDetailInfo[] StepInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepAll", this.StepAll);
            this.SetParamSimple(map, prefix + "StepNow", this.StepNow);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "CurrentStepProgress", this.CurrentStepProgress);
            this.SetParamSimple(map, prefix + "MasterSlaveDistance", this.MasterSlaveDistance);
            this.SetParamSimple(map, prefix + "SecondsBehindMaster", this.SecondsBehindMaster);
            this.SetParamArrayObj(map, prefix + "StepInfo.", this.StepInfo);
        }
    }
}

