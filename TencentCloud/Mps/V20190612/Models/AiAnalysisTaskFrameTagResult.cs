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

    public class AiAnalysisTaskFrameTagResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Task status. Valid values are PROCESSING, SUCCESS, and FAIL.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Error code. An empty string indicates that the task is successful, while other values indicate that the task has failed. For valid values, see the list of <a href="https://www.tencentcloud.com/document/product/862/50369?from_cn_redirect=1#.E8.A7.86.E9.A2.91.E5.A4.84.E7.90.86.E7.B1.BB.E9.94.99.E8.AF.AF.E7.A0.81">MPS error codes</a>.</p>
        /// </summary>
        [JsonProperty("ErrCodeExt")]
        public string ErrCodeExt{ get; set; }

        /// <summary>
        /// <p>Error code. 0 indicates success, and other values indicate failure. (This field is not recommended. Use the new error code field ErrCodeExt instead.)</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Intelligent frame-specific tagging task input.</p>
        /// </summary>
        [JsonProperty("Input")]
        public AiAnalysisTaskFrameTagInput Input{ get; set; }

        /// <summary>
        /// <p>Output of the intelligent frame-by-frame tagging task.</p>
        /// </summary>
        [JsonProperty("Output")]
        public AiAnalysisTaskFrameTagOutput Output{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCodeExt", this.ErrCodeExt);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
        }
    }
}

