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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartEraseTaskResult : AbstractModel
    {
        
        /// <summary>
        /// Task status, including PROCESSING, SUCCESS, and FAIL.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code. An empty string indicates that the task is successful, and other values indicate that the task has failed. For specific values, see [Error Codes] (https://www.tencentcloud.comom/document/product/862/50369?from_cn_redirect=1#.E8.A7.86.E9.A2.91.E5.A4.84.E7.90.86.E7.B1.BB.E9.94.99.E8.AF.AF.E7.A0.81).
        /// </summary>
        [JsonProperty("ErrCodeExt")]
        public string ErrCodeExt{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Input of the smart erasure task.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Input")]
        public SmartEraseTaskInput Input{ get; set; }

        /// <summary>
        /// Output of the smart erasure task.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Output")]
        public AiAnalysisTaskDelLogoOutput Output{ get; set; }

        /// <summary>
        /// Task progress.		
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// Task execution start time in ISO datetime format.
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// Task execution completion time in ISO datetime format.
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCodeExt", this.ErrCodeExt);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
        }
    }
}

