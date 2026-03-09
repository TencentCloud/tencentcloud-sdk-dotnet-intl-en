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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LineageProcess : AbstractModel
    {
        
        /// <summary>
        /// Original unique ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessId")]
        public string ProcessId{ get; set; }

        /// <summary>
        /// Task type
        /// Schedule task execution.
        ///     SCHEDULE_TASK,
        /// Integration task.
        ///     INTEGRATION_TASK,
        /// Third-Party reporting.
        ///     THIRD_REPORT,
        /// Data modeling.
        ///     TABLE_MODEL,
        /// Create metrics for the model.
        ///     MODEL_METRIC,
        /// Create a derived metric from atomic metrics.
        ///     METRIC_METRIC,
        /// Data service.
        ///     DATA_SERVICE
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// WEDATA, THIRD;
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Task Subtype
        ///  SQL_TASK,
        /// Integrate real-time tasks lineage.
        ///     INTEGRATED_STREAM,
        /// Integration of offline tasks lineage.
        ///     INTEGRATED_OFFLINE;
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessSubType")]
        public string ProcessSubType{ get; set; }

        /// <summary>
        /// Additional parameters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessProperties")]
        public LineageProperty[] ProcessProperties{ get; set; }

        /// <summary>
        /// Unique node ID of the lineage task.
        /// </summary>
        [JsonProperty("LineageNodeId")]
        public string LineageNodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ProcessSubType", this.ProcessSubType);
            this.SetParamArrayObj(map, prefix + "ProcessProperties.", this.ProcessProperties);
            this.SetParamSimple(map, prefix + "LineageNodeId", this.LineageNodeId);
        }
    }
}

