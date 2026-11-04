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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeRun : AbstractModel
    {
        
        /// <summary>
        /// ID of the node operation
        /// </summary>
        [JsonProperty("NodeRunId")]
        public string NodeRunId{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// ID of the workflow running instance
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Node type.
        /// 1: Start node
        /// 2: Parameter extraction node
        /// 3: Large model node
        /// 4: Knowledge Q&A node
        /// 5: Knowledge retrieval node
        /// 6: Tag extraction node
        /// 7: Code execution node
        /// 8: Tool node
        /// 9: Logic judgment node
        /// 10: Reply node
        /// 11: Tab node
        /// 12: Loop node
        /// 13: Intent recognition node
        /// 14: Workflow node
        /// 15: Plug-in node
        /// 16: End node
        /// 17: Variable aggregate node data
        /// 18: Batch processing node
        /// 19: Message Queue node
        /// 20: Database node
        /// 21: Variable assignment node data
        /// 22: Variable conversion node data
        /// 23: Agent node
        /// 24: Annotation node
        /// 25: File collection node
        /// 26: Text collection node
        /// 27: Widget node
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// Running state. 1: initial status; 2: running; 3: operation successful; 4: operation failure; 5: canceled
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// Total time consumed (ms)
        /// </summary>
        [JsonProperty("TotalCostMs")]
        public long? TotalCostMs{ get; set; }

        /// <summary>
        /// Total number of tokens consumed
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty("FailCode")]
        public string FailCode{ get; set; }

        /// <summary>
        /// List of branch indexes
        /// </summary>
        [JsonProperty("BranchIndexList")]
        public long?[] BranchIndexList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeRunId", this.NodeRunId);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "TotalCostMs", this.TotalCostMs);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
            this.SetParamArraySimple(map, prefix + "BranchIndexList.", this.BranchIndexList);
        }
    }
}

