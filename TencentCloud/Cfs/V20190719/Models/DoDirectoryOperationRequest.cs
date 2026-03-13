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
        /// File system ID. currently, only Turbo series file systems support calling this api. general series file systems (including enhanced) do not support calling.
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// create a directory, equivalent to mkdir.
        /// check: confirm the existence of the directory, equivalent to stat.
        /// move: rename a file or directory, equivalent to mv.
        /// </summary>
        [JsonProperty("OpetationType")]
        public string OpetationType{ get; set; }

        /// <summary>
        /// Absolute path of the directory. recursive creation is enabled by default (if the directory contains non-existent subdirectories, create the corresponding subdirectory first).
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }

        /// <summary>
        /// Permission to create directory. if not specified, it defaults to 0755. if OperationType is check, this value is meaningless.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// The destination directory name for the mv operation. the path must start with /cfs/.
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

