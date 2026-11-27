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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyPathLifecyclePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Lifecycle management policy ID.</p>
        /// </summary>
        [JsonProperty("LifecyclePolicyID")]
        public string LifecyclePolicyID{ get; set; }

        /// <summary>
        /// <p>List of directory paths associated with the lifecycle management policy. Each path must start with /cfs/, representing a logical path within the file storage instance, not a local mount point path.</p><p>Examples:</p><ul><li>If the CFS root directory / is mounted and you need to associate test1/test2 under the mount path, the input value is /cfs/test1/test2.</li><li>If the CFS subdirectory /subdir is mounted and you need to associate test1/test2 under the mount path, the input value is /cfs/subdir/test1/test2.</li></ul>
        /// </summary>
        [JsonProperty("Paths")]
        public PathInfo[] Paths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecyclePolicyID", this.LifecyclePolicyID);
            this.SetParamArrayObj(map, prefix + "Paths.", this.Paths);
        }
    }
}

