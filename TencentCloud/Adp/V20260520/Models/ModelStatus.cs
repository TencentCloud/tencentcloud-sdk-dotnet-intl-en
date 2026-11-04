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

    public class ModelStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of exclusive concurrencies</p>
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }

        /// <summary>
        /// <p>Whether it is exclusive concurrency</p>
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// <p>Whether direct experience in the intelligent workbench is supported (model plaza details page: dynamically determined based on space_id; when false, the frontend disables the "experience now" button)</p>
        /// </summary>
        [JsonProperty("IsExperienceSupported")]
        public bool? IsExperienceSupported{ get; set; }

        /// <summary>
        /// <p>Resource status</p><table><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>RESOURCE_STATUS_UNSPECIFIED</td><td>0</td><td>Not specified</td></tr><tr><td>RESOURCE_STATUS_AVAILABLE</td><td>1</td><td>Resource available</td></tr><tr><td>RESOURCE_STATUS_EXHAUSTED</td><td>2</td><td>Resource exhausted</td></tr></table>
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public long? ResourceStatus{ get; set; }

        /// <summary>
        /// <p>RPM call cap (current account dimension: use the configured value if available; otherwise, take default. 0 means not obtained)</p>
        /// </summary>
        [JsonProperty("RpmLimit")]
        public string RpmLimit{ get; set; }

        /// <summary>
        /// <p>TPM call upper limit (at the current account level: use the configured value if available; otherwise, take default. 0 means failed to obtain)</p>
        /// </summary>
        [JsonProperty("TpmLimit")]
        public string TpmLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "IsExperienceSupported", this.IsExperienceSupported);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "RpmLimit", this.RpmLimit);
            this.SetParamSimple(map, prefix + "TpmLimit", this.TpmLimit);
        }
    }
}

