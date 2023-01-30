/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileAttributeInfo : AbstractModel
    {
        
        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File type
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// File path
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// File creation time
        /// </summary>
        [JsonProperty("FileCreateTime")]
        public string FileCreateTime{ get; set; }

        /// <summary>
        /// Time when the file is last tampered with
        /// </summary>
        [JsonProperty("LatestTamperedFileMTime")]
        public string LatestTamperedFileMTime{ get; set; }

        /// <summary>
        /// Content of the new file
        /// </summary>
        [JsonProperty("NewFile")]
        public string NewFile{ get; set; }

        /// <summary>
        /// Differences between old and new files
        /// </summary>
        [JsonProperty("FileDiff")]
        public string FileDiff{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileCreateTime", this.FileCreateTime);
            this.SetParamSimple(map, prefix + "LatestTamperedFileMTime", this.LatestTamperedFileMTime);
            this.SetParamSimple(map, prefix + "NewFile", this.NewFile);
            this.SetParamSimple(map, prefix + "FileDiff", this.FileDiff);
        }
    }
}

