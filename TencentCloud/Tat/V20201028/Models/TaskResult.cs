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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskResult : AbstractModel
    {
        
        /// <summary>
        /// ExitCode of the execution.
        /// </summary>
        [JsonProperty("ExitCode")]
        public long? ExitCode{ get; set; }

        /// <summary>
        /// Base64-encoded command output. The maximum length is 24 KB.
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Time when the execution is started.
        /// </summary>
        [JsonProperty("ExecStartTime")]
        public string ExecStartTime{ get; set; }

        /// <summary>
        /// Time when the execution is ended.
        /// </summary>
        [JsonProperty("ExecEndTime")]
        public string ExecEndTime{ get; set; }

        /// <summary>
        /// Dropped bytes of the command output.
        /// </summary>
        [JsonProperty("Dropped")]
        public ulong? Dropped{ get; set; }

        /// <summary>
        /// COS URL of the logs.
        /// </summary>
        [JsonProperty("OutputUrl")]
        public string OutputUrl{ get; set; }

        /// <summary>
        /// Error message for uploading logs to COS.
        /// </summary>
        [JsonProperty("OutputUploadCOSErrorInfo")]
        public string OutputUploadCOSErrorInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExitCode", this.ExitCode);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "ExecStartTime", this.ExecStartTime);
            this.SetParamSimple(map, prefix + "ExecEndTime", this.ExecEndTime);
            this.SetParamSimple(map, prefix + "Dropped", this.Dropped);
            this.SetParamSimple(map, prefix + "OutputUrl", this.OutputUrl);
            this.SetParamSimple(map, prefix + "OutputUploadCOSErrorInfo", this.OutputUploadCOSErrorInfo);
        }
    }
}

