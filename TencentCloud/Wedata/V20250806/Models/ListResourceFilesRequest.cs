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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListResourceFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Data page number, equal to or greater than 1. default 1.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Specifies the number of data records displayed per page. valid values: 10 to 200. default: 10.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Resource file name (fuzzy search keyword).
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Specifies the path of the file's parent folder (for example /a/b/c, querying resource files under the folder c).
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// Creator ID. obtain through the DescribeCurrentUserInfo API.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Update time range. specifies the start time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("ModifyTimeStart")]
        public string ModifyTimeStart{ get; set; }

        /// <summary>
        /// Update time range. specifies the end time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("ModifyTimeEnd")]
        public string ModifyTimeEnd{ get; set; }

        /// <summary>
        /// Create time range. specifies the start time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("CreateTimeStart")]
        public string CreateTimeStart{ get; set; }

        /// <summary>
        /// Create time range. specifies the termination time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("CreateTimeEnd")]
        public string CreateTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "ModifyTimeStart", this.ModifyTimeStart);
            this.SetParamSimple(map, prefix + "ModifyTimeEnd", this.ModifyTimeEnd);
            this.SetParamSimple(map, prefix + "CreateTimeStart", this.CreateTimeStart);
            this.SetParamSimple(map, prefix + "CreateTimeEnd", this.CreateTimeEnd);
        }
    }
}

