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

    public class ImageProcessTaskResult : AbstractModel
    {
        
        /// <summary>
        /// Task status, including PROCESSING, SUCCESS, and FAIL.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code. A null string indicates that the task is successful, while other values indicate that the task has failed. For valid values, see the list of [MPS error codes](https://www.tencentcloud.com/document/product/862/50369?from_cn_redirect=1#.E8.A7.86.E9.A2.91.E5.A4.84.E7.90.86.E7.B1.BB.E9.94.99.E8.AF.AF.E7.A0.81).
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// Error message.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Transcoding task output.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Output")]
        public ImageProcessTaskOutput Output{ get; set; }

        /// <summary>
        /// Transcoding progress, with a value range of [0-100].
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

