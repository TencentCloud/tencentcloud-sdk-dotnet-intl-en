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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScenarioWithJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset. Default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returns. Default value is 20, maximum is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Array of Project ID.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// Array of Scenario ID.
        /// </summary>
        [JsonProperty("ScenarioIds")]
        public string[] ScenarioIds{ get; set; }

        /// <summary>
        /// Scenario Name.
        /// </summary>
        [JsonProperty("ScenarioName")]
        public string ScenarioName{ get; set; }

        /// <summary>
        /// Array of Scenario status.
        /// </summary>
        [JsonProperty("ScenarioStatus")]
        public long? ScenarioStatus{ get; set; }

        /// <summary>
        /// Column for sorting.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Whether in ascending order.
        /// </summary>
        [JsonProperty("Ascend")]
        public bool? Ascend{ get; set; }

        /// <summary>
        /// Parameters related to job.
        /// </summary>
        [JsonProperty("ScenarioRelatedJobsParams")]
        public ScenarioRelatedJobsParams ScenarioRelatedJobsParams{ get; set; }

        /// <summary>
        /// Whether to return the test script content of the scenario.
        /// </summary>
        [JsonProperty("IgnoreScript")]
        public bool? IgnoreScript{ get; set; }

        /// <summary>
        /// Whether to return test data file information of the scenario.
        /// </summary>
        [JsonProperty("IgnoreDataset")]
        public bool? IgnoreDataset{ get; set; }

        /// <summary>
        /// Scenario type, such as pts-http, pts-js, pts-jmeter.
        /// </summary>
        [JsonProperty("ScenarioType")]
        public string ScenarioType{ get; set; }

        /// <summary>
        /// Creator.
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ScenarioIds.", this.ScenarioIds);
            this.SetParamSimple(map, prefix + "ScenarioName", this.ScenarioName);
            this.SetParamSimple(map, prefix + "ScenarioStatus", this.ScenarioStatus);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Ascend", this.Ascend);
            this.SetParamObj(map, prefix + "ScenarioRelatedJobsParams.", this.ScenarioRelatedJobsParams);
            this.SetParamSimple(map, prefix + "IgnoreScript", this.IgnoreScript);
            this.SetParamSimple(map, prefix + "IgnoreDataset", this.IgnoreDataset);
            this.SetParamSimple(map, prefix + "ScenarioType", this.ScenarioType);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
        }
    }
}

