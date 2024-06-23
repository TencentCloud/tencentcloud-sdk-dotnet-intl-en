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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScreenInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// Statistical Indicator 0: All Instances, 1: Current Day, 2: YesterdayNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CountTag")]
        public ulong? CountTag{ get; set; }

        /// <summary>
        /// Total numberNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// RunningNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RunningNum")]
        public ulong? RunningNum{ get; set; }

        /// <summary>
        /// Pending Execution
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WaitRunningNum")]
        public ulong? WaitRunningNum{ get; set; }

        /// <summary>
        /// Wait for Upstream
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DependencyNum")]
        public ulong? DependencyNum{ get; set; }

        /// <summary>
        /// Waiting for Event
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WaitEventNum")]
        public string WaitEventNum{ get; set; }

        /// <summary>
        /// Terminating
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StoppingNum")]
        public ulong? StoppingNum{ get; set; }

        /// <summary>
        /// SuccessNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SucceedNum")]
        public ulong? SucceedNum{ get; set; }

        /// <summary>
        /// Failed
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FailedNum")]
        public ulong? FailedNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CountTag", this.CountTag);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "WaitRunningNum", this.WaitRunningNum);
            this.SetParamSimple(map, prefix + "DependencyNum", this.DependencyNum);
            this.SetParamSimple(map, prefix + "WaitEventNum", this.WaitEventNum);
            this.SetParamSimple(map, prefix + "StoppingNum", this.StoppingNum);
            this.SetParamSimple(map, prefix + "SucceedNum", this.SucceedNum);
            this.SetParamSimple(map, prefix + "FailedNum", this.FailedNum);
        }
    }
}

