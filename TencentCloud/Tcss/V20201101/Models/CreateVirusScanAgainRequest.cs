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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVirusScanAgainRequest : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Set of IDs of containers to be scanned
        /// </summary>
        [JsonProperty("ContainerIds")]
        public string[] ContainerIds{ get; set; }

        /// <summary>
        /// Whether to scan all timed-out containers
        /// </summary>
        [JsonProperty("TimeoutAll")]
        public bool? TimeoutAll{ get; set; }

        /// <summary>
        /// New timeout period
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "ContainerIds.", this.ContainerIds);
            this.SetParamSimple(map, prefix + "TimeoutAll", this.TimeoutAll);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

