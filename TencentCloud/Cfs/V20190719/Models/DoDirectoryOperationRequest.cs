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

    public class DoDirectoryOperationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>File system ID. Currently, only Turbo file systems support this API. General-purpose file systems (including enhanced ones) do not support this API.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>create: creates a directory, equivalent to mkdir.<br>check: checks whether a directory exists, equivalent to stat.<br>move: renames a file or directory, equivalent to mv.</p>
        /// </summary>
        [JsonProperty("OpetationType")]
        public string OpetationType{ get; set; }

        /// <summary>
        /// <p>The system recursively creates all parent directories in the path by default. The path must start with /cfs/, which represents the logical path inside the file storage instance, not the local mount point path.<br>Example:</p><ul><li><p>If the operation is create/check</p><ul><li>If the CFS root directory / is mounted, and you need to create/check whether test1/test2 exists under the mount path, the input value is /cfs/test1/test2</li><li>If the CFS subdirectory /subdir is mounted, and you need to create/check whether test1/test2 exists under the mount path, the input value is /cfs/subdir/test1/test2</li></ul></li><li><p>If the operation is move</p><ul><li>If the CFS root directory / is mounted, and you need to move files under test1/test2 to DestPath, the input value is /cfs/test1/test2</li><li>If the CFS subdirectory /subdir is mounted, and you need to move files under test1/test2 to DestPath, the input value is /cfs/subdir/test1/test2</li></ul></li></ul>
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }

        /// <summary>
        /// <p>Permission for creating the directory. If not specified, the default value is 0755. If OperationType is check, this value is meaningless.</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Target directory path for the mv operation. It must start with /cfs/, which represents the logical path inside the file storage instance, not the local mount point path.<br>Example:</p><ul><li>If the CFS root directory / is mounted, and you need to move files under DirectoryPath to test3/test4 under the mount path, the input value is /cfs/test3/test4</li><li>If the CFS subdirectory /subdir is mounted, and you need to move files under DirectoryPath to test3/test4 under the mount path, the input value is /cfs/subdir/test3/test4</li></ul>
        /// </summary>
        [JsonProperty("DestPath")]
        public string DestPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "OpetationType", this.OpetationType);
            this.SetParamSimple(map, prefix + "DirectoryPath", this.DirectoryPath);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "DestPath", this.DestPath);
        }
    }
}

