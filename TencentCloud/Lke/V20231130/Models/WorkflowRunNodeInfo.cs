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

    public class WorkflowRunNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Node type.
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Input..
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// Output.
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Task output.
        /// </summary>
        [JsonProperty("TaskOutput")]
        public string TaskOutput{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// Time consumption.
        /// </summary>
        [JsonProperty("CostMilliSeconds")]
        public ulong? CostMilliSeconds{ get; set; }

        /// <summary>
        /// Large model output information.
        /// </summary>
        [JsonProperty("StatisticInfos")]
        public StatisticInfo[] StatisticInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "TaskOutput", this.TaskOutput);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "CostMilliSeconds", this.CostMilliSeconds);
            this.SetParamArrayObj(map, prefix + "StatisticInfos.", this.StatisticInfos);
        }
    }
}

