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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseRecord : AbstractModel
    {
        
        /// <summary>
        /// Whether it can be exported
        /// </summary>
        [JsonProperty("CanExport")]
        public bool? CanExport{ get; set; }

        /// <summary>
        /// Whether it can be rolled back
        /// </summary>
        [JsonProperty("CanRollback")]
        public bool? CanRollback{ get; set; }

        /// <summary>
        /// Release description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Number of release failures
        /// </summary>
        [JsonProperty("FailCount")]
        public ulong? FailCount{ get; set; }

        /// <summary>
        /// Failure cause.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Release ID
        /// </summary>
        [JsonProperty("ReleaseId")]
        public string ReleaseId{ get; set; }

        /// <summary>
        /// Release version
        /// </summary>
        [JsonProperty("ReleaseVersion")]
        public string ReleaseVersion{ get; set; }

        /// <summary>
        /// Publishing status. Enumeration values: 1: To be released, 2: Releasing, 3: Released successfully, 4: Release failure, 5: Under review, 6: Review successful, 7: Review failed, 8: Release success callback processing, 9: Release suspended, 10: Appeal under review, 11: Appeal review passed, 12: Appeal review not approved
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Status description.
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription{ get; set; }

        /// <summary>
        /// Number of successful releases
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// Update time (Unix timestamp in seconds).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Releaser
        /// </summary>
        [JsonProperty("Updater")]
        public string Updater{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanExport", this.CanExport);
            this.SetParamSimple(map, prefix + "CanRollback", this.CanRollback);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ReleaseId", this.ReleaseId);
            this.SetParamSimple(map, prefix + "ReleaseVersion", this.ReleaseVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDescription", this.StatusDescription);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Updater", this.Updater);
        }
    }
}

