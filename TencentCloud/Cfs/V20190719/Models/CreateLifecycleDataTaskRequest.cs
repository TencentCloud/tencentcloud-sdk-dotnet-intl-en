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

    public class CreateLifecycleDataTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique file system ID.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Lifecycle task type. archive: archiving; restore: preheating; release: data release; metaload: metadata loading.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Task name.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Path or file to be archived. Only one path is supported and it cannot be empty.</p>
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// <p>Data flow ID. It can be queried through DescribeDataFlow.</p>
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }

        /// <summary>
        /// <p>Whether to overwrite a file in CFSTurbo if it has the same name as a file in the external storage. true: overwrite; false: do not overwrite (and hot storage data will not be released). If this parameter is left empty, the default value is false.</p>
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }

        /// <summary>
        /// <p>Path of the data manifest file. Each line in the manifest file is the full path of a file to be processed. All paths (including the manifest file path and the paths of files to be processed in each line of the manifest file) must start with /cfs and point to existing files in the CFS file system. Specify either this parameter or TaskPath.<br>Example:</p><ul><li>If the CFS root directory / is mounted and the manifest file is located at lists/archive_list.txt under the mount path, set this parameter to /cfs/lists/archive_list.txt.</li><li>If the CFS subdirectory /subdir is mounted and the manifest file is located at lists/archive_list.txt under the mount path, set this parameter to /cfs/subdir/lists/archive_list.txt.</li></ul>
        /// </summary>
        [JsonProperty("ListPath")]
        public string ListPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskPath", this.TaskPath);
            this.SetParamSimple(map, prefix + "DataFlowId", this.DataFlowId);
            this.SetParamSimple(map, prefix + "IsOverwrite", this.IsOverwrite);
            this.SetParamSimple(map, prefix + "ListPath", this.ListPath);
        }
    }
}

