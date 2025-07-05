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

    public class RedirectInfo : AbstractModel
    {
        
        /// <summary>
        /// Standard output redirection path
        /// </summary>
        [JsonProperty("StdoutRedirectPath")]
        public string StdoutRedirectPath{ get; set; }

        /// <summary>
        /// Standard error redirection path
        /// </summary>
        [JsonProperty("StderrRedirectPath")]
        public string StderrRedirectPath{ get; set; }

        /// <summary>
        /// Standard output redirection file name, which supports three placeholders: `${BATCH_JOB_ID}`, `${BATCH_TASK_NAME}`, and `${BATCH_TASK_INSTANCE_INDEX}`
        /// </summary>
        [JsonProperty("StdoutRedirectFileName")]
        public string StdoutRedirectFileName{ get; set; }

        /// <summary>
        /// Standard error redirection file name, which supports three placeholders: `${BATCH_JOB_ID}`, `${BATCH_TASK_NAME}`, and `${BATCH_TASK_INSTANCE_INDEX}`
        /// </summary>
        [JsonProperty("StderrRedirectFileName")]
        public string StderrRedirectFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StdoutRedirectPath", this.StdoutRedirectPath);
            this.SetParamSimple(map, prefix + "StderrRedirectPath", this.StderrRedirectPath);
            this.SetParamSimple(map, prefix + "StdoutRedirectFileName", this.StdoutRedirectFileName);
            this.SetParamSimple(map, prefix + "StderrRedirectFileName", this.StderrRedirectFileName);
        }
    }
}

