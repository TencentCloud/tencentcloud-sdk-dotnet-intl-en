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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceCountDto : AbstractModel
    {
        
        /// <summary>
        /// Number of Successful Instances
        /// </summary>
        [JsonProperty("Success")]
        public ulong? Success{ get; set; }

        /// <summary>
        /// Number of Instances in Execution
        /// </summary>
        [JsonProperty("Running")]
        public ulong? Running{ get; set; }

        /// <summary>
        /// Number of Instances Waiting
        /// </summary>
        [JsonProperty("Waiting")]
        public ulong? Waiting{ get; set; }

        /// <summary>
        /// Number of Instances Waiting for Upstream
        /// </summary>
        [JsonProperty("Depend")]
        public ulong? Depend{ get; set; }

        /// <summary>
        /// Failed Instance Count
        /// </summary>
        [JsonProperty("Failed")]
        public ulong? Failed{ get; set; }

        /// <summary>
        /// Permanently Terminated Instance Count
        /// </summary>
        [JsonProperty("Stopped")]
        public ulong? Stopped{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Success", this.Success);
            this.SetParamSimple(map, prefix + "Running", this.Running);
            this.SetParamSimple(map, prefix + "Waiting", this.Waiting);
            this.SetParamSimple(map, prefix + "Depend", this.Depend);
            this.SetParamSimple(map, prefix + "Failed", this.Failed);
            this.SetParamSimple(map, prefix + "Stopped", this.Stopped);
        }
    }
}

