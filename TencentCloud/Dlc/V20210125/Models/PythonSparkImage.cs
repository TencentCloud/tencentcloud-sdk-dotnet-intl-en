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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PythonSparkImage : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the spark image
        /// </summary>
        [JsonProperty("SparkImageId")]
        public string SparkImageId{ get; set; }

        /// <summary>
        /// ID of the cluster image of the minor version
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// Name of the spark image
        /// </summary>
        [JsonProperty("SparkImageVersion")]
        public string SparkImageVersion{ get; set; }

        /// <summary>
        /// Description of the spark image
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SparkImageId", this.SparkImageId);
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamSimple(map, prefix + "SparkImageVersion", this.SparkImageVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

