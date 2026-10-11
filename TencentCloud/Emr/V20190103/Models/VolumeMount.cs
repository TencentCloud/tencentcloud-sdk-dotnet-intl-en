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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeMount : AbstractModel
    {
        
        /// <summary>
        /// Mount volume name.
        /// </summary>
        [JsonProperty("MountName")]
        public string MountName{ get; set; }

        /// <summary>
        /// Mount path.
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }

        /// <summary>
        /// Mount type.
        /// </summary>
        [JsonProperty("SubPathMode")]
        public string SubPathMode{ get; set; }

        /// <summary>
        /// Sub-path.
        /// </summary>
        [JsonProperty("SubPath")]
        public string SubPath{ get; set; }

        /// <summary>
        /// Mounting mode. Valid values: ReadWrite and OnlyRead.
        /// </summary>
        [JsonProperty("MountMode")]
        public string MountMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MountName", this.MountName);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
            this.SetParamSimple(map, prefix + "SubPathMode", this.SubPathMode);
            this.SetParamSimple(map, prefix + "SubPath", this.SubPath);
            this.SetParamSimple(map, prefix + "MountMode", this.MountMode);
        }
    }
}

