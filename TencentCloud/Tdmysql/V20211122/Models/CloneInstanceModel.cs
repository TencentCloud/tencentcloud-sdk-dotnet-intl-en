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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneInstanceModel : AbstractModel
    {
        
        /// <summary>
        /// Clone task end time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneEndTime")]
        public string CloneEndTime{ get; set; }

        /// <summary>
        /// Clone record ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneId")]
        public long? CloneId{ get; set; }

        /// <summary>
        /// Clone instance type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneInsType")]
        public string CloneInsType{ get; set; }

        /// <summary>
        /// Clone instance ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneInstanceId")]
        public string CloneInstanceId{ get; set; }

        /// <summary>
        /// Whether the clone instance is deleted.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneInstanceIsDeleted")]
        public bool? CloneInstanceIsDeleted{ get; set; }

        /// <summary>
        /// Task progress of clone.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneProgress")]
        public float? CloneProgress{ get; set; }

        /// <summary>
        /// Task start time of the clone.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneStartTime")]
        public string CloneStartTime{ get; set; }

        /// <summary>
        /// Task status.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneStatus")]
        public string CloneStatus{ get; set; }

        /// <summary>
        /// Clone time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneTime")]
        public string CloneTime{ get; set; }

        /// <summary>
        /// Clone type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CloneType")]
        public string CloneType{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Engine type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBType")]
        public string DBType{ get; set; }

        /// <summary>
        /// Region.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Source instance ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloneEndTime", this.CloneEndTime);
            this.SetParamSimple(map, prefix + "CloneId", this.CloneId);
            this.SetParamSimple(map, prefix + "CloneInsType", this.CloneInsType);
            this.SetParamSimple(map, prefix + "CloneInstanceId", this.CloneInstanceId);
            this.SetParamSimple(map, prefix + "CloneInstanceIsDeleted", this.CloneInstanceIsDeleted);
            this.SetParamSimple(map, prefix + "CloneProgress", this.CloneProgress);
            this.SetParamSimple(map, prefix + "CloneStartTime", this.CloneStartTime);
            this.SetParamSimple(map, prefix + "CloneStatus", this.CloneStatus);
            this.SetParamSimple(map, prefix + "CloneTime", this.CloneTime);
            this.SetParamSimple(map, prefix + "CloneType", this.CloneType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DBType", this.DBType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
        }
    }
}

