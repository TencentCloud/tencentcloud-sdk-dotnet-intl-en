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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DuplicateImageRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// Source namespace name.
        /// </summary>
        [JsonProperty("SourceNamespace")]
        public string SourceNamespace{ get; set; }

        /// <summary>
        /// Source image repository name.
        /// </summary>
        [JsonProperty("SourceRepo")]
        public string SourceRepo{ get; set; }

        /// <summary>
        /// Source image tag or digest value. Currently, only tag is supported.
        /// </summary>
        [JsonProperty("SourceReference")]
        public string SourceReference{ get; set; }

        /// <summary>
        /// Destination image version.
        /// </summary>
        [JsonProperty("DestinationTag")]
        public string DestinationTag{ get; set; }

        /// <summary>
        /// Destination namespace. Defaults to the same as the source if not filled.
        /// </summary>
        [JsonProperty("DestinationNamespace")]
        public string DestinationNamespace{ get; set; }

        /// <summary>
        /// Destination image repository. Defaults to the same as the source if not filled.
        /// </summary>
        [JsonProperty("DestinationRepo")]
        public string DestinationRepo{ get; set; }

        /// <summary>
        /// Whether to overwrite.
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "SourceNamespace", this.SourceNamespace);
            this.SetParamSimple(map, prefix + "SourceRepo", this.SourceRepo);
            this.SetParamSimple(map, prefix + "SourceReference", this.SourceReference);
            this.SetParamSimple(map, prefix + "DestinationTag", this.DestinationTag);
            this.SetParamSimple(map, prefix + "DestinationNamespace", this.DestinationNamespace);
            this.SetParamSimple(map, prefix + "DestinationRepo", this.DestinationRepo);
            this.SetParamSimple(map, prefix + "Override", this.Override);
        }
    }
}

