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

    public class FileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Root account AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>File ID</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>File name, including suffix</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>File type. Parameter Value: FILE (regular file/script), NOTEBOOK_FILE (Notebook), SQL_FILE (SQL file). Corresponds to common/domain/entity.proto EntityType</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>Full path of the file in the workspace, starting with /, for example /etl/daily/demo.ipynb</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>File operation configuration.</p>
        /// </summary>
        [JsonProperty("FileConfig")]
        public FileConfig FileConfig{ get; set; }

        /// <summary>
        /// <p>Bound BundleId</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bound BundleInfo, JSON string</p>
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>File status. active=normal, deleted=deleted</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>File owner userName</p>
        /// </summary>
        [JsonProperty("OwnerUserName")]
        public string OwnerUserName{ get; set; }

        /// <summary>
        /// <p>Creator sub-account Uin.</p>
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>Last updated by sub-account Uin</p>
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// <p>Creation time, millisecond-level timestamp</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Latest update time, millisecond-level timestamp</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>File storage information. Content is returned only when the request IncludeContent=true</p>
        /// </summary>
        [JsonProperty("Storage")]
        public FileStorage Storage{ get; set; }

        /// <summary>
        /// <p>Permission point list of the current caller for the file</p>
        /// </summary>
        [JsonProperty("Permissions")]
        public string Permissions{ get; set; }

        /// <summary>
        /// <p>Whether it is released</p>
        /// </summary>
        [JsonProperty("ReleaseStatus")]
        public bool? ReleaseStatus{ get; set; }

        /// <summary>
        /// <p>Resource mode. 1=distributed, 2=single-node</p>
        /// </summary>
        [JsonProperty("ResourceMode")]
        public long? ResourceMode{ get; set; }

        /// <summary>
        /// <p>Pass through Workspace job information during async file preview job creation; leave this field unset for ordinary sync creation or other APIs that reuse this return structure</p>
        /// </summary>
        [JsonProperty("AsyncOperation")]
        public AsyncOperation AsyncOperation{ get; set; }

        /// <summary>
        /// <p>Script version ID.</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamObj(map, prefix + "FileConfig.", this.FileConfig);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OwnerUserName", this.OwnerUserName);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamSimple(map, prefix + "Permissions", this.Permissions);
            this.SetParamSimple(map, prefix + "ReleaseStatus", this.ReleaseStatus);
            this.SetParamSimple(map, prefix + "ResourceMode", this.ResourceMode);
            this.SetParamObj(map, prefix + "AsyncOperation.", this.AsyncOperation);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
        }
    }
}

