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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetRunMetadataFileRequest : AbstractModel
    {
        
        /// <summary>
        /// Run UUID
        /// </summary>
        [JsonProperty("RunUuid")]
        public string RunUuid{ get; set; }

        /// <summary>
        /// Project ID
        /// (If you leave it blank, the default item in the specified region will be used.)
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// File names to be get
        /// 
        /// The following files are supported by default:
        /// - nextflow.log
        /// 
        /// When report is specified as true in NFOption during submission, the following files are additionally supported:
        /// - execution_report.html
        /// - execution_timeline.html
        /// - execution_trace.txt
        /// - pipeline_dag.html
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// File names to be get in batch
        /// 
        /// The following files are supported by default:
        /// - nextflow.log
        /// 
        /// When report is specified as true in NFOption during submission, the following files are additionally supported:
        /// - execution_report.html
        /// - execution_timeline.html
        /// - execution_trace.txt
        /// - pipeline_dag.html
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunUuid", this.RunUuid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
        }
    }
}

