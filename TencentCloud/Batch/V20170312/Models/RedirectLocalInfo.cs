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

    public class RedirectLocalInfo : AbstractModel
    {
        
        /// <summary>
        /// Standard output redirection local path
        /// </summary>
        [JsonProperty("StdoutLocalPath")]
        public string StdoutLocalPath{ get; set; }

        /// <summary>
        /// Standard error redirection local path
        /// </summary>
        [JsonProperty("StderrLocalPath")]
        public string StderrLocalPath{ get; set; }

        /// <summary>
        /// Standard output redirection local file name, which supports three placeholders: `${BATCH_JOB_ID}`, `${BATCH_TASK_NAME}`, and `${BATCH_TASK_INSTANCE_INDEX}`
        /// </summary>
        [JsonProperty("StdoutLocalFileName")]
        public string StdoutLocalFileName{ get; set; }

        /// <summary>
        /// Standard error redirection local file name, which supports three placeholders: `${BATCH_JOB_ID}`, `${BATCH_TASK_NAME}`, and `${BATCH_TASK_INSTANCE_INDEX}`
        /// </summary>
        [JsonProperty("StderrLocalFileName")]
        public string StderrLocalFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StdoutLocalPath", this.StdoutLocalPath);
            this.SetParamSimple(map, prefix + "StderrLocalPath", this.StderrLocalPath);
            this.SetParamSimple(map, prefix + "StdoutLocalFileName", this.StdoutLocalFileName);
            this.SetParamSimple(map, prefix + "StderrLocalFileName", this.StderrLocalFileName);
        }
    }
}

