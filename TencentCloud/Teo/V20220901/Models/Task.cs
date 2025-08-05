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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// ID of the task.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Resource.
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Type of the task.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Node cache purge method. valid values:.
        /// <li>invalidate: marks as expired. a back-to-origin validation is triggered upon user request, sending an HTTP conditional request with If-None-Match and If-Modified-Since headers. If the origin server responds with 200, the node will fetch new resources from the origin and update the cache; If the origin server responds with 304, the cache will not be updated;</li>.
        /// <Li>Delete: directly deletes the node's cache, triggering a resource fetch from the origin upon user request.</li>.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Status. valid values:.
        /// <li>processing: indicates the operation is in progress.</li>.
        /// <Li>Success: specifies the success status.</li>.
        /// <li>failed: indicates a failure.</li>.
        /// <Li>Timeout: specifies the timeout period.</li>.
        /// <Li>Canceled: canceled.</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time of the task.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Completion time of the task.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Refresh and preheat failure type. valid values:.
        /// <li>taskFailed: specifies the task failure.</li>.
        /// <li>quotaExceeded: specifies the quota exceeded status.</li>.
        /// <li>downloadManifestFailed: specifies the file failed to download.</li>.
        /// <li>accessDenied: specifies access denied.</li>.
        /// <li>originPullFailed: specifies the origin-pull failure.</li>.
        /// </summary>
        [JsonProperty("FailType")]
        public string FailType{ get; set; }

        /// <summary>
        /// Failure description for refresh and preheating.
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "FailType", this.FailType);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
        }
    }
}

