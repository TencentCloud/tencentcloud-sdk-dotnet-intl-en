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

    public class InstanceLifeCycleOpsDto : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Data Timestamp
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// Instance Lifecycle Count
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LifeRound")]
        public long? LifeRound{ get; set; }

        /// <summary>
        /// Run Type Rerun/Supplement/Periodic/Non-periodic
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// Number of Reruns
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tries")]
        public long? Tries{ get; set; }

        /// <summary>
        /// Instance LifecycleNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceLifeDetailDtoList")]
        public InstanceLifeDetailDto[] InstanceLifeDetailDtoList{ get; set; }

        /// <summary>
        /// Runner Status
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RunnerState")]
        public string RunnerState{ get; set; }

        /// <summary>
        /// Error codeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ErrorDesc")]
        public string ErrorDesc{ get; set; }

        /// <summary>
        /// Error Alert Level
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ErrorCodeLevel")]
        public string ErrorCodeLevel{ get; set; }

        /// <summary>
        /// Instance Log Summary
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceLogListOpsDto")]
        public InstanceLogInfo InstanceLogListOpsDto{ get; set; }

        /// <summary>
        /// Instance StatusNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "LifeRound", this.LifeRound);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "InstanceLifeDetailDtoList.", this.InstanceLifeDetailDtoList);
            this.SetParamSimple(map, prefix + "RunnerState", this.RunnerState);
            this.SetParamSimple(map, prefix + "ErrorDesc", this.ErrorDesc);
            this.SetParamSimple(map, prefix + "ErrorCodeLevel", this.ErrorCodeLevel);
            this.SetParamObj(map, prefix + "InstanceLogListOpsDto.", this.InstanceLogListOpsDto);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
        }
    }
}

