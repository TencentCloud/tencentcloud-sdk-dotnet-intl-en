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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Total number of steps
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StepAll")]
        public ulong? StepAll{ get; set; }

        /// <summary>
        /// Current step
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StepNow")]
        public ulong? StepNow{ get; set; }

        /// <summary>
        /// Overall progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Progress of the current step. Value range: 0-100. The value of `-1` indicates that you can't check the progress of the current step.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentStepProgress")]
        public long? CurrentStepProgress{ get; set; }

        /// <summary>
        /// Data volume difference between the sync source and target
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterSlaveDistance")]
        public long? MasterSlaveDistance{ get; set; }

        /// <summary>
        /// Time difference between the sync source and target
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecondsBehindMaster")]
        public long? SecondsBehindMaster{ get; set; }

        /// <summary>
        /// Overall description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Step details
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StepInfos")]
        public StepInfo[] StepInfos{ get; set; }

        /// <summary>
        /// Cause of the failure of initiating data consistency check
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CauseOfCompareDisable")]
        public string CauseOfCompareDisable{ get; set; }

        /// <summary>
        /// Task error and the corresponding solution
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrInfo")]
        public ErrInfo ErrInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "StepInfos.", this.StepInfos);
            this.SetParamSimple(map, prefix + "CauseOfCompareDisable", this.CauseOfCompareDisable);
            this.SetParamObj(map, prefix + "ErrInfo.", this.ErrInfo);
        }
    }
}

