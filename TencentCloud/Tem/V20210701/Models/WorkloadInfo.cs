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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadInfo : AbstractModel
    {
        
        /// <summary>
        /// The resource ID.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Application name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Version name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// Number of ready replicas
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReadyReplicas")]
        public long? ReadyReplicas{ get; set; }

        /// <summary>
        /// Number of replicas
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// Number of updated replicas
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdatedReplicas")]
        public long? UpdatedReplicas{ get; set; }

        /// <summary>
        /// Number of replicas ready for update
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdatedReadyReplicas")]
        public long? UpdatedReadyReplicas{ get; set; }

        /// <summary>
        /// ## Version Updates
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateRevision")]
        public string UpdateRevision{ get; set; }

        /// <summary>
        /// Current Version
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CurrentRevision")]
        public string CurrentRevision{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "ReadyReplicas", this.ReadyReplicas);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "UpdatedReplicas", this.UpdatedReplicas);
            this.SetParamSimple(map, prefix + "UpdatedReadyReplicas", this.UpdatedReadyReplicas);
            this.SetParamSimple(map, prefix + "UpdateRevision", this.UpdateRevision);
            this.SetParamSimple(map, prefix + "CurrentRevision", this.CurrentRevision);
        }
    }
}

