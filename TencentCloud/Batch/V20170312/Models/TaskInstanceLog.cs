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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceLog : AbstractModel
    {
        
        /// <summary>
        /// Task instance
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public ulong? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// Standard output log (Base64-encoded, up to 2048 bytes after decompression)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StdoutLog")]
        public string StdoutLog{ get; set; }

        /// <summary>
        /// Standard error log (Base64-encoded, up to 2048 bytes after decompression)
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StderrLog")]
        public string StderrLog{ get; set; }

        /// <summary>
        /// Standard output redirection path
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StdoutRedirectPath")]
        public string StdoutRedirectPath{ get; set; }

        /// <summary>
        /// Standard error redirection path
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StderrRedirectPath")]
        public string StderrRedirectPath{ get; set; }

        /// <summary>
        /// Standard output redirection file name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StdoutRedirectFileName")]
        public string StdoutRedirectFileName{ get; set; }

        /// <summary>
        /// Standard error redirection file name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StderrRedirectFileName")]
        public string StderrRedirectFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "StdoutLog", this.StdoutLog);
            this.SetParamSimple(map, prefix + "StderrLog", this.StderrLog);
            this.SetParamSimple(map, prefix + "StdoutRedirectPath", this.StdoutRedirectPath);
            this.SetParamSimple(map, prefix + "StderrRedirectPath", this.StderrRedirectPath);
            this.SetParamSimple(map, prefix + "StdoutRedirectFileName", this.StdoutRedirectFileName);
            this.SetParamSimple(map, prefix + "StderrRedirectFileName", this.StderrRedirectFileName);
        }
    }
}

