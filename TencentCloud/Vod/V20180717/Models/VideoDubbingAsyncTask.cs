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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoDubbingAsyncTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task status. Valid values: </p><li>PROCESSING: Processing; </li><li>FINISH: Completed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Error code. 0 indicates success, and other values indicate failure:</p><li>40000: invalid input parameters. Check input parameters;</li><li>60000: source file error (for example, video data corruption). Confirm whether the source file is normal;</li><li>70000: internal service error. Retry is recommended.</li>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Error code. An empty string indicates success, and other values indicate failure. For values, see <a href="https://www.tencentcloud.com/document/product/266/50368?from_cn_redirect=1#.E8.A7.86.E9.A2.91.E5.A4.84.E7.90.86.E7.B1.BB.E9.94.99.E8.AF.AF.E7.A0.81">Video Processing Error Codes</a>.</p>
        /// </summary>
        [JsonProperty("ErrCodeExt")]
        public string ErrCodeExt{ get; set; }

        /// <summary>
        /// <p>Input information for a video dubbing task.</p>
        /// </summary>
        [JsonProperty("Input")]
        public VideoDubbingAsyncInput Input{ get; set; }

        /// <summary>
        /// <p>Video dubbing task output information.</p>
        /// </summary>
        [JsonProperty("Output")]
        public VideoDubbingAsyncOutput Output{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past seven days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The task status change callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Pull upload progress. Value range: [0-100].</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "ErrCodeExt", this.ErrCodeExt);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

