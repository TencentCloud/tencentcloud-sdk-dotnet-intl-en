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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Task status
        /// 
        /// <li> **PENDING** </li>  Pending
        /// <li> **PROCESSING** </li>  Executing
        /// <li> **COMPLETED** </li>  Completed
        /// <li> **FAILED** </li>  Failed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Task type
        /// 
        /// <li> **IMPORT_USER** </li>  User import
        /// <li> **EXPORT_USER** </li>  User export
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        [JsonProperty("CreatedDate")]
        public long? CreatedDate{ get; set; }

        /// <summary>
        /// Data type of the task
        /// 
        /// <li> **NDJSON** </li>  New-line Delimited JSON
        /// <li> **CSV** </li>  Comma-Separated Values
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Task result download address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Failure details
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorDetails")]
        public ErrorDetails[] ErrorDetails{ get; set; }

        /// <summary>
        /// Failed user
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FailedUsers")]
        public FailedUsers[] FailedUsers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreatedDate", this.CreatedDate);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamArrayObj(map, prefix + "ErrorDetails.", this.ErrorDetails);
            this.SetParamArrayObj(map, prefix + "FailedUsers.", this.FailedUsers);
        }
    }
}

