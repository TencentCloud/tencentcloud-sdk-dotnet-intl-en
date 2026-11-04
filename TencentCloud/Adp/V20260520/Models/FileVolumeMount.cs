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

    public class FileVolumeMount : AbstractModel
    {
        
        /// <summary>
        /// <p>Access mode: RO=read-only, RW=read-write; required. Only RW can be used when mounting to /workdir.</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>Absolute mount directory in the sandbox; /workdir can be mounted at most once and only RW can be used.</p>
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }

        /// <summary>
        /// <p>Cloud disk identification</p>
        /// </summary>
        [JsonProperty("VolumeId")]
        public string VolumeId{ get; set; }

        /// <summary>
        /// <p>Server-side generated mount flag. Reserved for modification, optional for new additions.</p>
        /// </summary>
        [JsonProperty("MountId")]
        public string MountId{ get; set; }

        /// <summary>
        /// <p>Path relative to the root directory of cloud disk data; an empty string indicates mounting the entire data root directory.</p>
        /// </summary>
        [JsonProperty("RelativePath")]
        public string RelativePath{ get; set; }

        /// <summary>
        /// <p>Cloud disk name. It is supplemented by the server only when querying the application configuration and ignored during modification. It is empty when it cannot be obtained and does not impact the mount configuration.</p>
        /// </summary>
        [JsonProperty("VolumeName")]
        public string VolumeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
            this.SetParamSimple(map, prefix + "VolumeId", this.VolumeId);
            this.SetParamSimple(map, prefix + "MountId", this.MountId);
            this.SetParamSimple(map, prefix + "RelativePath", this.RelativePath);
            this.SetParamSimple(map, prefix + "VolumeName", this.VolumeName);
        }
    }
}

