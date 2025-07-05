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

    public class UpdateCfsFileSystemSizeLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// File system capacity limit in GB. Value range: 0-1,073,741,824. If 0 is entered, no limit will be imposed on the file system capacity.
        /// </summary>
        [JsonProperty("FsLimit")]
        public ulong? FsLimit{ get; set; }

        /// <summary>
        /// File system ID. Currently, only Standard file systems are supported.
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FsLimit", this.FsLimit);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
        }
    }
}

