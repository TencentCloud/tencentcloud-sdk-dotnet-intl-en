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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableRollbackResultNew : AbstractModel
    {
        
        /// <summary>
        /// Table instance ID in the format of `tcaplus-3be64cbb`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// Task ID, which is valid for the API that creates one task
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Table name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table data structure type, such as `GENERIC` or `LIST`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// Table data interface description language (IDL) type, such as `PROTO` or `TDR`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// ID of the table group where a table resides
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// Error message
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// Task ID list, which is valid for the API that creates multiple tasks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// ID of uploaded key file
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Number of keys successfully verified
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuccKeyNum")]
        public ulong? SuccKeyNum{ get; set; }

        /// <summary>
        /// Total number of keys contained in key file
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalKeyNum")]
        public ulong? TotalKeyNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SuccKeyNum", this.SuccKeyNum);
            this.SetParamSimple(map, prefix + "TotalKeyNum", this.TotalKeyNum);
        }
    }
}

