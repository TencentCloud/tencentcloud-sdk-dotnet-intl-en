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

    public class GetAlarmLogResponse : AbstractModel
    {
        
        /// <summary>
        /// `Context` for loading subsequent content
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// Whether all log query results are returned
        /// </summary>
        [JsonProperty("ListOver")]
        public bool? ListOver{ get; set; }

        /// <summary>
        /// Whether the return is the analysis result
        /// </summary>
        [JsonProperty("Analysis")]
        public bool? Analysis{ get; set; }

        /// <summary>
        /// If `Analysis` is `true`, column name of the analysis result will be returned; otherwise, empty content will be returned.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ColNames")]
        public string[] ColNames{ get; set; }

        /// <summary>
        /// Log query result. If `Analysis` is `True`, `null` may be returned
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Results")]
        public LogInfo[] Results{ get; set; }

        /// <summary>
        /// Log analysis result. If `Analysis` is `False`, `null` may be returned
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AnalysisResults")]
        public LogItems[] AnalysisResults{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AnalysisRecords")]
        public string[] AnalysisRecords{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "ListOver", this.ListOver);
            this.SetParamSimple(map, prefix + "Analysis", this.Analysis);
            this.SetParamArraySimple(map, prefix + "ColNames.", this.ColNames);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamArrayObj(map, prefix + "AnalysisResults.", this.AnalysisResults);
            this.SetParamArraySimple(map, prefix + "AnalysisRecords.", this.AnalysisRecords);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

