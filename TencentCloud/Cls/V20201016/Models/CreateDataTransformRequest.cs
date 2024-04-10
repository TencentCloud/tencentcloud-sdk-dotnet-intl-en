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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// Task type. 1: Specify topic; 2: Dynamic creation. For details, please refer to Creating Processing Task Document (https://intl.cloud.tencent.com/document/product/614/63940?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("FuncType")]
        public long? FuncType{ get; set; }

        /// <summary>
        /// Source log topic
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// Data processing task name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Data processing statement
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// Processing type.
        /// 1: Process preview using random data from the source log topic; 2: Process preview using user-defined test data; 3: Create real processing tasks.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Destination topic_id and alias of processing task. This parameter is required when FuncType=1, and not required when FuncType=2.
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// Task status. Valid values: 1 (enabled) and 2 (disabled).
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Test data used for previewing the processing result
        /// </summary>
        [JsonProperty("PreviewLogStatistics")]
        public PreviewLogStatistic[] PreviewLogStatistics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FuncType", this.FuncType);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "PreviewLogStatistics.", this.PreviewLogStatistics);
        }
    }
}

