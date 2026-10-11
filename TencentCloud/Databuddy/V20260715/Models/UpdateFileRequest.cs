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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFileRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID. Source: WorkspaceId returned by the ListWorkspaces API</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>File ID. Source: FileId returned by the CreateFile / ListFiles / GetFile APIs</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>File operation configuration. If not passed, the configuration will not be updated.</p>
        /// </summary>
        [JsonProperty("FileConfig")]
        public FileConfig FileConfig{ get; set; }

        /// <summary>
        /// <p>File type. Parameter Value: FILE (regular file/script), NOTEBOOK_FILE (Notebook), SQL_FILE (SQL file). Corresponds to common/domain/entity.proto EntityType</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>Bound BundleId. Source: BundleId returned by the ListBundles API</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bound BundleInfo, JSON string</p>
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>File content. If not passed, the content will not be updated.</p>
        /// </summary>
        [JsonProperty("Storage")]
        public FileStorage Storage{ get; set; }

        /// <summary>
        /// <p>Target file name. When it is not empty and different from the current file name, perform the rename action. Length not exceeding SCRIPT_NAME_MAX_LENGTH. It must not begin or end with . or .., and spaces, double dots, control characters, and Linux reserved names are forbidden (see docs/linux_filename_rules.md). Validate the suffix legitimacy together with ExtensionType.</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>Target parent directory path. If not empty, execute the move action. For the root directory, pass /; it can simultaneously appear with FileName, with the semantics of "move + rename". It should be consistent with ParentFolderPath of CreateFile.</p>
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// <p>FileType of the target parent directory. Value: FOLDER, GIT_FOLDER. Used only when ParentFolderPath is not empty; by default, it is handled based on the actual type of the parsed parent directory</p>
        /// </summary>
        [JsonProperty("TargetFileType")]
        public string TargetFileType{ get; set; }

        /// <summary>
        /// <p>Action type (optional, default value: 1, mandatory verification in future versions). Value: 1 = UPDATE_CONTENT (only refresh FileConfig / Storage / Bundle*, forbid passing FileName / ParentFolderPath / TargetFileType); 2 = RENAME (rename only, must pass FileName, forbid passing ParentFolderPath / FileConfig / Storage / Bundle*); 3 = MOVE (move only, must pass ParentFolderPath, forbid passing FileName / FileConfig / Storage / Bundle*). A ParamIllegal error will be returned if parameter mutual exclusion verification fails</p>
        /// </summary>
        [JsonProperty("UpdateAction")]
        public long? UpdateAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "FileConfig.", this.FileConfig);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "TargetFileType", this.TargetFileType);
            this.SetParamSimple(map, prefix + "UpdateAction", this.UpdateAction);
        }
    }
}

