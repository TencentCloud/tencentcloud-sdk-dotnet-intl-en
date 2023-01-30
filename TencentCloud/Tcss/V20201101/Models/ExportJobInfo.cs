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

    public class ExportJobInfo : AbstractModel
    {
        
        /// <summary>
        /// Job ID
        /// </summary>
        [JsonProperty("JobID")]
        public string JobID{ get; set; }

        /// <summary>
        /// Job name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Source
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Export status
        /// </summary>
        [JsonProperty("ExportStatus")]
        public string ExportStatus{ get; set; }

        /// <summary>
        /// Export progress
        /// </summary>
        [JsonProperty("ExportProgress")]
        public long? ExportProgress{ get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        [JsonProperty("FailureMsg")]
        public string FailureMsg{ get; set; }

        /// <summary>
        /// Timeout threshold
        /// </summary>
        [JsonProperty("Timeout")]
        public string Timeout{ get; set; }

        /// <summary>
        /// Insertion time
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobID", this.JobID);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ExportStatus", this.ExportStatus);
            this.SetParamSimple(map, prefix + "ExportProgress", this.ExportProgress);
            this.SetParamSimple(map, prefix + "FailureMsg", this.FailureMsg);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
        }
    }
}

