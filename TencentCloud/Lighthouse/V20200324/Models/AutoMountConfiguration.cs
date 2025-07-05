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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoMountConfiguration : AbstractModel
    {
        
        /// <summary>
        /// ID of the instance to be mounted to. The instance must be **Running**.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The mount point within the instance. Only Linux instances are supported. If it's not specified, the default mount point is "/data/disk".
        /// </summary>
        [JsonProperty("MountPoint")]
        public string MountPoint{ get; set; }

        /// <summary>
        /// The file system type. Values: `ext4` (default) and `xfs`. Only Linux instances are supported. 
        /// </summary>
        [JsonProperty("FileSystemType")]
        public string FileSystemType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MountPoint", this.MountPoint);
            this.SetParamSimple(map, prefix + "FileSystemType", this.FileSystemType);
        }
    }
}

