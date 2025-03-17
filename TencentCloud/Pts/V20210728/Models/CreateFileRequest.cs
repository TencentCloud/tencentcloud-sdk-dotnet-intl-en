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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFileRequest : AbstractModel
    {
        
        /// <summary>
        /// File ID. Its value should be the corresponding directory of the file in the COS bucket after it has been uploaded in the previous step.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// File type. 1 represents parameter file, 2 represents protocol file, 3 represents request file.
        /// </summary>
        [JsonProperty("Kind")]
        public long? Kind{ get; set; }

        /// <summary>
        /// Filename.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// File type. The 'folder' represents a folder; if not specified, it represents a file.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Number of Rows.
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }

        /// <summary>
        /// First few rows of file.
        /// </summary>
        [JsonProperty("HeadLines")]
        public string[] HeadLines{ get; set; }

        /// <summary>
        /// Last few rows of file.
        /// </summary>
        [JsonProperty("TailLines")]
        public string[] TailLines{ get; set; }

        /// <summary>
        /// Whether the header is in the file.
        /// </summary>
        [JsonProperty("HeaderInFile")]
        public bool? HeaderInFile{ get; set; }

        /// <summary>
        /// Header.
        /// </summary>
        [JsonProperty("HeaderColumns")]
        public string[] HeaderColumns{ get; set; }

        /// <summary>
        /// Files in the folder.
        /// </summary>
        [JsonProperty("FileInfos")]
        public FileInfo[] FileInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamArraySimple(map, prefix + "HeadLines.", this.HeadLines);
            this.SetParamArraySimple(map, prefix + "TailLines.", this.TailLines);
            this.SetParamSimple(map, prefix + "HeaderInFile", this.HeaderInFile);
            this.SetParamArraySimple(map, prefix + "HeaderColumns.", this.HeaderColumns);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
        }
    }
}

