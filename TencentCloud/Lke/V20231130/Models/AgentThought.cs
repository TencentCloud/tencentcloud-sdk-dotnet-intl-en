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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentThought : AbstractModel
    {
        
        /// <summary>
        /// Session ID.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Request ID
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// It corresponds to a session, session ID, used for message storage in answering. It can be generated in advance and used when saving messages.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Current request execution time, in milliseconds.
        /// </summary>
        [JsonProperty("Elapsed")]
        public ulong? Elapsed{ get; set; }

        /// <summary>
        /// Whether it is a workflow currently.
        /// </summary>
        [JsonProperty("IsWorkflow")]
        public bool? IsWorkflow{ get; set; }

        /// <summary>
        /// If it is a workflow, workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Detailed thinking process.
        /// </summary>
        [JsonProperty("Procedures")]
        public AgentProcedure[] Procedures{ get; set; }

        /// <summary>
        /// TraceId.
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// File information
        /// </summary>
        [JsonProperty("Files")]
        public FileInfo[] Files{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "IsWorkflow", this.IsWorkflow);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamArrayObj(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamArrayObj(map, prefix + "Files.", this.Files);
        }
    }
}

