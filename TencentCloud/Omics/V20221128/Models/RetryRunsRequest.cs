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

    public class RetryRunsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID. (If you leave it blank, the default item in the specified region will be used.)
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// The run group ID that needs to be retried
        /// </summary>
        [JsonProperty("RunGroupId")]
        public string RunGroupId{ get; set; }

        /// <summary>
        /// The run UUID that needs to be retried
        /// </summary>
        [JsonProperty("RunUuids")]
        public string[] RunUuids{ get; set; }

        /// <summary>
        /// WDL running option. If you leave it blank, the retried run group running option will be used.
        /// </summary>
        [JsonProperty("WDLOption")]
        public RunOption WDLOption{ get; set; }

        /// <summary>
        /// Nextflow running option. If you leave it blank, the retried run group running option will be used.
        /// </summary>
        [JsonProperty("NFOption")]
        public NFOption NFOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RunGroupId", this.RunGroupId);
            this.SetParamArraySimple(map, prefix + "RunUuids.", this.RunUuids);
            this.SetParamObj(map, prefix + "WDLOption.", this.WDLOption);
            this.SetParamObj(map, prefix + "NFOption.", this.NFOption);
        }
    }
}

